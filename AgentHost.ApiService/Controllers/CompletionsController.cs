using AgentHost.ApiService.Services;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgentHost.ApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompletionsController : ControllerBase
    {
        private readonly ICompletionsService _completionsService;
        private readonly ILogger<CompletionsController> _logger;

        public CompletionsController(ICompletionsService completionsService, ILogger<CompletionsController> logger)
        {
            _completionsService = completionsService;
            _logger = logger;
        }

        // GET: api/<CompletionsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return ["value1", "value2"];
        }

        // GET api/<CompletionsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CompletionsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CompletionsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CompletionsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
