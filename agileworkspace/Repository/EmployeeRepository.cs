using agileworkspace.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace agileworkspace.Repository
{
    public class EmployeeRepository
    {
        private readonly AgileWorkSpaceContext _dbContext;

        public EmployeeRepository()
        {
            _dbContext = new AgileWorkSpaceContext();
        }

        public List<Employee> GetAll()
        {
            
            return _dbContext.Employees.Include(a=>a.Seat).ToList();
        }

        public async Task<int>  Insert(Employee emp)
        {
           await _dbContext.Employees.AddAsync(emp).ConfigureAwait(false);
          return  await _dbContext.SaveChangesAsync().ConfigureAwait(false);
        }


    }
}
