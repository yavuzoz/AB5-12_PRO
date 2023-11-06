using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AB5_12_PRO.Migrations
{
    /// <inheritdoc />
    public partial class DBErstellung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lieferkosten",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameZone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preis = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lieferkosten", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kunden",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vorname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LieferkostenID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunden", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Kunden_Lieferkosten_LieferkostenID",
                        column: x => x.LieferkostenID,
                        principalTable: "Lieferkosten",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kunden_LieferkostenID",
                table: "Kunden",
                column: "LieferkostenID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kunden");

            migrationBuilder.DropTable(
                name: "Lieferkosten");
        }
    }
}
