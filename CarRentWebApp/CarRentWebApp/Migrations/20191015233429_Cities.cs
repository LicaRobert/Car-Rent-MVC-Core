using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentWebApp.Migrations
{
    public partial class Cities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityName = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                 constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityID);
                });

                migrationBuilder.InsertData(
               table: "City",
               columns: new[] { "CityID", "CityName" },
               values: new object[,]
               {
                    { 1, "Craiova" },
                    { 2, "Brasov" },
                    { 3, "Calarasi" },
                    { 4, "Bucuresti" },
                    { 5, "Timisoara" },
                    { 6, "Alexandria" },
                    { 7, "Oradea" },
                    { 8, "Cluj-Napoca" },
                    { 9, "Galati" },
                    { 10, "Sibiu" },
                    { 11, "Slatina" },
                    { 12, "Constanta" },
                    { 13, "Ploiesti" },
                    { 14, "Pitesti" },
                    { 15, "Arad" },
                    { 16, "Iasi" },
                    { 17, "Bacau" },
                    { 18, "Satu Mare" },
                    { 19, "Alba Iulia" },
                    { 20, "Targu Mures" }
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "City");
        }
    }
}
