using LogicLayer.APILogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace MainAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class MainController : Controller
    {
        private readonly IAPILogicHandlers _handler;
        public MainController(IAPILogicHandlers handler)
        {
            _handler = handler;
        }

        [HttpGet]
        [Route("GetAllGames")]
        public async Task<List<BoardGameModel>> GetAllGames()
        {
            var data = await _handler.GetAllGamesToAPI();
            return data;
        }

        [HttpPost]
        [Route("CreateNewGame")]
        public async Task<IActionResult> AddNewGame([FromBody] BoardGameModel boardGame)
        {
            if (ModelState.IsValid)
            {
                await _handler.SaveGameFromAPI(boardGame);
                return Ok(boardGame);
            }
            else
            {
                return BadRequest("Improper Request");
            }
        }
    }
}
