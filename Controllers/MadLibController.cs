using Microsoft.AspNetCore.Mvc;
using YounathanAMiniChallengeFiveToSeven_Endpoints.services.MadLib;

namespace YounathanAMiniChallengeFiveToSeven_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
    public class MadLibController : ControllerBase
    {
        private readonly IMadLibServices _MadLibService;
        public MadLibController(IMadLibServices Libbing)
        {
            _MadLibService = Libbing;
        }

        [HttpGet]
        [Route("Libbing/{name}/{villian}/{devilFruit}/{crewMate}/{islandName}/{trait}/{islandName2}/{shipName}/{bountyAmount}/{catchphrase}")] //Have Fun
        public string MadLibbing(string name, string villian, string devilFruit, string crewMate, string islandName, string trait, string islandName2, string shipName, string bountyAmount, string catchphrase)
        {
            return _MadLibService.MadLibbing(name, villian, devilFruit, crewMate, islandName, trait, islandName2, shipName, bountyAmount, catchphrase);
        }
        
    }
