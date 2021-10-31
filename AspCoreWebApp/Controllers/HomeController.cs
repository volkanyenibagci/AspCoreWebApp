using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspCoreWebApp.Models;
using AspCoreWebApp.Entities;
using AspCoreWebApp.Entities.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using DevExtreme;
namespace AspCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AspCoreContext _context;
       
        public HomeController(ILogger<HomeController> logger,AspCoreContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var DepartmanSayisi=_context.Departmans.Count();
            ViewBag.DepartmanSayisi = DepartmanSayisi;
            return View();
        }
        
        public ActionResult Kategori()
        {
            
            var degerler = _context.Kategoris.ToList();
            //IQueryable<Kategori> query = db.Kategoris;

            return View(degerler);
        }

        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KategoriEkle(Kategori k)
        {
            _context.Kategoris.Add(k);
            _context.SaveChanges();
            return RedirectToAction("Kategori");
        }

        public ActionResult KategoriSil(int id)
        {
            var ktg = _context.Kategoris.Find(id);
            _context.Kategoris.Remove(ktg);
            _context.SaveChanges();
            return RedirectToAction("Kategori");
        }

        public ActionResult KategoriGetir(int id)
        {
            var kategori = _context.Kategoris.Find(id);
            return View("KategoriGetir",kategori);

        }

        public ActionResult KategoriGuncelle(Kategori k)
        {
            var ktgr = _context.Kategoris.Find(k.KategoriID);
            ktgr.KategoriAd = k.KategoriAd;
            _context.SaveChanges();
            return RedirectToAction("Kategori");

        }

        public IActionResult Privacy()
        {
            return View();
        }
       
        
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}