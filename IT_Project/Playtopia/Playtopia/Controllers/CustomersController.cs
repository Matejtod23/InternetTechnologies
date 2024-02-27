using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Playtopia.Models;

namespace Playtopia.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Customers
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                if (User.Identity.IsAuthenticated)
                {
                    Customer customer1 = db.Customers.FirstOrDefault(c => c.Email.Equals(User.Identity.Name));
                    return View(customer1);
                }
                else
                {
                    return RedirectToAction("Login", "Account");
                }
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        

        [HttpPost]
        public ActionResult BuyGame(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                var customer = db.Customers.FirstOrDefault(c => c.Email.Equals(User.Identity.Name));
                var game = db.Games.Find(id);
                customer.Games.Add(game);
                db.SaveChanges();
                return RedirectToAction("ShoppingCart", new { id = customer.Id });
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public ActionResult ShoppingCart(int? id)
        {
            if (id == null)
            {
                if (User.Identity.IsAuthenticated)
                {
                    Customer customer1 = db.Customers.FirstOrDefault(c => c.Email.Equals(User.Identity.Name));
                    return View(customer1);
                }
                else
                {
                    return RedirectToAction("Login", "Account");
                }
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }


        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Age,Email")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(customer);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Age,Email")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        public ActionResult RemoveGame(int? id)
        {
            Customer customer = db.Customers.FirstOrDefault(c => c.Email.Equals(User.Identity.Name));
            Game gameToRemove = customer.Games.FirstOrDefault(c => c.Id == id);
            customer.Games.Remove(gameToRemove);
            db.SaveChanges();
            return RedirectToAction("ShoppingCart", new { id = customer.Id});
        }
        [HttpPost]
        public ActionResult RemoveAllGames()
        {
            Customer customer = db.Customers.FirstOrDefault(c => c.Email.Equals(User.Identity.Name));
            customer.Games.Clear();
            db.SaveChanges();
            return RedirectToAction("Index", "Games");
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
