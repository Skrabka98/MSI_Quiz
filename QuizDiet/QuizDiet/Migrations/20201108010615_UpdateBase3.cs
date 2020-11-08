using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizDiet.Migrations
{
    public partial class UpdateBase3 : Migration
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
                    { 1, "A", 1 },
                    { 20, "D", 4 },
                    { 19, "C", 3 },
                    { 18, "B", 2 },
                    { 17, "A", 1 },
                    { 16, "D", 4 },
                    { 14, "B", 2 },
                    { 13, "A", 1 },
                    { 12, "D", 4 },
                    { 11, "C", 3 },
                    { 15, "C", 3 },
                    { 9, "A", 1 },
                    { 8, "D", 4 },
                    { 7, "C", 3 },
                    { 6, "B", 2 },
                    { 5, "A", 1 },
                    { 4, "D", 4 },
                    { 3, "C", 3 },
                    { 2, "B", 2 },
                    { 10, "B", 2 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "IDQestion", "Questions" },
                values: new object[,]
                {
                    { 8, "Pytanie 8" },
                    { 7, "Pytanie 7" },
                    { 6, "Pytanie 6" },
                    { 5, "Pytanie 5" },
                    { 1, "Pytanie 1" },
                    { 3, "Pytanie 3" },
                    { 2, "Pytanie 2" },
                    { 9, "Pytanie 9" },
                    { 4, "Pytanie 4" },
                    { 10, "Pytanie 10" }
                });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "IDReply", "IDAnswer", "IDQuestion" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 18, 18, 5 },
                    { 17, 17, 5 },
                    { 16, 16, 4 },
                    { 15, 15, 4 },
                    { 14, 14, 4 },
                    { 13, 13, 4 },
                    { 12, 12, 3 },
                    { 11, 11, 3 },
                    { 10, 10, 3 },
                    { 9, 9, 3 },
                    { 8, 8, 2 },
                    { 7, 7, 2 },
                    { 6, 6, 2 },
                    { 5, 5, 2 },
                    { 4, 4, 1 },
                    { 3, 3, 1 },
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
