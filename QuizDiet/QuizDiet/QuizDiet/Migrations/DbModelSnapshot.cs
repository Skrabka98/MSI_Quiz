﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizDiet.Models.Data;

namespace QuizDiet.Migrations
{
    [DbContext(typeof(Db))]
    partial class DbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuizDiet.Models.Data.Answer", b =>
                {
                    b.Property<int>("IDAnswer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.HasKey("IDAnswer");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            IDAnswer = 1,
                            Answers = "A1",
                            Points = 1
                        },
                        new
                        {
                            IDAnswer = 2,
                            Answers = "B",
                            Points = 2
                        },
                        new
                        {
                            IDAnswer = 3,
                            Answers = "C",
                            Points = 3
                        },
                        new
                        {
                            IDAnswer = 4,
                            Answers = "D",
                            Points = 4
                        },
                        new
                        {
                            IDAnswer = 5,
                            Answers = "A",
                            Points = 1
                        },
                        new
                        {
                            IDAnswer = 6,
                            Answers = "B",
                            Points = 2
                        },
                        new
                        {
                            IDAnswer = 7,
                            Answers = "C",
                            Points = 3
                        },
                        new
                        {
                            IDAnswer = 8,
                            Answers = "D",
                            Points = 4
                        },
                        new
                        {
                            IDAnswer = 9,
                            Answers = "A",
                            Points = 1
                        },
                        new
                        {
                            IDAnswer = 10,
                            Answers = "B",
                            Points = 2
                        },
                        new
                        {
                            IDAnswer = 11,
                            Answers = "C",
                            Points = 3
                        },
                        new
                        {
                            IDAnswer = 12,
                            Answers = "D",
                            Points = 4
                        },
                        new
                        {
                            IDAnswer = 13,
                            Answers = "A",
                            Points = 1
                        },
                        new
                        {
                            IDAnswer = 14,
                            Answers = "B",
                            Points = 2
                        },
                        new
                        {
                            IDAnswer = 15,
                            Answers = "C",
                            Points = 3
                        },
                        new
                        {
                            IDAnswer = 16,
                            Answers = "D",
                            Points = 4
                        },
                        new
                        {
                            IDAnswer = 17,
                            Answers = "A",
                            Points = 1
                        },
                        new
                        {
                            IDAnswer = 18,
                            Answers = "B",
                            Points = 2
                        },
                        new
                        {
                            IDAnswer = 19,
                            Answers = "C",
                            Points = 3
                        },
                        new
                        {
                            IDAnswer = 20,
                            Answers = "D",
                            Points = 4
                        });
                });

            modelBuilder.Entity("QuizDiet.Models.Data.Question", b =>
                {
                    b.Property<int>("IDQestion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Questions")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDQestion");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            IDQestion = 1,
                            Questions = "Pytanie 1"
                        },
                        new
                        {
                            IDQestion = 2,
                            Questions = "Pytanie 2"
                        },
                        new
                        {
                            IDQestion = 3,
                            Questions = "Pytanie 3"
                        },
                        new
                        {
                            IDQestion = 4,
                            Questions = "Pytanie 4"
                        },
                        new
                        {
                            IDQestion = 5,
                            Questions = "Pytanie 5"
                        });
                });

            modelBuilder.Entity("QuizDiet.Models.Data.Reply", b =>
                {
                    b.Property<int>("IDReply")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDAnswer")
                        .HasColumnType("int");

                    b.Property<int>("IDQuestion")
                        .HasColumnType("int");

                    b.HasKey("IDReply");

                    b.HasIndex("IDAnswer");

                    b.HasIndex("IDQuestion");

                    b.ToTable("Replies");

                    b.HasData(
                        new
                        {
                            IDReply = 1,
                            IDAnswer = 1,
                            IDQuestion = 1
                        },
                        new
                        {
                            IDReply = 2,
                            IDAnswer = 2,
                            IDQuestion = 1
                        },
                        new
                        {
                            IDReply = 3,
                            IDAnswer = 3,
                            IDQuestion = 1
                        },
                        new
                        {
                            IDReply = 4,
                            IDAnswer = 4,
                            IDQuestion = 1
                        },
                        new
                        {
                            IDReply = 5,
                            IDAnswer = 5,
                            IDQuestion = 2
                        },
                        new
                        {
                            IDReply = 6,
                            IDAnswer = 6,
                            IDQuestion = 2
                        },
                        new
                        {
                            IDReply = 7,
                            IDAnswer = 7,
                            IDQuestion = 2
                        },
                        new
                        {
                            IDReply = 8,
                            IDAnswer = 8,
                            IDQuestion = 2
                        },
                        new
                        {
                            IDReply = 9,
                            IDAnswer = 9,
                            IDQuestion = 3
                        },
                        new
                        {
                            IDReply = 10,
                            IDAnswer = 10,
                            IDQuestion = 3
                        },
                        new
                        {
                            IDReply = 11,
                            IDAnswer = 11,
                            IDQuestion = 3
                        },
                        new
                        {
                            IDReply = 12,
                            IDAnswer = 12,
                            IDQuestion = 3
                        },
                        new
                        {
                            IDReply = 13,
                            IDAnswer = 13,
                            IDQuestion = 4
                        },
                        new
                        {
                            IDReply = 14,
                            IDAnswer = 14,
                            IDQuestion = 4
                        },
                        new
                        {
                            IDReply = 15,
                            IDAnswer = 15,
                            IDQuestion = 4
                        },
                        new
                        {
                            IDReply = 16,
                            IDAnswer = 16,
                            IDQuestion = 4
                        },
                        new
                        {
                            IDReply = 17,
                            IDAnswer = 17,
                            IDQuestion = 5
                        },
                        new
                        {
                            IDReply = 18,
                            IDAnswer = 18,
                            IDQuestion = 5
                        },
                        new
                        {
                            IDReply = 19,
                            IDAnswer = 19,
                            IDQuestion = 5
                        },
                        new
                        {
                            IDReply = 20,
                            IDAnswer = 20,
                            IDQuestion = 5
                        });
                });

            modelBuilder.Entity("QuizDiet.Models.Data.Result", b =>
                {
                    b.Property<int>("IDResult")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Diet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScoreMax")
                        .HasColumnType("int");

                    b.Property<int>("ScoreMin")
                        .HasColumnType("int");

                    b.HasKey("IDResult");

                    b.ToTable("Results");

                    b.HasData(
                        new
                        {
                            IDResult = 1,
                            Diet = "Jakaś pierwsza dieta",
                            ScoreMax = 10,
                            ScoreMin = 5
                        },
                        new
                        {
                            IDResult = 2,
                            Diet = "Jakaś druga dieta",
                            ScoreMax = 20,
                            ScoreMin = 11
                        });
                });

            modelBuilder.Entity("QuizDiet.Models.Data.Reply", b =>
                {
                    b.HasOne("QuizDiet.Models.Data.Answer", "Answer")
                        .WithMany("Replies")
                        .HasForeignKey("IDAnswer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuizDiet.Models.Data.Question", "Question")
                        .WithMany("Replies")
                        .HasForeignKey("IDQuestion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
