using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AspCoreWebApp.Entities.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carilers",
                columns: table => new
                {
                    CariID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CariAd = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    CariSoyad = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    CariSehir = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: true),
                    CariMail = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Durum = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carilers", x => x.CariID);
                });

            migrationBuilder.CreateTable(
                name: "Departman",
                columns: table => new
                {
                    DepartmanID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DepartmanAd = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Durum = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departman", x => x.DepartmanID);
                });

            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KategoriAd = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Personel",
                columns: table => new
                {
                    PersonelID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonelAd = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    PersonelSoyad = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    PersonelGorsel = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    Departmanid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personel", x => x.PersonelID);
                    table.ForeignKey(
                        name: "FK_Personel_Departman_Departmanid",
                        column: x => x.Departmanid,
                        principalTable: "Departman",
                        principalColumn: "DepartmanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Urun",
                columns: table => new
                {
                    UrunID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UrunAd = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Marka = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Stok = table.Column<short>(type: "smallint", nullable: false),
                    AlisFiyati = table.Column<decimal>(type: "numeric", nullable: false),
                    SatisFİyati = table.Column<decimal>(type: "numeric", nullable: false),
                    Durum = table.Column<bool>(type: "boolean", nullable: false),
                    UrunGorsel = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    KategoriId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urun", x => x.UrunID);
                    table.ForeignKey(
                        name: "FK_Urun_Kategori_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategori",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SatisHareket",
                columns: table => new
                {
                    SatisID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tarih = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Adet = table.Column<int>(type: "integer", nullable: false),
                    Fiyat = table.Column<decimal>(type: "numeric", nullable: false),
                    ToplamTutar = table.Column<decimal>(type: "numeric", nullable: false),
                    Urunid = table.Column<int>(type: "integer", nullable: false),
                    Cariid = table.Column<int>(type: "integer", nullable: false),
                    Personelid = table.Column<int>(type: "integer", nullable: false),
                    CarilerCariID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatisHareket", x => x.SatisID);
                    table.ForeignKey(
                        name: "FK_SatisHareket_Carilers_CarilerCariID",
                        column: x => x.CarilerCariID,
                        principalTable: "Carilers",
                        principalColumn: "CariID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SatisHareket_Personel_Personelid",
                        column: x => x.Personelid,
                        principalTable: "Personel",
                        principalColumn: "PersonelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SatisHareket_Urun_Urunid",
                        column: x => x.Urunid,
                        principalTable: "Urun",
                        principalColumn: "UrunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personel_Departmanid",
                table: "Personel",
                column: "Departmanid");

            migrationBuilder.CreateIndex(
                name: "IX_SatisHareket_CarilerCariID",
                table: "SatisHareket",
                column: "CarilerCariID");

            migrationBuilder.CreateIndex(
                name: "IX_SatisHareket_Personelid",
                table: "SatisHareket",
                column: "Personelid");

            migrationBuilder.CreateIndex(
                name: "IX_SatisHareket_Urunid",
                table: "SatisHareket",
                column: "Urunid");

            migrationBuilder.CreateIndex(
                name: "IX_Urun_KategoriId",
                table: "Urun",
                column: "KategoriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SatisHareket");

            migrationBuilder.DropTable(
                name: "Carilers");

            migrationBuilder.DropTable(
                name: "Personel");

            migrationBuilder.DropTable(
                name: "Urun");

            migrationBuilder.DropTable(
                name: "Departman");

            migrationBuilder.DropTable(
                name: "Kategori");
        }
    }
}
