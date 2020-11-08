using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using QuizDiet.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizDiet.Controllers
{
    public class HomeController : Controller
    {
 
        private readonly Db _db;
        private static int point;
        private static int zzz;
        private Points points = new Points(point);
        private Id cos = new Id(zzz);
        

        public HomeController(Db db)
        {
            _db = db;
            
        }



        public IActionResult Index()
        {



  
            return View();
        }
        [HttpGet]
        public IActionResult Quiz(int id)
        {
            
            id = Convert.ToInt32(id);
            zzz = id;
            var vm = new ListViewModel();
            vm.Questions = _db.Questions.Where(x => x.IDQestion == id).ToList();
            vm.Answers = _db.Replies.Where(x => x.IDQuestion == id).Select(x => x.Answer).ToList();
            if (point != 0)
            {
                vm.punkciki = points.pointss;

            }
            else vm.punkciki = 0;
  
            return View(vm);
    }

        [HttpPost]
        public IActionResult Quiz(string answer)
        {
            zzz++;
            int id = zzz;
            int idd = Convert.ToInt32(answer);
            point += idd;
            return RedirectToAction("Quiz", "Home", new { id });
            
        }
    }
}
