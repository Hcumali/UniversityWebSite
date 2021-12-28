using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityWebSite.DataAccess.Migrations
{
    public partial class addedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 553, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Name" },
                values: new object[] { new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2189), "Yönetim" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedTime", "Name", "NavBarHeader", "UpdatedTime" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2191), "Sayılarla DÜ", 0, null },
                    { 25, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2278), "Etkinlikler", 3, null },
                    { 26, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2279), "E-Posta", 4, null },
                    { 27, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2280), "EBYS", 4, null },
                    { 28, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2281), "ÖBS/KYBS", 4, null },
                    { 29, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2282), "UZEM", 4, null },
                    { 31, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2284), "Rehber", 4, null },
                    { 24, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2277), "İşbirlikleri", 3, null },
                    { 32, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2285), "PBS", 4, null },
                    { 33, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2286), "Staj", 4, null },
                    { 34, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2287), "Havuz", 4, null },
                    { 35, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2288), "Yemek Menüsü", 4, null },
                    { 30, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2283), "Kütüphane", 4, null },
                    { 22, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2275), "Üretim Merkezi", 3, null },
                    { 23, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2276), "Bilimsel Yayınlar", 3, null },
                    { 20, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2273), "Tıbbi Bitki Yetiştiriciliği", 3, null },
                    { 5, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2249), "Sıralamalar", 0, null },
                    { 6, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2251), "İlkler", 0, null },
                    { 7, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2258), "Kurumsal Strateji", 0, null },
                    { 8, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2260), "İdari Birimler", 0, null },
                    { 9, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2261), "Fakülteler", 1, null },
                    { 10, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2262), "Enstitüler", 1, null },
                    { 21, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2274), "Ürünler/Markalar", 3, null },
                    { 12, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2264), "Meslek Yüksekokulları", 1, null },
                    { 11, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2263), "Yüksekokullar", 1, null },
                    { 14, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2266), "Bölüm Başkanlıkları", 1, null },
                    { 15, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2267), "Araştırma Merkezleri", 2, null },
                    { 16, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2269), "Laboratuvar Envanteri", 2, null },
                    { 17, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2270), "Yayınlar/Projeler", 2, null },
                    { 18, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2271), "Hakemli Dergiler", 2, null },
                    { 19, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2272), "Teknoloji Transfer Ofisi", 2, null },
                    { 13, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2265), "Kurullar", 1, null }
                });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedTime", "Name" },
                values: new object[] { 3, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2853), "Rektör" });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedTime", "Name" },
                values: new object[] { 3, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3258), "Rektör Yardımcıları" });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Name" },
                values: new object[] { new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3261), "Senato" });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "Name" },
                values: new object[] { new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3262), "Yönetim Kurulu" });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedTime", "Name" },
                values: new object[] { 4, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3264), "Öğrenci Sayıları" });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedTime", "Name" },
                values: new object[] { 4, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3265), "Personel Sayıları" });

            migrationBuilder.InsertData(
                table: "Subtitles",
                columns: new[] { "Id", "CategoryId", "CreatedTime", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { 7, 4, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3266), "Proje Sayıları", null },
                    { 30, 12, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3297), "Gölyaka MYO", null },
                    { 29, 12, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3296), "Düzce MYO", null },
                    { 28, 12, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3295), "Çilimli MYO", null },
                    { 27, 12, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3293), "Akçakoca MYO", null },
                    { 26, 11, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3292), "Hakime Erciyas Yabancı Diller", null },
                    { 25, 11, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3291), "Akçakoca Turizm İşletme", null },
                    { 24, 10, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3290), "Sosyal Bilimler Enstitüsü", null },
                    { 23, 10, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3288), "Sağlık Bilimleri Enstitüsü", null },
                    { 22, 10, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3287), "Fen Bilimleri Enstitüsü", null },
                    { 21, 10, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3286), "Güzel Sanatlar Enstitüsü", null },
                    { 20, 9, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3285), "Fen Edebiyat Fakültesi", null },
                    { 18, 9, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3282), "Mühendislik Fakültesi", null },
                    { 31, 14, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3298), "Atatürk İlkeleri ve İnkılap Tarihi", null },
                    { 17, 9, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3281), "Eğitim Fakültesi", null },
                    { 16, 7, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3280), "Sürdürülebilirlik Raporu", null },
                    { 15, 7, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3278), "Sürekli İyileştirme", null },
                    { 14, 7, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3277), "Kalite Politikası", null },
                    { 13, 7, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3276), "Stratejik Plan", null },
                    { 12, 5, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3275), "InnovaLig", null },
                    { 11, 5, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3274), "Green Metric", null },
                    { 10, 5, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3273), "THE", null },
                    { 9, 5, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3269), "URAP", null },
                    { 8, 4, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3267), "Fikri Mülkiyet", null },
                    { 19, 9, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3284), "Tıp Fakültesi", null },
                    { 32, 14, new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3299), "Türk Dili", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 16, 54, 57, 919, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 16, 54, 57, 920, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Name" },
                values: new object[] { new DateTime(2021, 12, 28, 16, 54, 57, 920, DateTimeKind.Local).AddTicks(5120), "Sayılarla DÜ" });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedTime", "Name" },
                values: new object[] { 2, new DateTime(2021, 12, 28, 16, 54, 57, 920, DateTimeKind.Local).AddTicks(5576), "subtitle1" });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedTime", "Name" },
                values: new object[] { 2, new DateTime(2021, 12, 28, 16, 54, 57, 920, DateTimeKind.Local).AddTicks(5912), "subtitle2" });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Name" },
                values: new object[] { new DateTime(2021, 12, 28, 16, 54, 57, 920, DateTimeKind.Local).AddTicks(5916), "subtitle3" });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "Name" },
                values: new object[] { new DateTime(2021, 12, 28, 16, 54, 57, 920, DateTimeKind.Local).AddTicks(5917), "subtitle4" });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedTime", "Name" },
                values: new object[] { 1, new DateTime(2021, 12, 28, 16, 54, 57, 920, DateTimeKind.Local).AddTicks(5918), "subtitle5" });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedTime", "Name" },
                values: new object[] { 1, new DateTime(2021, 12, 28, 16, 54, 57, 920, DateTimeKind.Local).AddTicks(5919), "subtitle6" });
        }
    }
}
