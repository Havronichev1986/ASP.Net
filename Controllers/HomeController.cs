using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAnimalGenerator _animalGenerator;
        public HomeController(ILogger<HomeController> logger, IAnimalGenerator animalGenerator)
        {
            _logger = logger;
            _animalGenerator = animalGenerator;
        }

        public IActionResult Index()
        {
            var newAnimal = _animalGenerator.createNewAnimal();
            return View(newAnimal);
        }

        public IActionResult Privacy()
        {
            var newAnimal = _animalGenerator.addNewAnimal();
            return View(newAnimal);
        }
        public IActionResult OpenFile()
        {
            var newAnimal = _animalGenerator.openNewAnimal();
            return View(newAnimal);
        }
    }
}
