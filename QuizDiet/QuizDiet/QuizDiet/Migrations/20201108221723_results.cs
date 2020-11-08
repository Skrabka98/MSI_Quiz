using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizDiet.Migrations
{
    public partial class results : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "IDResult", "Diet", "ScoreMax", "ScoreMin" },
                values: new object[] { 1, "Jakaś pierwsza dieta", 10, 5 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "IDResult", "Diet", "ScoreMax", "ScoreMin" },
                values: new object[] { 2, "Jakaś druga dieta", 20, 11 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "IDResult",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "IDResult",
                keyValue: 2);
        }
    }
}
