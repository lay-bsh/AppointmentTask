using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentCRUD
{
    public class Appointment
    {
        
        public int RegId { get; set; }
        public string? Name { get; set; }

        [Key]
        [Required]
        public string? CNIC { get; set; }
        public string? ContactNo { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? CPassword { get; set; }





    }
}
