using Microsoft.AspNetCore.Mvc;
using YounathanAMiniChallengeFiveToSeven_Endpoints.services.OddEven;

namespace YounathanAMiniChallengeFiveToSeven_Endpoints.Controllers;
    
    [ApiController]
    [Route("[controller]")]

    public class OddEvenController : ControllerBase
    {
        private readonly IOddEvenService _OddEvenService;
        public OddEvenController(IOddEvenService OddEvening)
        {
            _OddEvenService = OddEvening;
        }
        
        [HttpGet]
        [Route("OddEvening/{num1}")]
        public string OddEven(string num1)
        {
            return _OddEvenService.OddEven(num1);
        }




    }
