using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Shared.Appointment
{
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string Problem { get; set; }
        public DateTime CreatedDate { get; set; } = new DateTime();
        public DateTime AppointmentDate { get; set; } = new DateTime();
        public string Amount { get; set; }
    }
}
