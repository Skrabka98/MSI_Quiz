using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDiet.Models.Data
{
    public class Answer
    {

        [Key]
        public int IDAnswer { get; set; }
        [Required]
        public string Answers { get; set; }
        [Required]
        public int Points { get; set; }

        public virtual ICollection<Reply> Replies { get; set; }

    }
}
