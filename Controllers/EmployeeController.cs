﻿using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PrimeiraAPI.Model;
using PrimeiraAPI.ViewModel;

namespace PrimeiraAPI.Controllers
{
    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeerRepository;

        public EmployeeController(IEmployeeRepository employeerRepository)
        {
            _employeerRepository = employeerRepository;
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {

                _employeerRepository.Add(employee);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, $"erro: {e.Message}");
            }
          
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var employess = _employeerRepository.GetAll();
            return Ok(employess);

        }
    }
}