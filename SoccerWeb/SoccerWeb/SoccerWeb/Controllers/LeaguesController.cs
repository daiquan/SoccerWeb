﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoccerWeb.Controllers
{
    public class LeaguesController : Controller
    {
        // GET: Leagues
        public ActionResult Index()
        {
            return View();
        }
    }
}