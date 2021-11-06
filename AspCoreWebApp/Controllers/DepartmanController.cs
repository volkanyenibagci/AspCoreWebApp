using System.Linq;
using AspCoreWebApp.Business.Abstract;
using AspCoreWebApp.DataAccess.Abstract;
using AspCoreWebApp.DataAccess.Concrete;
using AspCoreWebApp.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace AspCoreWebApp.Controllers
{
    
    public class DepartmanController : Controller
    {
        // GET
        private readonly AspCoreContext _context;

        private readonly IDepartmanRepository _departmanRepository;

        private readonly IDepartmanService _departmanService;

        public DepartmanController(AspCoreContext context,IDepartmanRepository departmanRepository,IDepartmanService departmanService)
        {
            _context = context;
            _departmanRepository = departmanRepository;
            _departmanService = departmanService;
        }
        
        
        public IActionResult Index()
        {
            var degerler = _context.Departmans.Where(x=>x.Durum==true).ToList();
            /*var degerler = _departmanService.GetAllDepartmans().ToList();*/
            var degerler2 = _departmanRepository.GetAllDepartmans();
            var degerler3 = _departmanService.GetAllDepartmans();
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