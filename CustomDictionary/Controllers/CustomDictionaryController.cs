using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomDictionary.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomDictionaryController : ControllerBase
    {
        public CustomDictionaryController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        //For fetching all records
        // GET: api/<CustomDictionaryController> 
        //[HttpGet]
        //public IEnumerable<Word> Get()
        //{
        //    List<Word> WordsList =  new List<Word>();
        //    //for (int i = 0; i < 10; i++)
        //    //{
        //    //    Word word = new() {  Value =  "Test"+i, Id = i };
        //    //    WordsList.Add(word);
        //    //}


        //    SqliteDataAccess DataAccess = new SqliteDataAccess(Configuration);
        //    WordsList = DataAccess.GetWords();
        //    return WordsList;
        //}

        // for Fetching Records Based on Id
        // GET api/<CustomDictionaryController>/5
        //[HttpGet("{id}")]
        //public IEnumerable<Word> Get(int id)
        //{
        //    List<Word> WordsList = new List<Word>();
        //    //Word word = new() { Id = id, Value = "Test"+id };
        //    SqliteDataAccess DataAccess = new SqliteDataAccess(Configuration);
        //    WordsList = DataAccess.GetWordbyId(id);
        //    return WordsList;
        //}

        [HttpGet("{inputText}")]
        public IEnumerable<Word> Get(String inputText)
        {
            List<Word> WordsList = new List<Word>();
            //Word word = new() { Id = id, Value = "Test"+id };
            SqliteDataAccess DataAccess = new SqliteDataAccess(Configuration);
            WordsList = DataAccess.GetWordbytext(inputText);
            return WordsList;
        }

        
    }
}
