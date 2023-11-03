using Microsoft.AspNetCore.Mvc;

namespace CuentaRegresiva.Controllers;

public class PrincipalController : Controller{
    [HttpGet]
    [Route("")]
    public IActionResult Index(){
        return View("Index");

    }
}