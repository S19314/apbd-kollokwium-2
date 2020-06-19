using System;
using System.Collections.Generic;

namespace Kollokwium_2.Models
{
    public partial class Autorization
    {
        public int IdUsers { get; set; }
        public string Ip { get; set; }
        public string Date { get; set; }
        public string Request { get; set; }
    }
}
