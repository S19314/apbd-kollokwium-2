using System;
using System.Collections.Generic;

namespace Kollokwium_2.Models
{
    public partial class WyrobCukierniczy
    {
        public WyrobCukierniczy()
        {
            ZamowienieWyrobCukierniczy = new HashSet<ZamowienieWyrobCukierniczy>();
        }

        public int IdWyrobCukierniczego { get; set; }
        public string Nazwa { get; set; }
        public double CenaZaSzt { get; set; }
        public string Typ { get; set; }

        public virtual ICollection<ZamowienieWyrobCukierniczy> ZamowienieWyrobCukierniczy { get; set; }
    }
}
