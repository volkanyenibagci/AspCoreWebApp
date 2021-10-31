using System.Linq;
using AspCoreWebApp.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspCoreWebApp.Controllers
{
    
    public class DepartmanController : Controller
    {
        // GET
        private readonly AspCoreContext _context;
        
        public DepartmanController(AspCoreContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var degerler = _context.Departmans.Where(x=>x.Durum==true).ToList();
            return View(degerler);
        }
        
        [HttpGet]
        public ActionResult DepartmanEkle()
        {

            return View();

        }

        [HttpPost]
        public ActionResult DepartmanEkle(Departman d)
        {

            //TODO Durum True yapılacak listeye gelmesi için
            d.Durum = true;
            
            _context.Departmans.Add(d);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        
        public ActionResult DepartmanSil(int id)
        {
            var dep = _context.Departmans.Find(id);
            dep.Durum = false;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult DepartmanGetir(int id)
        {
            var dpt = _context.Departmans.Find(id);

            return View("DepartmanGetir",dpt);
        }

        public ActionResult DepartmanGuncelle(Departman p)
        {
            var dept = _context.Departmans.Find(p.DepartmanID);
            dept.DepartmanAd = p.DepartmanAd;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DepartmanDetay(int id)
        {
            var degerler = _context.Personels.Where(x => x.Departmanid == id).ToList();

            var dpt = _context.Departmans.Where(x => x.DepartmanID == id).Select(y => y.DepartmanAd).FirstOrDefault();
            ViewBag.DepartmanAdi = dpt;

            return View(degerler);
        }
    }
}