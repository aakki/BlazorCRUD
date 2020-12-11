using BlazorCRUD.Shared.Appointment;
using BlazorCRUD.Shared.Disease;
using BlazorCRUD.Shared.Patient;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD.Server.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public virtual DbSet<Appointment> tblAppointments { get; set; }
        public virtual DbSet<Disease> tblDiseases { get; set; }
        public virtual DbSet<Patient> tblPatients { get; set; }

    }
}
