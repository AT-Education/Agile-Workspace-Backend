using agileworkspace.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agileworkspace.Repository
{
    public class SeatRepository
    {
        private readonly AgileWorkSpaceContext _dbContext;

        public SeatRepository()
        {
            _dbContext = new AgileWorkSpaceContext();
        }

        public async Task<int>   Insert(Seat seat)
        {
           await _dbContext.Seats.AddAsync(seat).ConfigureAwait(false);
          return  await _dbContext.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
