﻿using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
            return View(model);
        }
        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    return Json(Ok());
        //}

        [HttpPost]
        public JsonResult Contact(Contact form)
        {
            return Json(Ok());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}