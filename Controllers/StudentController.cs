using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_DotNet.Models;

namespace MVC_DotNet.Controllers;

public class StudentController : Controller
{
    private readonly DataContext _context;

    public StudentController(DataContext dataContext){
        _context = dataContext;
    }

    public IActionResult Index()
    {
        var students = _context.Students.ToList();
        //ViewData["ListStudent"] = students;
        return View(students);
    }

    

    
}
