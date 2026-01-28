using Microsoft.AspNetCore.Mvc;

namespace CRUD_.Controllers
{
    public class HomeController : ControllerBase 
    {
        public async  Task<ActionResult> Index()
        {
            return Ok("Hola Mundo");
        }

       
    }
}