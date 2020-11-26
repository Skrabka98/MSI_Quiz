using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizDiet.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    IDAnswer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answers = table.Column<string>(nullable: false),
                    Points = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.IDAnswer);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    IDQestion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Questions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.IDQestion);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    IDResult = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScoreMin = table.Column<int>(nullable: false),
                    ScoreMax = table.Column<int>(nullable: false),
                    Diet = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.IDResult);
                });

            migrationBuilder.CreateTable(
                name: "Replies",
                columns: table => new
                {
                    IDReply = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDAnswer = table.Column<int>(nullable: false),
                    IDQuestion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replies", x => x.IDReply);
                    table.ForeignKey(
                        name: "FK_Replies_Answers_IDAnswer",
                        column: x => x.IDAnswer,
                        principalTable: "Answers",
                        principalColumn: "IDAnswer",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Replies_Questions_IDQuestion",
                        column: x => x.IDQuestion,
                        principalTable: "Questions",
                        principalColumn: "IDQestion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "IDAnswer", "Answers", "Points" },
                values: new object[,]
                {
                    { 1, "A Kobieta", 1 },
                    { 21, "D Wcale", 5 },
                    { 20, "C Rzadziej niż raz w miesiącu", 4 },
                    { 19, "B Raz w tygoniu lub rzadziej", 3 },
                    { 18, "A Częściej niz raz w tygoniu", 2 },
                    { 17, "C Siedzaca", 3 },
                    { 16, "B Stojąca", 2 },
                    { 15, "A Fizyczna", 1 },
                    { 13, "C 41-59", 3 },
                    { 12, "B 25-40", 2 },
                    { 14, "D 60+", 4 },
                    { 10, "H > 40 = otyłość III stopnia", 8 },
                    { 2, "B Mężczyzna", 2 },
                    { 11, "A 18-24", 1 },
                    { 4, "B 16 – 16,99 = wychudzenie", 2 },
                    { 5, "C 17 – 18,49 = niedowaga", 3 },
                    { 3, "A < 16 = wygłodzenie", 1 },
                    { 7, "E 25 – 29,99 = nadwaga", 5 },
                    { 8, "F 30 – 34,99 = otyłość I stopnia", 6 },
                    { 9, "G 35 – 39,99 = otyłość II stopnia", 7 },
                    { 6, "D 18,5 – 24,99 = wartość prawidłowa", 4 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "IDQestion", "Questions" },
                values: new object[,]
                {
                    { 1, "Wybierz swoją płeć" },
                    { 2, "Wybierz swoje BMi BMI = masa ciała (kg) / wzrost*2 (m)" },
                    { 3, "Pdaj swój wiek" },
                    { 4, "Tryb pracy" },
                    { 5, "Jak często uprawiasz sport" }
                });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "IDResult", "Diet", "ScoreMax", "ScoreMin" },
                values: new object[,]
                {
                    { 1, "Jakaś pierwsza dieta", 10, 5 },
                    { 2, "Jakaś druga dieta", 20, 11 }
                });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "IDReply", "IDAnswer", "IDQuestion" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 18, 18, 5 },
                    { 17, 17, 4 },
                    { 16, 16, 4 },
                    { 15, 15, 4 },
                    { 14, 14, 3 },
                    { 13, 13, 3 },
                    { 12, 12, 3 },
                    { 11, 11, 3 },
                    { 10, 10, 2 },
                    { 9, 9, 2 },
                    { 8, 8, 2 },
                    { 7, 7, 2 },
                    { 6, 6, 2 },
                    { 5, 5, 2 },
                    { 4, 4, 2 },
                    { 3, 3, 2 },
                    { 2, 2, 1 },
                    { 19, 19, 5 },
                    { 20, 20, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Replies_IDAnswer",
                table: "Replies",
                column: "IDAnswer");

            migrationBuilder.CreateIndex(
                name: "IX_Replies_IDQuestion",
                table: "Replies",
                column: "IDQuestion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Replies");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
