﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppDay22Ex1.Data;
using WebAppDay22Ex1.Models;

namespace WebAppDay22Ex1.Controllers
{
    public class EmployeeMVCController : Controller
    {
        // GET: EmployeeMVC
        public ActionResult Index()
        {
            EmpDbContext db = new EmpDbContext();
            return View(db.Emps.ToList());
        }
    }
}