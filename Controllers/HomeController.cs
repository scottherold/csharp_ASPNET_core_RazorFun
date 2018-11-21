using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace razorFun
{
    public class HomeController : Controller
    {
        // Renders the Index file.
        
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }
}
}