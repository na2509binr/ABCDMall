using ABCD_Mall_Online.Models;
using ABCDMallClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using X.PagedList;
using Microsoft.AspNetCore.Http;
using System.Globalization;

namespace ABCDMallClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cinema()
        {
            try
            {
                DateTime dt = DateTime.ParseExact("23/04/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Movies[] film = new Movies[]
                {
                    new  Movies {FilmId = 1, Title = "GreenBook", Time = 130, ReleaseDate = dt, Image = "~/images/interstellar.jpg", Genre = "Tình cảm"},
                    new  Movies {FilmId = 1, Title = "GreenBook", Time = 130, ReleaseDate = dt, Image = "~/images/interstellar.jpg", Genre = "Tình cảm"},
                    new  Movies {FilmId = 1, Title = "GreenBook", Time = 130, ReleaseDate = dt, Image = "~/images/interstellar.jpg", Genre = "Tình cảm"},
                    new  Movies {FilmId = 1, Title = "GreenBook", Time = 130, ReleaseDate = dt, Image = "~/images/interstellar.jpg", Genre = "Tình cảm"},
                };

                GetDataToViewModel getDataModel = new GetDataToViewModel();
                getDataModel.filmList = film.ToPagedList<Movies>(1, 5);
                return View(getDataModel);
            }
            catch (Exception)
            {
                return View();
            }
        }

        public IActionResult Booking()
        {
            try
            {

                return View();
            }
            catch (Exception)
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}