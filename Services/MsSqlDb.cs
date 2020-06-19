using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kollokwium_2.Models;
using Kollokwium_2.Exceptions;
using Microsoft.EntityFrameworkCore;
using Kollokwium_2.DTOs.Request;

namespace Kollokwium_2.Services
{
    public class MsSqlDb : IDbService
    {
        private readonly s19314Context dbContext; // Мб проблема тут
        public MsSqlDb(s19314Context dbContext)
        {
            this.dbContext = dbContext;
        }


        public Artist GetArtists(int id) 
        {
            var artist = dbContext.Artist.Where(a => a.IdArtist == id).SingleOrDefault();
            if (artist == null) 
            {
                throw new ArtistNotFoundException("Nie ma Artista z takim " + id + " id.");                
            }

            // artist = artist.ArtistEvent.
            /*
            artist.ArtistEvent = dbContext.ArtistEvent.Where(a_e => a_e.IdArtist == artist.IdArtist)
                    .Include(e => e.IdEventNavigation) //.Select()
                .ToList();
            */
            artist.ArtistEvent = dbContext.ArtistEvent.Where(a_e => a_e.IdArtist == artist.IdArtist)
                .OrderBy(e => e.IdEventNavigation.StartDate)
                .Select(
                    e => new ArtistEvent
                    {
                        PerfomanceDate = e.PerfomanceDate,
                        IdEvent = e.IdEvent,
                        IdArtist = e.IdArtist,
                        IdEventNavigation = e.IdEventNavigation
                    }
                ).ToList();
            
            return artist;
        }
        public void SetPerfomanceDate(int idArtist, int idEvent, AktualizationDateRequest aktualizationDateRequest) 
        {
            // Найти Артист_Евен
            // Проверить границы времени
            var artistEventList =  dbContext.ArtistEvent.Where(e => (e.IdArtist == idArtist) && (e.IdEvent == idEvent))
                .Select(e => new ArtistEvent{
                    IdArtist = e.IdArtist,
                    IdEvent = e.IdEvent,
                    IdEventNavigation = e.IdEventNavigation,
                    IdArtistNavigation = e.IdArtistNavigation
                    }
                ).ToList();
            if (artistEventList == null || artistEventList.Count() == 0) throw new ArtistEventNotFoundException("Nie znalieziono ArtistEvent z idArtista " + idArtist + " i idEvent " + idEvent );
            
            foreach (var artistEvent in artistEventList) 
            {
                if (DateTime.Now > artistEvent.IdEventNavigation.StartDate
                    ||
                    aktualizationDateRequest.PerfomanceDate < artistEvent.IdEventNavigation.StartDate
                    ||
                    aktualizationDateRequest.PerfomanceDate  > artistEvent.IdEventNavigation.EndDate) throw new IncorrectDateException("Niepoprawna data ");
            }

            dbContext.ArtistEvent.RemoveRange(artistEventList);
            
            foreach (var artistEvent in artistEventList) 
            {
                artistEvent.PerfomanceDate = aktualizationDateRequest.PerfomanceDate;
            }
            dbContext.ArtistEvent.AddRange(artistEventList);
            dbContext.SaveChanges();
        }

    }
}
