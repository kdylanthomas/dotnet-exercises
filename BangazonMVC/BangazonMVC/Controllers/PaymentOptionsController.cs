using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BangazonMVC.Models;

namespace BangazonMVC.Controllers
{
    public class PaymentOptionsController : Controller
    {
        private DataStoreContext db = new DataStoreContext();

        // GET: PaymentOptions
        public ActionResult Index()
        {
            return View(db.PaymentOption.ToList());
        }

        // GET: PaymentOptions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentOption paymentOption = db.PaymentOption.Find(id);
            if (paymentOption == null)
            {
                return HttpNotFound();
            }
            return View(paymentOption);
        }

        // GET: PaymentOptions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaymentOptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPaymentOption,IdCustomer,Name,AccountNumber")] PaymentOption paymentOption)
        {
            if (ModelState.IsValid)
            {
                db.PaymentOption.Add(paymentOption);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paymentOption);
        }

        // GET: PaymentOptions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentOption paymentOption = db.PaymentOption.Find(id);
            if (paymentOption == null)
            {
                return HttpNotFound();
            }
            return View(paymentOption);
        }

        // POST: PaymentOptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPaymentOption,IdCustomer,Name,AccountNumber")] PaymentOption paymentOption)
        {
            if (ModelState.IsValid)
            {
                db.Entry(paymentOption).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paymentOption);
        }

        // GET: PaymentOptions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentOption paymentOption = db.PaymentOption.Find(id);
            if (paymentOption == null)
            {
                return HttpNotFound();
            }
            return View(paymentOption);
        }

        // POST: PaymentOptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PaymentOption paymentOption = db.PaymentOption.Find(id);
            db.PaymentOption.Remove(paymentOption);
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
