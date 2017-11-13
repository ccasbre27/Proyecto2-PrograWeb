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

            // BORRAR -**************
            Utilities.LoggedUser.UserTypeID = UserTypeEnum.Admin;

            /////////////////

            return View(api.GetAll());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            ProductsClient api = new ProductsClient();

            Product product = api.Get(id);

            if (product == null)
            {
                return HttpNotFound();
            }
            
            return View(product);
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

        //// GET: product/delete/5
        //public async task<actionresult> delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new httpstatuscoderesult(httpstatuscode.badrequest);
        //    }
        //    product product = await db.products.findasync(id);
        //    if (product == null)
        //    {
        //        return httpnotfound();
        //    }
        //    return view(product);
        //}

        //// post: product/delete/5
        //[httppost, actionname("delete")]
        //[validateantiforgerytoken]
        //public async task<actionresult> deleteconfirmed(int id)
        //{
        //    product product = await db.products.findasync(id);
        //    db.products.remove(product);
        //    await db.savechangesasync();
        //    return redirecttoaction("index");
        //}

        //protected override void dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.dispose();
        //    }
        //    base.dispose(disposing);
        //}
    }
}
