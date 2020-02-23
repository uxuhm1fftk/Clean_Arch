using CleanArch.Application.ViewModels;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewMoldel GetCourses();
        CourseViewMoldel GetCourse();
        Course GetCourseById(int courseId);
    }
}
