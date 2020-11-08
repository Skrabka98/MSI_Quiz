using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizDiet.Migrations
{
    public partial class UpdateBase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "IDAnswer",
                keyValue: 1,
                column: "Answers",
                value: "A1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "IDAnswer",
                keyValue: 1,
                column: "Answers",
                value: "A");
        }
    }
}
