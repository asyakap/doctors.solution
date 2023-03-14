using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Doctors.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        [Required(ErrorMessage = "The doctor's name can't be empty!")]
        public string Name { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "You must add your doctor's specialty. Have you created a specialty yet?")]
        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; }
        public List<DoctorPatient> JoinEntities { get;}
    }
}