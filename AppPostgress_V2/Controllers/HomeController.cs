using AppPostgress_V2.Data;
using AppPostgress_V2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AppPostgress_V2.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(DataContext context,ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
            //return View(await _context.arl.ToListAsync());
        }

        public JsonResult Search(string numerodocumento)
        {
            //var cargo = _context.cargos.ToList();
            var data = _context.
                contratoslaborales.
                Where(x => x.numerodocumento == Convert.ToInt32(numerodocumento)).ToList();

            return Json(data);
            //return View();
        }

        public JsonResult Save(string contrato, string per, string totallaborado,string horaEx, string desNomina)
        {
            try
            {
                Nomina cd = new Nomina();

                cd.idcontrato = Convert.ToInt32(contrato);
                cd.periodolaborado = Convert.ToInt32(per);
                cd.horaslaboradas = Convert.ToInt32(totallaborado);
                cd.horaextrafestiva = Convert.ToInt32(horaEx);
                cd.descuentos = Convert.ToInt32(desNomina);

                _context.Add(cd);
                _context.SaveChanges();

                return Json(true);
            }
            catch(Exception ex)
            {
                return Json(false);
            }

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
