using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WebApplicationJS.ComAPI;
using WebApplicationJS.Models;
using WebApplicationJS.ViewModels;
using WebApplicationJS.Views.Home;

namespace WebApplicationJS.Controllers
{
    public class HomeController : Controller
    {
        #region VARIABLE
        private readonly ComAPIRest service;
        #endregion

        #region Constructeur
        public HomeController()
        {
            service = new ComAPIRest("http://localhost:5000/api/");
        }
        #endregion

        #region Page Index
        public IActionResult Index()
        {
            return base.View(new SiteViewModel(service.VolGetALL(), service.HotelGetAll()));
        }
        #endregion

        #region Page erreur
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion
    }
}
