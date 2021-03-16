using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiServer.Controllers
{

    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController: ControllerBase
    {

        List<Pokemon> pokemons = new List<Pokemon>() 
        {
            new Pokemon() {name = "Pikachu"},
            new Pokemon() {name = "Snorlax"}

        };
        
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(pokemons[0]);
        }
        
        
    }

}
