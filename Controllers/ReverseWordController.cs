using Microsoft.AspNetCore.Mvc;
using YounathanAMiniChallengeFiveToSeven_Endpoints.services.ReverseWord;

namespace YounathanAMiniChallengeFiveToSeven_Endpoints.Controllers;

    [ApiController]
    [Route("[controller]")]

    public class ReverseWordController : ControllerBase
    {
        private readonly IReverseWordService _ReverseWordService;
        public ReverseWordController(IReverseWordService Reversing)
        {
            _ReverseWordService = Reversing;
        }

        [HttpGet]
        [Route("Reversing/{word}")]
        public string ReverseIt(string word) 
        {
            return _ReverseWordService.ReverseIt(word);
        }
    }


