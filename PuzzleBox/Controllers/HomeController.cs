using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PuzzleBox.Models;

namespace PuzzleBox.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationSettings m_app_settings;

        public HomeController(IOptions<ApplicationSettings> app_settings) {
            m_app_settings = app_settings.Value;
        }

        public IActionResult Index()
        {
            ViewData["Applications"] = m_app_settings.Applications.Select(app => new SafeApplication(app));

            return View();
        }
    }
}