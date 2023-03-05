using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using UpSkill_CSharpWebAPI.Helpers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UpSkill_CSharpWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ExampleSettingsController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ExampleSettings _settings;

        public ExampleSettingsController(IConfiguration configuration, IOptions<ExampleSettings> settings)
        {
            _configuration = configuration;
            _settings = settings.Value;
        }




        // GET: api/<ExampleSettingsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ExampleSettingsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            //return _configuration["ExampleSettings:SettingA"];
            return _settings.SettingA;
        }

        // POST api/<ExampleSettingsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExampleSettingsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExampleSettingsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
