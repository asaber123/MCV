using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MVC.Models;


namespace MVC.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        //This session variable is going to be safe on teh server side. 
        string s = "Sessionsvariabel";
        HttpContext.Session.SetString("test", s);
        return View();

    }
    public IActionResult About()
    {
        string s2 = HttpContext.Session.GetString("test");
        ViewBag.text = s2;
        return View();
    }

    public IActionResult Test()
    {
        List<Course> courses = new List<Course>
            {
                new Course { Id = 1, CourseName = "Webbutveckling 1", Progression = "A", Syllabus = "Link" },
                new Course { Id = 2, CourseName = "Webbutveckling 2", Progression = "B", Syllabus = "Link" }
            };
        ViewData["Courses_in_list"] = courses;

        //List in ViewBag
        List<Course> courses2 = new List<Course>
            {
                new Course (1, "Webbutveckling 1", "A", "Link" ),
                new Course (2, "Webbutveckling 2", "B", "Link" )
            };
        ViewBag.Course = courses2;


        //List in ViewBag
        List<Course> courses3 = new List<Course>
            {
                new Course (1, "Webbutveckling 1", "A", "Link" ),
                new Course (2, "Webbutveckling 2", "B", "Link" )
            };

        ViewModel vm = new ViewModel
        {
            CourseList = Courses3
        };
        return View(vm);

        Item myitem = new Item();
        return View(myitem);
    }
}