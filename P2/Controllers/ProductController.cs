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

            List<Entities.Product> finalResults = new List<Entities.Product>();
            
            P2.Products.Product [] productsAPI = productsClient.GetAll();

            foreach (P2.Products.Product item in productsAPI)
            {
                finalResults.Add(Utilities.MapClass<Entities.Product>(item));
            }

            return View(finalResults);
        }

        //// get: product/details/5
        //public async task<actionresult> details(int? id)
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

        //// get: product/create
        //public actionresult create()
        //{
        //    return view();
        //}

        //// post: product/create
        //// para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. para obtener 
        //// más información vea http://go.microsoft.com/fwlink/?linkid=317598.
        //[httppost]
        //[validateantiforgerytoken]
        //public async task<actionresult> create([bind(include = "id,description,price,category,isactive")] product product)
        //{
        //    if (modelstate.isvalid)
        //    {
        //        db.products.add(product);
        //        await db.savechangesasync();
        //        return redirecttoaction("index");
        //    }

        //    return view(product);
        //}

        //// get: product/edit/5
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

        //// post: product/edit/5
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

        //// get: product/delete/5
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
