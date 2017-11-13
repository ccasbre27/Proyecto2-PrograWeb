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
using P2.Models;
using P2.Users;
using P2.UserTypes;

namespace P2.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: User
        public async Task<ActionResult> Index()
        {
            UsersClient api = new UsersClient();
            
            return View(await api.GetAllAsync());
        }

        // GET: User/Create
        public async Task<ActionResult> Create()
        {
            ViewBag.UserTypeID = LoadUserTypes();
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {

                UsersClient api = new UsersClient();

                await api.AddAsync(user);

                return RedirectToAction("Index");
            }

            ViewBag.UserTypeID = LoadUserTypes();
            return View(user);
        }

        // GET: User/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            UsersClient api = new UsersClient();

            User user = await api.GetAsync(id);

            if (user == null)
            {
                return HttpNotFound();
            }

            ViewBag.UserTypeID = LoadUserTypes();

            return View(user);
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(User user)
        {
            if (ModelState.IsValid)
            {
                UsersClient api = new UsersClient();

                await api.UpdateAsync(user);

                return RedirectToAction("Index");
            }

            ViewBag.UserTypeID = LoadUserTypes();

            return View(user);
        }

        // GET: User/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            UsersClient api = new UsersClient();

            User user = await api.GetAsync(id);

            if (user == null)
            {
                return HttpNotFound();
            }

            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            UsersClient api = new UsersClient();
            await api.DeleteAsync(id);

            return RedirectToAction("Index");
        }
        
        private SelectList LoadUserTypes()
        {
            UserTypesClient api = new UserTypesClient();

            UserType[] userTypes = api.GetAll();

            return new SelectList(userTypes, "Id", "Name");
        }
    }
}
