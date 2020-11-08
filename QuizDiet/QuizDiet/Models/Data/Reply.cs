using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDiet.Models.Data
{
    public class Reply
    {
        [Key]
        public int IDReply { get; set; }

        public int IDAnswer { get; set; }
        public int IDQuestion { get; set; }
        [ForeignKey("IDAnswer")]
        public virtual Answer Answer { get; set; }
        [ForeignKey("IDQuestion")]
        public virtual Question Question { get; set; }



    }
}
