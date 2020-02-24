using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace agileworkspace.Model
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long EmployeeId { get; set; }

        public string Name { get; set; }     
       
        [ForeignKey("SeatId")]
        public long? SeatId { get; set; }

        public Seat Seat { get; set; }
    }
}
