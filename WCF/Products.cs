using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    public class Products : IProducts
    {
        private List<Product> productsList;

        public Products()
        {
            productsList = new List<Product>();
            productsList.Add(new Product() { Id = 1, Description = Guid.NewGuid().ToString() });
            productsList.Add(new Product() { Id = 2, Description = Guid.NewGuid().ToString() });
            productsList.Add(new Product() { Id = 3, Description = Guid.NewGuid().ToString() });
            productsList.Add(new Product() { Id = 4, Description = Guid.NewGuid().ToString() });
        }

        #region GetAll
        public List<Product> GetAll()
        {
            return productsList;
        }
        #endregion

        #region Get
        public Product Get(int productId)
        {
            return SearchProduct(productId);
        }
        #endregion

        #region Add
        public Product Add(Product product)
        {
            if (product != null)
            {
                productsList.Add(product);
            }

            return product;
        }
        #endregion

        #region Update
        public Product Update(Product product)
        {
            Product productAux = null;
            if (product != null)
            {
                productAux = SearchProduct(product.Id);
                if (productAux != null)
                {
                    productAux.Description = product.Description;
                    productAux.Category = product.Category;
                }
            }

            return productAux;
        }
        #endregion

        #region Delete
        public void Delete(int productId)
        {
            if (productId > 0)
            {
                Product product = SearchProduct(productId);
                if (product != null)
                {
                    productsList.Remove(product);
                }
            }
        }
        #endregion

        private Product SearchProduct(int productId)
        {
            return productsList.Where(c => c.Id == productId).Select(c => c).SingleOrDefault();
        }
    }
}
