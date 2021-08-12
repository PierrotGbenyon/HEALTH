using HEALTH.Data;
using HEALTH.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HEALTH.Controllers
{
    public class ProfilController : Controller
    {
        private readonly HEALTHDbContext _context;
        public IActionResult Index()
        {
            return View();
        }
    }
}
