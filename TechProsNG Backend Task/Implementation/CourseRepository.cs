using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechProsNG_Backend_Task.Context;
using TechProsNG_Backend_Task.Models;
using TechProsNG_Backend_Task.Services;

namespace TechProsNG_Backend_Task.Implementation
{
	public class CourseRepository : ICourseRepository
	{
		private readonly ApplicationDbContext _context;

		public CourseRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Course>> GetCoursesAsync()
		{
			return await _context.Courses.ToListAsync();
		}

		public async Task<IActionResult> GetCourseById(string Id)
		{
			var course = await _context.Courses.FirstOrDefaultAsync(c => c.CourseId == Id);

			if (course == null)
			{
				return new NotFoundResult(); 
			}

			return new OkObjectResult(course); 
		}

		public async Task<IActionResult> EnrollUserInCourseAsync(string userId, string courseId)
		{
			try
			{
				var user = await _context.Users.FindAsync(userId);
				var course = await _context.Courses.FindAsync(courseId);

				if (user == null || course == null)
				{
					return new NotFoundResult(); 
				}

				// Enroll the user in the course
				var enrollment = new Enrollment { UserId = userId, CourseId = courseId };
				_context.Enrollments.Add(enrollment);
				await _context.SaveChangesAsync();

				return new OkObjectResult(enrollment); 
			}
			catch (Exception ex)
			{
				// Handle exceptions or log errors
				return new BadRequestObjectResult("Error enrolling for the course"); 
			}
		}

	}
}
