using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.ViewModels
{
    public class CourseViewMoldel
    {
        public IEnumerable<Course> Courses { get; set; }
        public Course Course { get; set; }
    }
}
