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
    interface IUserTypes
    {
        [OperationContract]
        List<UserType> GetAll();
    }
}
