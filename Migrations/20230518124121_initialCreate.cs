using Microsoft.EntityFrameworkCore.Migrations;

namespace Ogrenci_Not_Kayit_Sistemi.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numara = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Sinav1 = table.Column<int>(type: "int", nullable: false),
                    Sinav2 = table.Column<int>(type: "int", nullable: false),
                    Sinav3 = table.Column<int>(type: "int", nullable: false),
                    Ortalama = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
