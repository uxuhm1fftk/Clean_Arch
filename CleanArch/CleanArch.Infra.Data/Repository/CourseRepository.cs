using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctx;
        public CourseRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }

        public Course GetCource()
        {
            return _ctx.Courses.FirstOrDefault();
        }

        public IEnumerable<Course> GetCources()
        {
            return _ctx.Courses;
        }

        public Course GetCourseById(int courseId)
        {
            return _ctx.Courses.Find(courseId);
        }
    }
}
