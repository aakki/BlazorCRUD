﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCRUD.Shared.Appointment
{
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string PatientName { get; set; }
        [Required]
        public string Problem { get; set; }
        public DateTime CreatedDate { get; set; } = new DateTime();
        public DateTime AppointmentDate { get; set; } = new DateTime();
        [Required]
        public double Amount { get; set; }
    }
}
