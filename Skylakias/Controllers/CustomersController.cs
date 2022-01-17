using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Skylakias.Models;
using System.Data.Entity;
using System.Net;

namespace Skylakias.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var customers = _context.Users.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(string id)
        {
            var customer = _context.Users.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationUser user = _context.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }



    }
}