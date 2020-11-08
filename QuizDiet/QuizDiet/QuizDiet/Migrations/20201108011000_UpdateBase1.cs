using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizDiet.Migrations
{
    public partial class UpdateBase1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "IDQestion",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "IDQestion",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "IDQestion",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "IDQestion",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "IDQestion",
                keyValue: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "IDQestion", "Questions" },
                values: new object[,]
                {
                    { 6, "Pytanie 6" },
                    { 7, "Pytanie 7" },
                    { 8, "Pytanie 8" },
                    { 9, "Pytanie 9" },
                    { 10, "Pytanie 10" }
                });
        }
    }
}
