using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agileworkspace.Model;
using agileworkspace.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace agileworkspace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class SeatAllocationController : ControllerBase
    {
        [HttpGet]
         public List<Employee> GetSeatAllocation()
        {
            List<Employee> allocationList = new List<Employee>();
            EmployeeRepository employeeRepository = new EmployeeRepository();
            return employeeRepository.GetAll();
        }
        
    }
}