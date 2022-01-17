using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Skylakias.Models;
using Skylakias.ViewModels;

namespace Skylakias.Controllers
{
    public class CustomerOrderController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: CustomerOrder
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var list = db.Orders.Where(x => x.ApplicationUserId == userId).OrderByDescending(x => x.DateStarted.Value).ToList();
            return View(list);
        }

        public ActionResult Create()
        {

            var userId = User.Identity.GetUserId();
            //ViewBag.userid = userId;
            //var user = db.Users.Where(x => x.Id == userId).FirstOrDefault();
            //ViewBag.Disc = user.MembershipType.DiscountRate;

            var membershipTypeId = db.Users.Where(u => u.Id == userId).FirstOrDefault().MembershipTypeId;
            var disc = db.MembershipTypes.Where(m => m.Id == membershipTypeId).FirstOrDefault().DiscountRate;
            var list = db.Services.ToList();

            var order = new CreateOrdersViewModel()
            {
                ApplicationUserId = userId,
                DiscountRate = disc,
                Services = list,
            };
            //ViewBag.Services = list;






            return View(order);
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateOrdersViewModel orders)
        {

            if (ModelState.IsValid)
            {
                var userId = HttpContext.User.Identity.GetUserId();
                var service = db.Services.Where(s => s.Id == orders.ServiceId).FirstOrDefault();
                var order = new Order();
                order.Service = service;

                var membershipTypeId = db.Users.Find(userId).MembershipTypeId;                      /*Where(u => u.Id == orders.ApplicationUserId).FirstOrDefault().MembershipTypeId;*/
                var disc = db.MembershipTypes.Find(membershipTypeId).DiscountRate;                            /* Where(m => m.Id == membershipTypeId).FirstOrDefault().DiscountRate;*/
                order.ApplicationUserId = userId;
                order.TotalPrice = Math.Round(service.Price - (disc * service.Price), 2);
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.CustomerId = new SelectList(db.Users, "Id", "Name", order.ApplicationUserId);
            //ViewBag.ServiceId = new SelectList(db.Services, "Id", "Name", order.ServiceId);
            
            return View();

        }
    }
}