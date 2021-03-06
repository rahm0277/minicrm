﻿using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.Feature.Persons.Models;
using Sitecore.Feature.Persons.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sitecore.Feature.Persons.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PersonListing(string email, string phone, int? page)
        { 
            int? pg = (page == null ? 1 : page);
           
            PersonService ps = new PersonService();
            PersonSearchListing pl = ps.GetPersons(email, phone, (int)pg, Sitecore.Context.Database.Name);
            
            return View(pl);

        }
    }
}