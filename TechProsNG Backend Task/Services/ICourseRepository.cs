using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TechProsNG_Backend_Task.Models;

namespace TechProsNG_Backend_Task.Services
{
	
	public interface ICourseRepository
	{
		// Retrieve all courses
		Task<IEnumerable<Course>> GetCoursesAsync();

		// Retrieve a course by its unique identifier
		Task<IActionResult> GetCourseById(string Id);

		// Enroll a user in a course and return true if successful
		Task<IActionResult> EnrollUserInCourseAsync(string userId, string courseId);

	}

}
