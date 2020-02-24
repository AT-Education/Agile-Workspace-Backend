using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agileworkspace.Model;
using agileworkspace.Repository;
using Microsoft.AspNetCore.Mvc;

namespace agileworkspace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        [Route("employee")]
        public string registerEmployee([FromBody] Employee value)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
          Task<int> count=  employeeRepository.Insert(value);
            if (count.Result>0)
            {
                return "Data saved sucessfully";
            }
            else
            {
                return "Data  not saved sucessfully";
            }
            
        }

        [HttpPost]
        [Route("seat")]
        public string registerSeat([FromBody] Seat value)
        {
            SeatRepository employeeRepository = new SeatRepository();
            Task<int> count= employeeRepository.Insert(value);
            if (count.Result > 0)
            {
                return "Data saved sucessfully";
            }
            else
            {
                return "Data  not saved sucessfully";
            }
            
        }
    }
}
