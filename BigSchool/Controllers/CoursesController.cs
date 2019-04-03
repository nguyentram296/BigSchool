using BigSchool.Models;
using BigSchool.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool.Controllers
{
    public class CoursesController : Controller
    {
        private ApplicationDbContext _dbContext;
       public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
            // GET: Courses
            [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}