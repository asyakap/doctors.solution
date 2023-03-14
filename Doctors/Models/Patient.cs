using System.Collections.Generic;

namespace Doctors.Models
{
  public class Patient
  {
    public int PatientId { get; set; }
    public string Name { get; set; }
    public string Birthday { get; set; }
    public List<DoctorPatient> JoinEntities { get;}
  }
}