//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace TechProsNG_Backend_Task.Controllers
//{
//	[Route("api/[controller]")]
//	[ApiController]
//	public class CourseController : ControllerBase
//	{
//	}
//}


using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TechProsNG_Backend_Task.Services;

namespace TechProsNG_Backend_Task.Controllers
{
	[Route("api/courses")]
	[ApiController]
	public class CourseController : ControllerBase
	{
		private readonly ICourseRepository _courseRepository;

		public CourseController(ICourseRepository courseRepository)
		{
			_courseRepository = courseRepository;
		}

		[HttpGet]
		public async Task<IActionResult> GetCourses()
		{
			try
			{
				var courses = await _courseRepository.GetCoursesAsync();
				return Ok(courses);
			}
			catch (Exception ex)
			{
				// Handle exceptions or log errors
				return BadRequest("Error retrieving courses");
			}
		}

		[HttpGet("{courseId}")]
		public async Task<IActionResult> GetCourseById(string courseId)
		{
			try
			{
				var course = await _courseRepository.GetCourseById(courseId);
				if (course == null)
				{
					return NotFound("Course not found");
				}
				return Ok(course);
			}
			catch (Exception ex)
			{
				// Handle exceptions or log errors
				return BadRequest("Error retrieving course");
			}
		}

		[HttpPost("{userId}/{courseId}")]
		public async Task<IActionResult> EnrollUserInCourse(string userId, string courseId)
		{
			try
			{
				var result = await _courseRepository.EnrollUserInCourseAsync(userId, courseId);
				return result;
			}
			catch (Exception ex)
			{
				// Handle exceptions or log errors
				return BadRequest("Error enrolling for the course");
			}
		}
	}
}
