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
    interface IProducts
    {
        [OperationContract]
        List<Product> GetAll();

        [OperationContract]
        Product Get(int productId);

        [OperationContract]
        Task<Product> Add(Product product);

        [OperationContract]
        Task<Product> Update(Product product);

        [OperationContract]
        void Delete(int productId);

    }
}
