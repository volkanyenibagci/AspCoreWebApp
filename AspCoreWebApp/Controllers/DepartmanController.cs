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
        //private readonly IDepartmanGenericRepository _departmanGenericRepository;

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
            //var degerler = _context.Departmans.Where(x=>x.Durum==true).ToList();
            ///*var degerler = _departmanService.GetAllDepartmans().ToList();*/
            //var degerler2 = _departmanRepository.GetAllDepartmans();
            var degerler = _context.Departmans.Where(x=>x.Status==true).ToList();
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
            d.Status = true;
            d.CreateDateTime = System.DateTime.Now;
            
            _context.Departmans.Add(d);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        
        public ActionResult DepartmanSil(int id)
        {
            var dep = _context.Departmans.Find(id);
            dep.Status = false;
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
            var dept = _context.Departmans.Find(p.Id);
            dept.DepartmanAd = p.DepartmanAd;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DepartmanDetay(int id)
        {
            var degerler = _context.Personels.Where(x => x.Departmanid == id).ToList();

            var dpt = _context.Departmans.Where(x => x.Id == id).Select(y => y.DepartmanAd).FirstOrDefault();
            ViewBag.DepartmanAdi = dpt;

            return View(degerler);
        }
    }
}