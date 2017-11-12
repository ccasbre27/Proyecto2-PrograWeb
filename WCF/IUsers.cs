using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace WCF
{
    [ServiceContract]
    interface IUsers
    {
        [OperationContract]
        List<User> GetAll();

        [OperationContract]
        User Get(int productId);

        [OperationContract]
        Task<User> Add(User user);

        [OperationContract]
        Task<User> Update(User user);

        [OperationContract]
        void Delete(int userId);
    }
}
