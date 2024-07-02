using Create_Web_Api_With_Asp_Net_Core_Controllers.Models;
using Create_Web_Api_With_Asp_Net_Core_Controllers.Services;
using Microsoft.AspNetCore.Mvc;

namespace Create_Web_Api_With_Asp_Net_Core_Controllers.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {

    }

    //GET all action
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() =>
        PizzaService.GetAll();

    //GET by Id action

    //POST action 

    //PUT action 

    //DELETE action
}

