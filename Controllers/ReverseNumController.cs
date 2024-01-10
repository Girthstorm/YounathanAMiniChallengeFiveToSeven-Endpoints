using Microsoft.AspNetCore.Mvc;
using YounathanAMiniChallengeFiveToSeven_Endpoints.services.ReverseNum;

namespace YounathanAMiniChallengeFiveToSeven_Endpoints.Controllers;

    [ApiController]
    [Route("[controller]")]

    public class ReverseNumController : ControllerBase
    {
        private readonly IReverseNumService _ReverseNumService;
        public ReverseNumController(IReverseNumService ReverseIt)
        {
            _ReverseNumService = ReverseIt;
        }

        [HttpGet]
        [Route("ReverseNumber/{num1}")]
        public string RevNum(string num1) 
        {
            return _ReverseNumService.RevNum(num1);
        }
    }
