using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parti_Secim_Anketi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ilce = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AParti = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BParti = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CParti = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DParti = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EParti = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Districts");
        }
    }
}
