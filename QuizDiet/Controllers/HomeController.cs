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
            var numberOfQuestions = _db.Questions;
            if (numberOfQuestions.Count() > zzz)
            {
                zzz++;
                int id = zzz;
                int idInt = Convert.ToInt32(answer);
                point += idInt;
                return RedirectToAction("Quiz", "Home", new { id });
            }
            else
            {
                return RedirectToAction("Result");
            }
            
        }

        [HttpGet]
        public IActionResult Result()
        {
            var resultsVM = new ResultViewModel();
            resultsVM.Results = _db.Results.Where(x => x.ScoreMax >= point && x.ScoreMin <= point).ToList();
            zzz = 0;
            point = 0;
            return View(resultsVM);
        }
    }
}
