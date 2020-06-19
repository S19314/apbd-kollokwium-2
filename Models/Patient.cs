﻿using System;
using System.Collections.Generic;

namespace Kollokwium_2.Models
{
    public partial class Patient
    {
        public Patient()
        {
            Prescription = new HashSet<Prescription>();
        }

        public int IdPatient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual ICollection<Prescription> Prescription { get; set; }
    }
}
