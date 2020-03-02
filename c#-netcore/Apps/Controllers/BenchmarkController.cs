using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Data.Contracts;
using AspNetCore.Data.Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Controller
{
    [Route("api/benchmark")]
    [ApiController]
    public class BenchmarkController : ControllerBase
    {
        private IRepositoryWrapper _repository;

        public BenchmarkController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet, Route("hello")]
        public IEnumerable<string> HelloWorld()
        {
            return new string[] { "hello", "world" };
        }

		[HttpGet]
        [Route("compute")]
        public IEnumerable<string> ComputeFibonacci()
        {
            int x = 0, y = 1, z, max;
            Random r = new Random();
            max = 10000 + r.Next(500);

            for (int i = 0; i <= max; i++) {
                z = x + y;
                x = y;
                y = z;
            }

            return new string[] { "status", "done" };
        }

		[HttpGet]
        [Route("simple-listing")]
        public  async Task<ActionResult<ApiResponse>> Students()
        {
            return new ApiResponse {
				IsError = false,
				StatusCode = 200,
				Results = await _repository.Student.GetAllAsync()
			};
        }

		[HttpGet]
        [Route("complex-listing")]
        public  async Task<ActionResult<ApiResponse>> StudentWithEnrollments(int id)
        {
			return new ApiResponse {
				IsError = false,
				StatusCode = 200,
				Results = await _repository.Enrollment.GetStudentsByClassname("Math")
			};
        }
    }
}
