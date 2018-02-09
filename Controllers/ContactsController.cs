using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class ContactsController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            List<Contact> allcontacts = Contact.GetAll();
            return View(allcontacts);
        }

        [HttpGet("/contacts/new")]
        public ActionResult NewContactForm()
        {
            return View();
        }

        [HttpPost("/contacts")]
        public ActionResult Create()
        {
            Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-email"], Request.Form["new-phone"]);
            List<Contact> allcontacts = Contact.GetAll();
            return View("Index", allcontacts);
        }

        [HttpPost("/contacts/delete")]
        public ActionResult DeleteAll()
        {
            Contact.ClearAll();
            return View();
        }

    }
}
