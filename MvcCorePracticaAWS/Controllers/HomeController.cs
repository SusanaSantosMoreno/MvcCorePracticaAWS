using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcCorePracticaAWS.Repositories;

namespace MvcCoreAzure.Controllers {
    public class HomeController : Controller {

        public CochesRepository repository;

        public HomeController(CochesRepository repo) { this.repository = repo; }

        public IActionResult Index() {
            return View(this.repository.GetCoches());
        }

        public IActionResult Details (int idCoche) {
            return View(this.repository.GetCoche(idCoche));
        }
    }
}
