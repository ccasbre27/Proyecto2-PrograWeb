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
        private List<User> usersList;

        public Users()
        {
            usersList = new List<User>();
            usersList.Add(new User() { Id = 1, FullName = Guid.NewGuid().ToString() });
            usersList.Add(new User() { Id = 2, FullName = Guid.NewGuid().ToString() });
            usersList.Add(new User() { Id = 3, FullName = Guid.NewGuid().ToString() });
            usersList.Add(new User() { Id = 4, FullName = Guid.NewGuid().ToString() });
        }

        #region GetAll
        public List<User> GetAll()
        {
            return usersList;
        }
        #endregion

        #region Get
        public User Get(int productId)
        {
            return SearchUser(productId);
        }
        #endregion

        #region Add
        public User Add(User user)
        {
            if (user != null)
            {
                usersList.Add(user);
            }

            return user;
        }
        #endregion

        #region Update
        public User Update(User user)
        {
            User userAux = null;
            if (user != null)
            {
                userAux = SearchUser(user.Id);
                if (userAux != null)
                {
                    userAux.FullName = user.FullName;
                    userAux.DNI = user.DNI;
                    userAux.Type = user.Type;
                }
            }

            return userAux;
        }
        #endregion

        #region Delete
        public void Delete(int userId)
        {
            if (userId > 0)
            {
                User user = SearchUser(userId);
                if (user != null)
                {
                    usersList.Remove(user);
                }
            }
        }
        #endregion

        private User SearchUser(int userId)
        {
            return usersList.Where(c => c.Id == userId).Select(c => c).SingleOrDefault();
        }
    }
}
