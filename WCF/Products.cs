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
        P2Context db = null;

        public Products()
        {
            db = new P2Context();
        }

        #region GetAll
        public List<Product> GetAll()
        {
            try
            {
                 var results = 
                from product in db.Products
                select product;

                return results.ToList();
            }
            catch (Exception e)
            {

               
            }

            return new List<Product>();

        }
        #endregion

        #region Get
        public Product Get(int productId)
        {
            return SearchProduct(productId);
        }
        #endregion

        #region Add
        public async Task<Product> Add(Product product)
        {
            // se verifica si el producto a agregar tiene datos
            if (product != null)
            {
                // se agrega el producto
                db.Products.Add(product);
                
                // se guardan los cambios
                await db.SaveChangesAsync();
            }

            return product;
        }
        #endregion

        #region Update
        public async Task<Product> Update(Product product)
        {
            Product productAux = null;

            // se verifica si el proucto que se recibe no es null
            if (product != null)
            {
                // se busca el producto
                productAux = SearchProduct(product.Id);

                // se verifica si se encontró
                if (productAux != null)
                {
                    // se establecen los nuevos valores en las propiedades a excepción del ID que no se puede cambiar
                    productAux.Description = product.Description;
                    productAux.Category = product.Category;

                    // se establece la entidad como modificada para que se apliquen los cambios
                    db.Entry(productAux).State = System.Data.Entity.EntityState.Modified;

                    // guardamos los cambios
                    await db.SaveChangesAsync();
                }
            }

            return productAux;
        }
        #endregion

        #region Delete
        public async void Delete(int productId)
        {
            // se busca el producto
            Product productAux = SearchProduct(productId);

            // se verifica si se encontró el producto
            if (productAux != null)
            {
                // se establece la entidad como modificada para que se apliquen los cambios
                db.Entry(productAux).State = System.Data.Entity.EntityState.Deleted;

                // guardamos los cambios
                await db.SaveChangesAsync();
            }
            
        }
        #endregion

        private Product SearchProduct(int productId)
        {
            return db.Products.Where(c => c.Id == productId).Select(c => c).SingleOrDefault();
        }
    }
}
