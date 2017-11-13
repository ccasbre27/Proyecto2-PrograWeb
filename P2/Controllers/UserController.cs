﻿using System;
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

        //// GET: User/Details/5
        //public async Task<ActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    User user = await db.Users.FindAsync(id);
        //    if (user == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(user);
        //}

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

        //// GET: User/Edit/5
        //public async Task<ActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    User user = await db.Users.FindAsync(id);
        //    if (user == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.UserTypeID = new SelectList(db.UserTypes, "Id", "Name", user.UserTypeID);
        //    return View(user);
        //}

        //// POST: User/Edit/5
        //// Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        //// más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Edit([Bind(Include = "Id,DNI,FullName,Password,UserTypeID")] User user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(user).State = EntityState.Modified;
        //        await db.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.UserTypeID = new SelectList(db.UserTypes, "Id", "Name", user.UserTypeID);
        //    return View(user);
        //}

        //// GET: User/Delete/5
        //public async Task<ActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    User user = await db.Users.FindAsync(id);
        //    if (user == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(user);
        //}

        //// POST: User/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> DeleteConfirmed(int id)
        //{
        //    User user = await db.Users.FindAsync(id);
        //    db.Users.Remove(user);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        private SelectList LoadUserTypes()
        {
            UserTypesClient api = new UserTypesClient();

            UserType[] userTypes = api.GetAll();

            return new SelectList(userTypes, "Id", "Name");
        }
    }
}
