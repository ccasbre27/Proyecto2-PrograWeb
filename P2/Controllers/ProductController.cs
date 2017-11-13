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
            ProductsClient productsClient = new ProductsClient();

            return View(productsClient.GetAll());
        }

        // GET: Product/Details/5
        public async Task<ActionResult> Details(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            ProductsClient productsClient = new ProductsClient();

            Product product = productsClient.Get(id);

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
        // para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. para obtener 
        // más información vea http://go.microsoft.com/fwlink/?linkid=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductsClient productsClient = new ProductsClient();
                
                productsClient.Add(product);
                
                return RedirectToAction("Index");
            }

            return View(product);
        }

        //// GET: product/edit/5
        //public async task<actionresult> edit(int? id)
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

        //// POST: product/edit/5
        //// para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. para obtener 
        //// más información vea http://go.microsoft.com/fwlink/?linkid=317598.
        //[httppost]
        //[validateantiforgerytoken]
        //public async task<actionresult> edit([bind(include = "id,description,price,category,isactive")] product product)
        //{
        //    if (modelstate.isvalid)
        //    {
        //        db.entry(product).state = entitystate.modified;
        //        await db.savechangesasync();
        //        return redirecttoaction("index");
        //    }
        //    return view(product);
        //}

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
