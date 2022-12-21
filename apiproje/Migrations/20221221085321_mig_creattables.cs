using Microsoft.EntityFrameworkCore.Migrations;

namespace apiproje.Migrations
{
    public partial class mig_creattables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aksesuars",
                columns: table => new
                {
                    AksesuarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AksesuarAd = table.Column<string>(nullable: true),
                    AksesuarRenk = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aksesuars", x => x.AksesuarID);
                });

            migrationBuilder.CreateTable(
                name: "urunlers",
                columns: table => new
                {
                    UrunID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAd = table.Column<string>(nullable: true),
                    UrunAciklama = table.Column<string>(nullable: true),
                    UrunYas = table.Column<int>(nullable: false),
                    UrunBeden = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_urunlers", x => x.UrunID);
                });

            migrationBuilder.CreateTable(
                name: "kategorilers",
                columns: table => new
                {
                    KategoriID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(nullable: true),
                    KategoriAciklama = table.Column<string>(nullable: true),
                    UrunID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kategorilers", x => x.KategoriID);
                    table.ForeignKey(
                        name: "FK_kategorilers_urunlers_UrunID",
                        column: x => x.UrunID,
                        principalTable: "urunlers",
                        principalColumn: "UrunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_kategorilers_UrunID",
                table: "kategorilers",
                column: "UrunID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aksesuars");

            migrationBuilder.DropTable(
                name: "kategorilers");

            migrationBuilder.DropTable(
                name: "urunlers");
        }
    }
}
