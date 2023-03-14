
using System.Collections.Generic;

namespace Doctors.Models
{
  public class Specialty
  {
    public int SpecialtyId { get; set; }
    public string Name { get; set; }
    public List<Doctor> Doctors { get; set; }
  }
}