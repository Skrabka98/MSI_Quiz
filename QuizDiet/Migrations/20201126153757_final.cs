using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizDiet.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "IDResult",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "IDResult",
                keyValue: 1,
                columns: new[] { "Diet", "ScoreMax" },
                values: new object[] { "Dieta dla aktywnych Dieta dla osób aktywnych powinna dostarczać wszystkie składniki odżywcze - białka,tłuszcze oraz węglowodany - w odpowiednim stosunku. Przyjmuje się, iż węglowodany powinny pokrywać 55 % zapotrzebowania energetycznego, tłuszcze 30 %, a białka 15 %. Ze względu na intensywny tryb życia wzrasta zapotrzebowanie na energię średnio o około 500 kcal. Węglowodany, powinny dominować węglowodany złożone, czyli kasze(gryczana, jęczmienna), ryż brązowy, pieczywo pełnoziarniste. W ograniczonych ilościach powinny być spożywane węglowodany proste, których źródłem są owoce, słodycze oraz desery. Tłuszcze nienasycone oleje roślinne(lniany, słonecznikowy, z orzechów włoskich) oraz oliwa z oliwek. Białko pełnowartościowe mleko i jego przetwory(ser biały, jogurt naturalny, kefir),ryby morskie oraz chude mięso i wędliny zawierające powyżej 70 % mięsa.Wysiłek fizyczny wiąże się z dużą stratą wody i składników mineralnych.Z tego względu zaleca się picie 2 litrów dziennie,w tym do każdego posiłku 2 szklanki napoju, najlepiej wody mineralnej niegazowanej wysokozmineralizowanej, soków warzywnych oraz zielonej herbaty wykazującej silne właściwości antyoksydacyjne.", 23 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Results",
                keyColumn: "IDResult",
                keyValue: 1,
                columns: new[] { "Diet", "ScoreMax" },
                values: new object[] { "Jakaś pierwsza dieta", 10 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "IDResult", "Diet", "ScoreMax", "ScoreMin" },
                values: new object[] { 2, "Jakaś druga dieta", 20, 11 });
        }
    }
}
