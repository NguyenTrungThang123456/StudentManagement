using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Application.Students.Commands;
using StudentManagement.Application.Students.Dto;
using StudentManagement.Application.Students.Queries;
using StudentManagement.Core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ApiController
    {
       [HttpPost]
       public async Task<ActionResult<int>> Create(CreateStudentCommand command)
        {
            return await Mediator.Send(command);
        }
        [HttpGet]
        public async Task<ActionResult<List<StudentDto>>> GetAll()
        {
            return await Mediator.Send(new GetAllStudentsQuery());
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<StudentDto>> Get(int id)
        {
            return await Mediator.Send(new GetStudentByIdQuery());
        }

        [HttpPut]
        public async Task<ActionResult<int>> Update(UpdateStudentCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpDelete]
        public async Task<ActionResult<int>> Delete(int id)
        {
            return await Mediator.Send(new DeleteStudentCommand { Id = id });
        }
    }
}
