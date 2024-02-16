using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

public class CourseController: Controller {

    public IActionResult Index(){

        var kurs=new Course();
        kurs.Id=1;
        kurs.Title="C# Basics";
        return View(kurs);
    }

    // course/list
    public IActionResult List(){

        return View("CourseList");
    }



}