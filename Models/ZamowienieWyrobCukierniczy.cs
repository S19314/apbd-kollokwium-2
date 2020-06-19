using System;
using System.Collections.Generic;

namespace Kollokwium_2.Models
{
    public partial class ZamowienieWyrobCukierniczy
    {
        public int Ilosc { get; set; }
        public int IdZamowenia { get; set; }
        public int IdWyrobCukierniczego { get; set; }
        public string Uwagi { get; set; }

        public virtual WyrobCukierniczy IdWyrobCukierniczegoNavigation { get; set; }
        public virtual Zamowienie IdZamoweniaNavigation { get; set; }
    }
}
