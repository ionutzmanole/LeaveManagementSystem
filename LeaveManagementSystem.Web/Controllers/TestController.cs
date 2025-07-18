﻿using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel 
            { 
                Name = "Student of MVC Mastery",
                DateOfBirth = new DateTime(1978, 10, 27)
            };
            return View(data);
        }
    }
}
