using Microsoft.AspNetCore.Mvc;
using bulkybook.Models;

namespace bulkybook.Controllers;

public class PlayerController : Controller 
{
    private readonly IConfiguration Configuration;
    public PlayerController(IConfiguration configuration){
        Configuration = configuration;
    }

    public IActionResult Index()
    {
        return View();
    }
}