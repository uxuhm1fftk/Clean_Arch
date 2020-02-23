using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArch.Mvc.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courceService;
        public CourseController(ICourseService courceService)
        {
            _courceService = courceService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            //CourseViewMoldel model1 = _courceService.GetCourse();
            CourseViewMoldel model =_courceService.GetCourses();
            return View(model);
        }

        public IActionResult ShowCourse(int id)
        {
            Course course = _courceService.GetCourseById(id);
            if (course == null)
                return NotFound();
            return View(course);
        }

    }
}
