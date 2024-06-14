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
                Name = "John",
                DateOfBirth = new DateTime(2002,11,22)
            };
            return View(data);
        }
    }
}
