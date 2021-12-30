using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityWebSite.DataAccess.Migrations
{
    public partial class addAnotherSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Contacts");

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "CreatedTime", "Paragraph", "UpdatedTime" },
                values: new object[] { 1, new DateTime(2021, 12, 30, 12, 40, 59, 646, DateTimeKind.Local).AddTicks(592), "Üniversitemizde öğrencilerimizin istedikleri alanda özelleşmelerine olanak sağlayan geniş yelpazeli seçmeli ders seçenekleri sunulmaktadır. Dileyen öğrencilerimiz diğer bölüm programlarıyla yandal ve çift anadal eğitimi alabilme imkânına sahiptir. Öğrencilerimize ilaveten Erasmus Öğrenci Değişim Programı kapsamında yurt dışında anlaşmalı olduğumuz üniversitelerde burslu eğitim alma imkânı da sağlanmaktadır. Bu program dahilinde öğrencilerimiz eğitimlerine bir veya iki dönem Avrupa’da devam edebilmektedirler.", null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CreatedTime", "Email", "Fax", "Phone", "UpdatedTime" },
                values: new object[] { 1, new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(9224), "du@edu.tr", "+90 (380) 5421103", "+90 850 800 8181", null });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "CreatedTime", "Title", "UpdatedTime" },
                values: new object[,]
                {
                    { 6, new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(8791), "Mimarlık", null },
                    { 12, new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(8797), "Siyasal Bilgiler", null },
                    { 11, new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(8796), "Eğitim", null },
                    { 10, new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(8795), "Spor Bilimleri", null },
                    { 8, new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(8793), "Orman", null }
                });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "CreatedTime", "Title", "UpdatedTime" },
                values: new object[,]
                {
                    { 7, new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(8792), "İşletme", null },
                    { 9, new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(8794), "Sağlık Bilimleri", null },
                    { 2, new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(8784), "Tıp", null },
                    { 3, new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(8787), "Ziraat", null },
                    { 4, new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(8788), "Eğitim", null },
                    { 5, new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(8789), "Fen Edebiyat", null },
                    { 1, new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(8595), "Mühendislik", null }
                });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "Id", "CreatedTime", "UpdatedTime", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 30, 12, 40, 59, 646, DateTimeKind.Local).AddTicks(1582), null, "https://studyinturkey.net/wp-content/uploads/2021/01/duzce-universitesi-kampus.jpg" },
                    { 2, new DateTime(2021, 12, 30, 12, 40, 59, 646, DateTimeKind.Local).AddTicks(1719), null, "https://static.daktilo.com/sites/622/uploads/2021/06/07/whatsapp-image-2021-06-07-at-164152-1.jpeg" },
                    { 3, new DateTime(2021, 12, 30, 12, 40, 59, 646, DateTimeKind.Local).AddTicks(1722), null, "https://pbs.twimg.com/media/FDa851KWUAEoNpt?format=jpg&name=large" }
                });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "Id", "CreatedTime", "NumberOfFaculty", "NumberOfProject", "NumberOfStudent", "NumberOfTeacher", "UpdatedTime" },
                values: new object[] { 1, new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(9888), 12, 1231, 17592, 1275, null });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 30, 12, 40, 59, 645, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "CreatedTime", "Title", "UpdatedTime", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 30, 12, 40, 59, 646, DateTimeKind.Local).AddTicks(1953), "DÜ Tanıtım Filmi 2021", null, "mSS-tfXDrT4" },
                    { 3, new DateTime(2021, 12, 30, 12, 40, 59, 646, DateTimeKind.Local).AddTicks(2211), "DÜ 15. Yıl Özel Belgeseli", null, "z2hqyvV6Me0" },
                    { 2, new DateTime(2021, 12, 30, 12, 40, 59, 646, DateTimeKind.Local).AddTicks(2209), "DÜ Tanıtım Filmi 2018", null, "-myyQEpicLY" }
                });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "AboutId", "CreatedTime", "Header", "Text", "UpdatedTime" },
                values: new object[] { 1, 1, new DateTime(2021, 12, 30, 12, 40, 59, 646, DateTimeKind.Local).AddTicks(951), "Nitelikli akademik kadro", "Mesleki bilgileri kazanım için bir bölümdeki en önemli unsur öğretim kadrosudur.", null });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "AboutId", "CreatedTime", "Header", "Text", "UpdatedTime" },
                values: new object[] { 2, 1, new DateTime(2021, 12, 30, 12, 40, 59, 646, DateTimeKind.Local).AddTicks(1350), "Güncel eğitim programı ve ders içerikleri", "Dünyadaki eğilime uygun olarak bir endüstri mühendisine kazandırılması gereken yetkinlikler dikkate alınarak eğitim programı tasarlanmıştır.", null });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "AboutId", "CreatedTime", "Header", "Text", "UpdatedTime" },
                values: new object[] { 3, 1, new DateTime(2021, 12, 30, 12, 40, 59, 646, DateTimeKind.Local).AddTicks(1352), "Öğrencinin sosyal, kültürel ve spor faaliyetleri", "Kampüsümüzde devlet tiyatrosu mevcut olup burada tiyatro ve sanatsal etkinlikler düzenlenmektedir. Yine olimpik yüzme havuzunu, dans salonlarını, kapalı spor salonunu, tekno fitness salonunu içeren Türkiye’nin en büyük kapalı spor merkezi üniversitemizde mevcuttur.", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Keywords",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Keywords",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Keywords",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Keywords",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Keywords",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Keywords",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Keywords",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Keywords",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Keywords",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Keywords",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Keywords",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Keywords",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

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
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2021, 12, 28, 17, 34, 21, 554, DateTimeKind.Local).AddTicks(3299));
        }
    }
}
