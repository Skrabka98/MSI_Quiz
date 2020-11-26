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
                new Answer { IDAnswer = 1, Answers = "A Kobieta", Points = 1 },
                new Answer { IDAnswer = 2, Answers = "B Mężczyzna", Points = 2 },
                new Answer { IDAnswer = 3, Answers = "A < 16 = wygłodzenie", Points = 1 },
                new Answer { IDAnswer = 4, Answers = "B 16 – 16,99 = wychudzenie", Points = 2 },
                new Answer { IDAnswer = 5, Answers = "C 17 – 18,49 = niedowaga", Points = 3 },
                new Answer { IDAnswer = 6, Answers = "D 18,5 – 24,99 = wartość prawidłowa", Points = 4 },
                new Answer { IDAnswer = 7, Answers = "E 25 – 29,99 = nadwaga", Points = 5 },
                new Answer { IDAnswer = 8, Answers = "F 30 – 34,99 = otyłość I stopnia", Points = 6 },
                new Answer { IDAnswer = 9, Answers = "G 35 – 39,99 = otyłość II stopnia", Points = 7 },
                new Answer { IDAnswer = 10, Answers = "H > 40 = otyłość III stopnia", Points = 8 },   
                new Answer { IDAnswer = 11, Answers = "A 18-24", Points = 1 },
                new Answer { IDAnswer = 12, Answers = "B 25-40", Points = 2 },
                new Answer { IDAnswer = 13, Answers = "C 41-59", Points = 3 },
                new Answer { IDAnswer = 14, Answers = "D 60+", Points = 4 },
                new Answer { IDAnswer = 15, Answers = "A Fizyczna", Points = 1 },
                new Answer { IDAnswer = 16, Answers = "B Stojąca", Points = 2 },
                new Answer { IDAnswer = 17, Answers = "C Siedzaca", Points = 3 },
                new Answer { IDAnswer = 18, Answers = "A Częściej niz raz w tygoniu", Points = 2 },
                new Answer { IDAnswer = 19, Answers = "B Raz w tygoniu lub rzadziej", Points = 3 },
                new Answer { IDAnswer = 20, Answers = "C Rzadziej niż raz w miesiącu", Points = 4 },
                new Answer { IDAnswer = 21, Answers = "D Wcale", Points = 5 }
                );
            builder.Entity<Question>().HasData(
                new Question { IDQestion = 1, Questions = "Wybierz swoją płeć" },
                new Question { IDQestion = 2, Questions = "Wybierz swoje BMi BMI = masa ciała (kg) / wzrost*2 (m)" },
                new Question { IDQestion = 3, Questions = "Pdaj swój wiek" },
                new Question { IDQestion = 4, Questions = "Tryb pracy" },
                new Question { IDQestion = 5, Questions = "Jak często uprawiasz sport" }
                

                );
            builder.Entity<Reply>().HasData(
                new Reply { IDReply = 1, IDQuestion = 1, IDAnswer= 1 },
                new Reply { IDReply = 2, IDQuestion = 1, IDAnswer = 2 },
                new Reply { IDReply = 3, IDQuestion = 2, IDAnswer = 3 },
                new Reply { IDReply = 4, IDQuestion = 2, IDAnswer = 4 },
                new Reply { IDReply = 5, IDQuestion = 2, IDAnswer = 5 },
                new Reply { IDReply = 6, IDQuestion = 2, IDAnswer = 6 },
                new Reply { IDReply = 7, IDQuestion = 2, IDAnswer = 7 },
                new Reply { IDReply = 8, IDQuestion = 2, IDAnswer = 8 },
                new Reply { IDReply = 9, IDQuestion = 2, IDAnswer = 9 },
                new Reply { IDReply = 10, IDQuestion = 2, IDAnswer = 10 },
                new Reply { IDReply = 11, IDQuestion = 3, IDAnswer = 11 },
                new Reply { IDReply = 12, IDQuestion = 3, IDAnswer = 12 },
                new Reply { IDReply = 13, IDQuestion = 3, IDAnswer = 13 },
                new Reply { IDReply = 14, IDQuestion = 3, IDAnswer = 14 },
                new Reply { IDReply = 15, IDQuestion = 4, IDAnswer = 15 },
                new Reply { IDReply = 16, IDQuestion = 4, IDAnswer = 16 },
                new Reply { IDReply = 17, IDQuestion = 4, IDAnswer = 17 },
                new Reply { IDReply = 18, IDQuestion = 5, IDAnswer = 18 },
                new Reply { IDReply = 19, IDQuestion = 5, IDAnswer = 19 },
                new Reply { IDReply = 20, IDQuestion = 5, IDAnswer = 20 }

                );
            builder.Entity<Result>().HasData(
                new Result { IDResult = 1, ScoreMin = 5, ScoreMax = 23, Diet = "Dieta dla aktywnych Dieta dla osób aktywnych powinna dostarczać wszystkie składniki odżywcze - białka," +
                "tłuszcze oraz węglowodany - w odpowiednim stosunku. Przyjmuje się, iż węglowodany powinny pokrywać 55 % zapotrzebowania energetycznego, tłuszcze 30 %, a białka 15 %. " +
                "Ze względu na intensywny tryb życia wzrasta zapotrzebowanie na energię średnio o około 500 kcal. Węglowodany, powinny dominować węglowodany złożone, czyli kasze(gryczana, jęczmienna)," +
                " ryż brązowy, pieczywo pełnoziarniste. W ograniczonych ilościach powinny być spożywane węglowodany proste, których źródłem są owoce, słodycze oraz desery. " +
                "Tłuszcze nienasycone oleje roślinne(lniany, słonecznikowy, z orzechów włoskich) oraz oliwa z oliwek. Białko pełnowartościowe mleko i jego przetwory(ser biały, jogurt naturalny, kefir)," +
                "ryby morskie oraz chude mięso i wędliny zawierające powyżej 70 % mięsa." +
                "Wysiłek fizyczny wiąże się z dużą stratą wody i składników mineralnych.Z tego względu zaleca się picie 2 litrów dziennie," +
                "w tym do każdego posiłku 2 szklanki napoju, najlepiej wody mineralnej niegazowanej wysokozmineralizowanej, soków warzywnych oraz zielonej herbaty wykazującej silne właściwości antyoksydacyjne."}
                );
        }
    }
    }
