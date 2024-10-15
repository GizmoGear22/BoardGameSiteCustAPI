using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace MainAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class MainController : Controller
    {
        [HttpGet]
        [Route("GetAllGames")]
        public async Task<List<BoardGameModel>> GetAllGames()
        {
            throw new NotImplementedException();
        }
    }
}
