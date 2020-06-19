using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kollokwium_2.Models;
using Kollokwium_2.DTOs.Request;

namespace Kollokwium_2.Services
{
    public interface IDbService
    {
        public Artist GetArtists(int id);
        public void SetPerfomanceDate(int idArtist, int idEvent, AktualizationDateRequest aktualizationDateRequest);

    }
}
