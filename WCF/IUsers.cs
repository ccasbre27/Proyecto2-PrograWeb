using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    [ServiceContract]
    interface IUsers
    {
        [OperationContract]
        List<User> GetAll();

        [OperationContract]
        User Get(int userId);

        [OperationContract]
        User Add(User user);

        [OperationContract]
        User Update(User user);

        [OperationContract]
        void Delete(int userId);
    }
}
