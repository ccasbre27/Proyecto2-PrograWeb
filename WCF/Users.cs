using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    public class Users : IUsers
    {
        P2Context db = null;

        public Users()
        {
            db = new P2Context();
        }

        #region GetAll
        public List<User> GetAll()
        {
            var results =
                from user in db.Users
                select user;

            return results.ToList();
        }
        #endregion

        #region Get
        public User Get(int userId)
        {
            return SearchUser(userId);
        }
        #endregion

        #region CheckUser
        public User CheckUser(User user)
        {
            return 
               (from item in db.Users
                where item.DNI == user.DNI && item.Password == user.Password
                select item).FirstOrDefault();
        }
        #endregion

        #region Add
        public async Task<User> Add(User user)
        {
            // se verifica si el usuario a agregar tiene datos
            if (user != null)
            {
                // se agrega el usuario
                db.Users.Add(user);

                // salvamos los datos
                await db.SaveChangesAsync();
            }

            return user;
        }
        #endregion

        #region Update
        public async Task<User> Update(User user)
        {
            User userAux = null;

            // se verifica si el usuario que se recibe no es null
            if (user != null)
            {
                // se busca el usuario
                userAux = SearchUser(user.Id);

                // se verifica si se encontró el usuario
                if (userAux != null)
                {
                    // se establecen los nuevos valores a excepción del ID que no se puede cambiar
                    userAux.FullName = user.FullName;
                    userAux.DNI = user.DNI;
                    userAux.UserTypeID = user.UserTypeID;

                    // se establece la entidad como modificada para que se apliquen los cambios
                    db.Entry(userAux).State = System.Data.Entity.EntityState.Modified;

                    // guardamos los cambios
                    await db.SaveChangesAsync();
                }
            }

            return userAux;
        }
        #endregion

        #region Delete
        public async void Delete(int userId)
        {
            
            // se busca el usuario
            User userAux = SearchUser(userId);

            // se verifica si se encontró el usuario
            if (userAux != null)
            {
                // se establece la entidad como modificada para que se apliquen los cambios
                db.Entry(userAux).State = System.Data.Entity.EntityState.Deleted;

                // guardamos los cambios
                await db.SaveChangesAsync();
            }
            
        }
        #endregion

        private User SearchUser(int userId)
        {
            var result =
                (from user in db.Users
                where user.Id == userId
                select user).FirstOrDefault();

            return result as User;
        }
    }
}
