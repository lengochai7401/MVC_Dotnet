﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_DotNet.Models;

namespace MVC_DotNet.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    
}
