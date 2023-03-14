using Microsoft.EntityFrameworkCore;

namespace Doctors.Models
{
  public class DoctorsContext : DbContext
  {
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
     public DbSet<DoctorPatient> DoctorPatients { get; set; }
    public DoctorsContext(DbContextOptions options) : base(options) { }
  }
}
