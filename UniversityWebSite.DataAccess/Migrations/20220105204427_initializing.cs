using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityWebSite.DataAccess.Migrations
{
    public partial class initializing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Paragraph = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NavBarHeader = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Keywords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keywords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfStudent = table.Column<int>(type: "int", nullable: false),
                    NumberOfFaculty = table.Column<int>(type: "int", nullable: false),
                    NumberOfProject = table.Column<int>(type: "int", nullable: false),
                    NumberOfTeacher = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Boxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutId = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boxes_Abouts_AboutId",
                        column: x => x.AboutId,
                        principalTable: "Abouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subtitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subtitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subtitles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "CreatedTime", "Paragraph", "UpdatedTime" },
                values: new object[] { 1, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(2808), "Üniversitemizde öğrencilerimizin istedikleri alanda özelleşmelerine olanak sağlayan geniş yelpazeli seçmeli ders seçenekleri sunulmaktadır. Dileyen öğrencilerimiz diğer bölüm programlarıyla yandal ve çift anadal eğitimi alabilme imkânına sahiptir. Öğrencilerimize ilaveten Erasmus Öğrenci Değişim Programı kapsamında yurt dışında anlaşmalı olduğumuz üniversitelerde burslu eğitim alma imkânı da sağlanmaktadır. Bu program dahilinde öğrencilerimiz eğitimlerine bir veya iki dönem Avrupa’da devam edebilmektedirler.", null });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CreatedTime", "Password", "UpdatedTime", "Username" },
                values: new object[] { 1, null, "123456a", null, "admin" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedTime", "Name", "NavBarHeader", "UpdatedTime" },
                values: new object[,]
                {
                    { 20, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9548), "Tıbbi Bitki Yetiştiriciliği", 3, null },
                    { 21, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9549), "Ürünler/Markalar", 3, null },
                    { 22, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9550), "Üretim Merkezi", 3, null },
                    { 23, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9551), "Bilimsel Yayınlar", 3, null },
                    { 24, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9553), "İşbirlikleri", 3, null },
                    { 25, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9554), "Etkinlikler", 3, null },
                    { 26, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9555), "E-Posta", 4, null },
                    { 28, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9557), "ÖBS/KYBS", 4, null },
                    { 29, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9558), "UZEM", 4, null },
                    { 30, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9559), "Kütüphane", 4, null },
                    { 31, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9560), "Rehber", 4, null },
                    { 32, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9562), "PBS", 4, null },
                    { 33, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9563), "Staj", 4, null },
                    { 34, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9564), "Havuz", 4, null },
                    { 35, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9565), "Yemek Menüsü", 4, null },
                    { 19, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9547), "Teknoloji Transfer Ofisi", 2, null },
                    { 18, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9545), "Hakemli Dergiler", 2, null },
                    { 27, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9556), "EBYS", 4, null },
                    { 16, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9541), "Laboratuvar Envanteri", 2, null },
                    { 17, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9543), "Yayınlar/Projeler", 2, null },
                    { 1, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(2099), "Düzce", 0, null },
                    { 2, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9495), "Kuruluş", 0, null },
                    { 3, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9523), "Yönetim", 0, null },
                    { 4, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9525), "Sayılarla DÜ", 0, null },
                    { 5, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9526), "Sıralamalar", 0, null },
                    { 7, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9529), "Kurumsal Strateji", 0, null },
                    { 8, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9530), "İdari Birimler", 0, null },
                    { 6, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9528), "İlkler", 0, null },
                    { 9, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9531), "Fakülteler", 1, null },
                    { 10, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9533), "Enstitüler", 1, null },
                    { 11, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9534), "Yüksekokullar", 1, null },
                    { 12, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9536), "Meslek Yüksekokulları", 1, null },
                    { 13, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9537), "Kurullar", 1, null },
                    { 14, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9538), "Bölüm Başkanlıkları", 1, null },
                    { 15, new DateTime(2022, 1, 5, 23, 44, 26, 472, DateTimeKind.Local).AddTicks(9539), "Araştırma Merkezleri", 2, null }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CreatedTime", "Email", "Fax", "Phone", "UpdatedTime" },
                values: new object[] { 1, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(1313), "du@edu.tr", "+90 (380) 5421103", "+90 850 800 8181", null });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "CreatedTime", "Title", "UpdatedTime" },
                values: new object[,]
                {
                    { 8, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(989), "Orman", null },
                    { 11, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(992), "Eğitim", null },
                    { 10, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(991), "Spor Bilimleri", null },
                    { 9, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(990), "Sağlık Bilimleri", null }
                });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "CreatedTime", "Title", "UpdatedTime" },
                values: new object[,]
                {
                    { 12, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(996), "Siyasal Bilgiler", null },
                    { 7, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(987), "İşletme", null },
                    { 1, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(816), "Mühendislik", null },
                    { 5, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(985), "Fen Edebiyat", null },
                    { 4, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(984), "Eğitim", null },
                    { 3, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(983), "Ziraat", null },
                    { 2, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(980), "Tıp", null },
                    { 6, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(986), "Mimarlık", null }
                });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "Id", "CreatedTime", "UpdatedTime", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(4013), null, "https://studyinturkey.net/wp-content/uploads/2021/01/duzce-universitesi-kampus.jpg" },
                    { 2, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(4171), null, "https://static.daktilo.com/sites/622/uploads/2021/06/07/whatsapp-image-2021-06-07-at-164152-1.jpeg" },
                    { 3, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(4173), null, "https://pbs.twimg.com/media/FDa851KWUAEoNpt?format=jpg&name=large" }
                });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "Id", "CreatedTime", "NumberOfFaculty", "NumberOfProject", "NumberOfStudent", "NumberOfTeacher", "UpdatedTime" },
                values: new object[] { 1, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(2016), 12, 1231, 17592, 1275, null });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "CreatedTime", "Title", "UpdatedTime", "Url" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(4798), "DÜ Tanıtım Filmi 2018", null, "youtube.com/watch?v=-myyQEpicLY" },
                    { 1, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(4480), "DÜ Tanıtım Filmi 2021", null, "youtube.com/watch?v=mSS-tfXDrT4" },
                    { 3, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(4801), "DÜ 15. Yıl Özel Belgeseli", null, "youtube.com/watch?v=z2hqyvV6Me0" }
                });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "AboutId", "CreatedTime", "Header", "Text", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(3268), "Nitelikli akademik kadro", "Mesleki bilgileri kazanım için bir bölümdeki en önemli unsur öğretim kadrosudur.", null },
                    { 2, 1, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(3732), "Güncel eğitim programı ve ders içerikleri", "Dünyadaki eğilime uygun olarak bir endüstri mühendisine kazandırılması gereken yetkinlikler dikkate alınarak eğitim programı tasarlanmıştır.", null },
                    { 3, 1, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(3735), "Öğrencinin sosyal, kültürel ve spor faaliyetleri", "Kampüsümüzde devlet tiyatrosu mevcut olup burada tiyatro ve sanatsal etkinlikler düzenlenmektedir. Yine olimpik yüzme havuzunu, dans salonlarını, kapalı spor salonunu, tekno fitness salonunu içeren Türkiye’nin en büyük kapalı spor merkezi üniversitemizde mevcuttur.", null }
                });

            migrationBuilder.InsertData(
                table: "Subtitles",
                columns: new[] { "Id", "CategoryId", "CreatedTime", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { 18, 9, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(477), "Mühendislik Fakültesi", null },
                    { 19, 9, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(478), "Tıp Fakültesi", null },
                    { 20, 9, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(480), "Fen Edebiyat Fakültesi", null },
                    { 21, 10, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(482), "Güzel Sanatlar Enstitüsü", null },
                    { 22, 10, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(485), "Fen Bilimleri Enstitüsü", null },
                    { 23, 10, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(486), "Sağlık Bilimleri Enstitüsü", null },
                    { 25, 11, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(489), "Akçakoca Turizm İşletme", null },
                    { 17, 9, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(476), "Eğitim Fakültesi", null },
                    { 26, 11, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(492), "Hakime Erciyas Yabancı Diller", null },
                    { 27, 12, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(493), "Akçakoca MYO", null },
                    { 28, 12, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(494), "Çilimli MYO", null },
                    { 29, 12, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(495), "Düzce MYO", null },
                    { 30, 12, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(497), "Gölyaka MYO", null },
                    { 24, 10, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(487), "Sosyal Bilimler Enstitüsü", null },
                    { 16, 7, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(475), "Sürdürülebilirlik Raporu", null },
                    { 15, 7, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(474), "Sürekli İyileştirme", null },
                    { 14, 7, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(472), "Kalite Politikası", null },
                    { 13, 7, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(471), "Stratejik Plan", null },
                    { 12, 5, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(470), "InnovaLig", null },
                    { 11, 5, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(469), "Green Metric", null },
                    { 10, 5, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(467), "THE", null },
                    { 9, 5, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(466), "URAP", null },
                    { 8, 4, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(465), "Fikri Mülkiyet", null },
                    { 7, 4, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(464), "Proje Sayıları", null },
                    { 6, 4, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(462), "Personel Sayıları", null },
                    { 5, 4, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(461), "Öğrenci Sayıları", null },
                    { 4, 3, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(460), "Yönetim Kurulu", null },
                    { 3, 3, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(459), "Senato", null },
                    { 2, 3, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(456), "Rektör Yardımcıları", null },
                    { 1, 3, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(91), "Rektör", null },
                    { 31, 14, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(498), "Atatürk İlkeleri ve İnkılap Tarihi", null },
                    { 32, 14, new DateTime(2022, 1, 5, 23, 44, 26, 473, DateTimeKind.Local).AddTicks(499), "Türk Dili", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boxes_AboutId",
                table: "Boxes",
                column: "AboutId");

            migrationBuilder.CreateIndex(
                name: "IX_Subtitles_CategoryId",
                table: "Subtitles",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Boxes");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Keywords");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropTable(
                name: "Subtitles");

            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
