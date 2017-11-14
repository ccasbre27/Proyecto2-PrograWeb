using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entities;
using P2.Products;
using P2.Utils;

namespace P2.Controllers
{
    public class ProductController : Controller
    {
       
        // GET: Product
        public async Task<ActionResult> Index()
        {
            ProductsClient api = new ProductsClient();

            return View(api.GetAll());
        }
        
        // get: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: product/create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductsClient api = new ProductsClient();
                
                await api.AddAsync(product);
                
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: product/edit/5
        public async Task<ActionResult> Edit(int id)
        {
            ProductsClient api = new ProductsClient();

            Product product = await api.GetAsync(id);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }

        // Post: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductsClient api = new ProductsClient();

                await api.UpdateAsync(product);

                return RedirectToAction("Index");
            }

            return View(product);
        }

        public async Task<ActionResult> Delete(int id)
        {
            ProductsClient api = new ProductsClient();

            Product product = api.Get(id);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }

        // Post: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ProductsClient api = new ProductsClient();

            await api.DeleteAsync(id);

            return RedirectToAction("Index");
        }

        

    }
}
