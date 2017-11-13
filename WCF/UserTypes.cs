using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace WCF
{
    public class UserTypes : IUserTypes
    {
        P2Context db = null;

        public UserTypes()
        {
            db = new P2Context();
        }

        public List<UserType> GetAll()
        {
            try
            {
               var results =
               from item in db.UserTypes
               select item;

                return results.ToList();
            }
            catch (Exception e)
            {


            }

            return new List<UserType>();
        }
    }
}
