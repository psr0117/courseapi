using courseapi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace courseapi.Controlers
{
    [ApiController]
    [Route("/api/Course")]
    public class CourseController : ControllerBase
    {

        private CourseService courseService;

        public CourseController(CourseService svc)
        {
            courseService = svc;
        }

        [HttpGet]
        public IActionResult GetCourses()
        {
            return Ok(courseService.GetCourses());
        }
    }
}
