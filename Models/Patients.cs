using System;
using System.Collections.Generic;

namespace Kollokwium_2.Models
{
    public partial class Patients
    {
        public int IdPatient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
