﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "João" },
                new Customer { Name = "Maria" }
            };

            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }
    }
}