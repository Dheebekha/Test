using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomDictionary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordPredictionController : ControllerBase
    {
        // GET: api/<WordPewdictionController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    WordPrediction Wp = new WordPrediction();
        //     return Wp.getPredictions("ca","");
        //}

        //GET api/<WordPewdictionController>/5
        [HttpGet("{inputText}")]
        public IEnumerable<String> Get(String inputText, string language)
        {
            WordPrediction Wp = new WordPrediction();
            return Wp.getPredictions(inputText,language);
        }


    }
}
