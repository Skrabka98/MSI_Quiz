using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDiet.Models.Data
{
    public class Question
    {
        [Key]
        public int IDQestion { get; set; }
        public string Questions { get; set; }
        public virtual ICollection<Reply> Replies { get; set; }

    }
}
