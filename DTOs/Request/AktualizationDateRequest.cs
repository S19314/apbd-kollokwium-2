using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kollokwium_2.DTOs.Request
{
    public class AktualizationDateRequest
    {
        public int IdArtist { get; set; }
        public int IdEvent{ get; set; }
        public DateTime PerfomanceDate { get; set; }
    }
}
