using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDiet.Models.Data
{
    public class Result
    {
        [Key]
        public int IDResult { get; set; }        
        public int ScoreMin { get; set; }
        public int ScoreMax { get; set; }
        public string Diet { get; set; }

        
    }
}
