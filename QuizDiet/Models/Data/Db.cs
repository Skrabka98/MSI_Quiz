using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDiet.Models.Data
{
    public class Db : DbContext
    {
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Reply> Replies { get; set; }
        public virtual DbSet<Result> Results { get; set; }

        public Db(DbContextOptions<Db> options) : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Answer>().HasData(
                new Answer { IDAnswer = 1, Answers = "A1", Points = 1 },
                new Answer { IDAnswer = 2, Answers = "B", Points = 2 },
                new Answer { IDAnswer = 3, Answers = "C", Points = 3 },
                new Answer { IDAnswer = 4, Answers = "D", Points = 4 },
                new Answer { IDAnswer = 5, Answers = "A", Points = 1 },
                new Answer { IDAnswer = 6, Answers = "B", Points = 2 },
                new Answer { IDAnswer = 7, Answers = "C", Points = 3 },
                new Answer { IDAnswer = 8, Answers = "D", Points = 4 },
                new Answer { IDAnswer = 9, Answers = "A", Points = 1 },
                new Answer { IDAnswer = 10, Answers = "B", Points = 2 },
                new Answer { IDAnswer = 11, Answers = "C", Points = 3 },
                new Answer { IDAnswer = 12, Answers = "D", Points = 4 },
                new Answer { IDAnswer = 13, Answers = "A", Points = 1 },
                new Answer { IDAnswer = 14, Answers = "B", Points = 2 },
                new Answer { IDAnswer = 15, Answers = "C", Points = 3 },
                new Answer { IDAnswer = 16, Answers = "D", Points = 4 },
                new Answer { IDAnswer = 17, Answers = "A", Points = 1 },
                new Answer { IDAnswer = 18, Answers = "B", Points = 2 },
                new Answer { IDAnswer = 19, Answers = "C", Points = 3 },
                new Answer { IDAnswer = 20, Answers = "D", Points = 4 }
                );
            builder.Entity<Question>().HasData(
                new Question { IDQestion = 1, Questions = "Pytanie 1" },
                new Question { IDQestion = 2, Questions = "Pytanie 2" },
                new Question { IDQestion = 3, Questions = "Pytanie 3" },
                new Question { IDQestion = 4, Questions = "Pytanie 4" },
                new Question { IDQestion = 5, Questions = "Pytanie 5" }

                );
            builder.Entity<Reply>().HasData(
                new Reply { IDReply = 1, IDQuestion = 1, IDAnswer= 1 },
                new Reply { IDReply = 2, IDQuestion = 1, IDAnswer = 2 },
                new Reply { IDReply = 3, IDQuestion = 1, IDAnswer = 3 },
                new Reply { IDReply = 4, IDQuestion = 1, IDAnswer = 4 },
                new Reply { IDReply = 5, IDQuestion = 2, IDAnswer = 5 },
                new Reply { IDReply = 6, IDQuestion = 2, IDAnswer = 6 },
                new Reply { IDReply = 7, IDQuestion = 2, IDAnswer = 7 },
                new Reply { IDReply = 8, IDQuestion = 2, IDAnswer = 8 },
                new Reply { IDReply = 9, IDQuestion = 3, IDAnswer = 9 },
                new Reply { IDReply = 10, IDQuestion = 3, IDAnswer = 10 },
                new Reply { IDReply = 11, IDQuestion = 3, IDAnswer = 11 },
                new Reply { IDReply = 12, IDQuestion = 3, IDAnswer = 12 },
                new Reply { IDReply = 13, IDQuestion = 4, IDAnswer = 13 },
                new Reply { IDReply = 14, IDQuestion = 4, IDAnswer = 14 },
                new Reply { IDReply = 15, IDQuestion = 4, IDAnswer = 15 },
                new Reply { IDReply = 16, IDQuestion = 4, IDAnswer = 16 },
                new Reply { IDReply = 17, IDQuestion = 5, IDAnswer = 17 },
                new Reply { IDReply = 18, IDQuestion = 5, IDAnswer = 18 },
                new Reply { IDReply = 19, IDQuestion = 5, IDAnswer = 19 },
                new Reply { IDReply = 20, IDQuestion = 5, IDAnswer = 20 }
                );
            builder.Entity<Result>().HasData(
                new Result { IDResult = 1, ScoreMin = 5, ScoreMax = 10, Diet = "Jakaś pierwsza dieta"},
                new Result { IDResult = 2, ScoreMin = 11, ScoreMax = 20, Diet = "Jakaś druga dieta" }
                );
        }
    }
    }
