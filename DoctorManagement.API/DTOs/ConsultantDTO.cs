using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorManagement.API.DTOs
{
    public class ConsultantDTO
    {
        public long Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorID { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string Prescription { get; set; }
        public string Problem { get; set; }
    }
}
