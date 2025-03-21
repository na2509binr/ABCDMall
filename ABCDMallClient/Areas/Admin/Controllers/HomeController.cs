using ABCDMallClient.Areas.Admin.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Security.Claims;

namespace ABCDMallClient.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController :  Controller
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

        public IActionResult Films()
        {
            var listModel = new ShowListFilmModel
            {
                listString = new List<string>() { "FilmId", "Title", "Actor", "Director", "Time", "ReleaseDate", "Image", "Genre" },
                listFilm = new List<FilmModel> { 
                    new FilmModel {FilmId = 1, Title = "Green Book", Actor="J.K", Director="J.K", Time= 184, ReleaseDate = DateTime.Now, Image = "asdasd.jpg", Genre="Male"},
                    new FilmModel {FilmId = 1, Title = "Green Book", Actor="J.K", Director="J.K", Time= 184, ReleaseDate = DateTime.Now, Image = "asdasd.jpg", Genre="Male"},
                    new FilmModel {FilmId = 1, Title = "Green Book", Actor="J.K", Director="J.K", Time= 184, ReleaseDate = DateTime.Now, Image = "asdasd.jpg", Genre="Male"},
                    new FilmModel {FilmId = 1, Title = "Green Book", Actor="J.K", Director="J.K", Time= 184, ReleaseDate = DateTime.Now, Image = "asdasd.jpg", Genre="Male"},
                    new FilmModel {FilmId = 1, Title = "Green Book", Actor="J.K", Director="J.K", Time= 184, ReleaseDate = DateTime.Now, Image = "asdasd.jpg", Genre="Male"},
                    new FilmModel {FilmId = 1, Title = "Green Book", Actor="J.K", Director="J.K", Time= 184, ReleaseDate = DateTime.Now, Image = "asdasd.jpg", Genre="Male"}
                }
            };
            return View(listModel);
        }

        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "sa123")
            {
                return RedirectToAction("Index");
            }
            else if (username == null && password == null)
            {

            }
            else if (username == null || password == null)
            {
                ViewBag.Error = "Vui lòng nhập tên tài khoản hoặc mật khẩu!";
            }
            else if (username != "admin" || password != "password")
            {
                ViewBag.Error = "Tên tài khoản hoặc mật khẩu không đúng!";
            }

            return View();
        }


        //public IActionResult Films()
        //{   
        //    return View();
        //}
    }
}
