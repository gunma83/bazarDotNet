using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webapi.BazarDaElioDb;
using webapi.Models;
using Category = webapi.BazarDaElioDb.Categories;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScarpeController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<ScarpetteScogli>> GetShoesCategoriesList()
        {

            BazarDaElioContext bazarDaElioContext = new BazarDaElioContext();
            var scarpe = bazarDaElioContext.ScarpetteScogli;

            var tipologiaScarpette = scarpe.Select(item => item.Modello).Distinct().ToList();

            return Ok(tipologiaScarpette);
        }

        [HttpGet]
        [Route("[action]/{modello}")]
        public ActionResult<List<ScarpetteScogli>> GetShoesByModel(string modello)
        {

            BazarDaElioContext bazarDaElioContext = new BazarDaElioContext();
            var scarpe = bazarDaElioContext.ScarpetteScogli;

            var tipologiaScarpette = scarpe.Where(item => item.Modello == modello).ToList();

            return Ok(tipologiaScarpette);
        }
    }
}
