using System;
using System.Collections.Generic;

namespace Kollokwium_2.Models
{
    public partial class Prescriptions
    {
        public int IdPrescription { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
    }
}
