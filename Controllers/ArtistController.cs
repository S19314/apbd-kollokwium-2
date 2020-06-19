using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Kollokwium_2.Exceptions;
using Kollokwium_2.Models;
using Kollokwium_2.Services;
using Kollokwium_2.DTOs.Request;

namespace Kollokwium_2.Controllers
{
    [Route("api")]
    [ApiController] 
    public class ArtistController : ControllerBase
    {

        private readonly IDbService dbService;
        public ArtistController(IDbService dbService)
        {
            this.dbService = dbService;
        }






        [HttpGet("artists/{id}")]
        public IActionResult GetArtists(int id) 
        {

            try
            {
                var artists = dbService.GetArtists(id);    
                return Ok(artists);
            }
            catch (ArtistNotFoundException anexc) 
            {
                return NotFound(anexc.Message);
            }                
            
        }

        [HttpPut("artists/{idArtist}/events/{idEvent}")]
        public IActionResult SetPerfomanceDate(int idArtist, int idEvent, AktualizationDateRequest request) 
        {
            try
            {
                dbService.SetPerfomanceDate(idArtist, idEvent, request);
                return Ok("Data była zmienniona!");
            }
            catch (IncorrectDateException incexcp)
            {
                return BadRequest(incexcp.Message);
            }
            catch (ArtistEventNotFoundException artExc) 
            {
                return NotFound(artExc.Message);
            }



        }

    }
}
