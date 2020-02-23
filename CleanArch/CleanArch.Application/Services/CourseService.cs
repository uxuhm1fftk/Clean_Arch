﻿using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {

        private ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseViewMoldel GetCourse()
        {
            return new CourseViewMoldel()
            {
                Course = _courseRepository.GetCource()
            };
        }

        public Course GetCourseById(int courseId)
        {
            Course course = _courseRepository.GetCourseById(courseId);
            return course;
        }

        public CourseViewMoldel GetCourses()
        {
            return new CourseViewMoldel()
            {
                Courses = _courseRepository.GetCources()
            };
        }
    }
}
