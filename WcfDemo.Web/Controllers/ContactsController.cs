using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WcfDemo.Web.ContactService;
using WcfDemo.Web.Models;

namespace WcfDemo.Web.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        public ActionResult Index()
        {
            using (var c = new ServiceClient())
            {
                var model = c.All();
                return View(model);
            }
        }

        // GET: Contacts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contacts/Create
        [HttpPost]
        public ActionResult Create(ContactViewModel model)
        {
            if (!ModelState.IsValid)
                return View("Error");

            try
            {
                using (var c = new ServiceClient())
                {
                    var contact = Mapper.Map<Contact>(model);
                    c.Save(contact);

                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Contacts/Edit/5
        public ActionResult Edit(Guid id)
        {
            using (var c = new ServiceClient())
            {
                var contact = c.Select(id);
                if (contact == null)
                    return View("Error");

                var model = Mapper.Map<ContactViewModel>(contact);
                return View(model);
            }
        }

        // POST: Contacts/Edit/5
        [HttpPost]
        public ActionResult Edit(ContactViewModel model)
        {
            if (!ModelState.IsValid)
                return View("Error");

            try
            {
                using (var c = new ServiceClient())
                {
                    var contact = Mapper.Map<Contact>(model);
                    c.Save(contact);

                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Contacts/Delete/5
        public ActionResult Delete(Guid id)
        {
            using (var c = new ServiceClient())
            {
                var contact = c.Select(id);
                if (contact == null)
                    return View("Error");

                var model = Mapper.Map<ContactViewModel>(contact);
                return View(model);
            }
        }

        // POST: Contacts/Delete/5
        [HttpPost]
        public ActionResult Delete(ContactViewModel model)
        {
            if (!ModelState.IsValid)
                return View("Error");

            try
            {
                using (var c = new ServiceClient())
                {
                    var contact = Mapper.Map<Contact>(model);
                    c.Remove(contact);

                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View("Error");
            }
        }
    }
}
