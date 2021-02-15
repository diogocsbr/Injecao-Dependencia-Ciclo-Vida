using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using WebApplication7.Interface;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        IServicosTransient Transient;
        IServicosScoped Scoped;
        IServicosSingleton Singleton;

        IServicosTransient Transient2;
        IServicosScoped Scoped2;
        IServicosSingleton Singleton2;

        public HomeController(ILogger<HomeController> logger,
        IServicosTransient _Transient,
        IServicosScoped _Scoped,
        IServicosSingleton _Singleton,

        IServicosTransient _Transient2,
        IServicosScoped _Scoped2,
        IServicosSingleton _Singleton2
            )
        {
            _logger = logger;

            Transient = _Transient;
            Scoped = _Scoped;
            Singleton = _Singleton;

            Transient2 = _Transient2;
            Scoped2 = _Scoped2;
            Singleton2 = _Singleton2;
        }

        public IActionResult Index()
        {
            ViewBag.Scoped_i = Scoped.SomarUm();
            ViewBag.Transient_i = Transient.SomarUm();
            ViewBag.Singleton_i = Singleton.SomarUm();

            ViewBag.Scoped_id = Scoped.Identificador();
            ViewBag.Transient_id = Transient.Identificador();
            ViewBag.Singleton_id = Singleton.Identificador();

            ViewBag.Scoped_i2 = Scoped2.SomarUm();
            ViewBag.Transient_i2 = Transient2.SomarUm();
            ViewBag.Singleton_i2 = Singleton2.SomarUm();

            ViewBag.Scoped_id2 = Scoped2.Identificador();
            ViewBag.Transient_id2 = Transient2.Identificador();
            ViewBag.Singleton_id2 = Singleton2.Identificador();

            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Scoped_i = Scoped.SomarUm();
            ViewBag.Transient_i = Transient.SomarUm();
            ViewBag.Singleton_i = Singleton.SomarUm();

            ViewBag.Scoped_id = Scoped.Identificador();
            ViewBag.Transient_id = Transient.Identificador();
            ViewBag.Singleton_id = Singleton.Identificador();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
