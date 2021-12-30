using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.Entities.Concrete;
using UniversityWebSite.Entities.Enums;

namespace UniversityWebSite.DataAccess.Concrete.Initializer
{
    public static class DataInitializer
    {
        // Seed Data is loading as soon as when the project starts

        public static void Seed(ModelBuilder modelBuilder)
        {
            // Admin
            modelBuilder.Entity<Admin>().HasData(new Admin() { Id = 1, Username = "admin", Password = "123456a" });

            // Categories
            modelBuilder.Entity<Category>().HasData(
                // University
                new Category() { Id = 1, CreatedTime= DateTime.Now, NavBarHeader = NavBarHeader.University, Name = "Düzce" },
                new Category() { Id = 2, CreatedTime= DateTime.Now, NavBarHeader = NavBarHeader.University, Name = "Kuruluş" },
                new Category() { Id = 3, CreatedTime= DateTime.Now, NavBarHeader = NavBarHeader.University, Name = "Yönetim" },
                new Category() { Id = 4, CreatedTime= DateTime.Now, NavBarHeader = NavBarHeader.University, Name = "Sayılarla DÜ" },
                new Category() { Id = 5, CreatedTime= DateTime.Now, NavBarHeader = NavBarHeader.University, Name = "Sıralamalar" },
                new Category() { Id = 6, CreatedTime= DateTime.Now, NavBarHeader = NavBarHeader.University, Name = "İlkler" },
                new Category() { Id = 7, CreatedTime= DateTime.Now, NavBarHeader = NavBarHeader.University, Name = "Kurumsal Strateji" },
                new Category() { Id = 8, CreatedTime= DateTime.Now, NavBarHeader = NavBarHeader.University, Name = "İdari Birimler" },

                // Academic
                new Category() { Id = 9, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.Academic, Name = "Fakülteler" },
                new Category() { Id = 10, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.Academic, Name = "Enstitüler" },
                new Category() { Id = 11, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.Academic, Name = "Yüksekokullar" },
                new Category() { Id = 12, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.Academic, Name = "Meslek Yüksekokulları" },
                new Category() { Id = 13, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.Academic, Name = "Kurullar" },
                new Category() { Id = 14, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.Academic, Name = "Bölüm Başkanlıkları" },

                // Research
                new Category() { Id = 15, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.Research, Name = "Araştırma Merkezleri" },
                new Category() { Id = 16, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.Research, Name = "Laboratuvar Envanteri" },
                new Category() { Id = 17, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.Research, Name = "Yayınlar/Projeler" },
                new Category() { Id = 18, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.Research, Name = "Hakemli Dergiler" },
                new Category() { Id = 19, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.Research, Name = "Teknoloji Transfer Ofisi" },

                // Specialization
                new Category() { Id = 20, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.Specialization, Name = "Tıbbi Bitki Yetiştiriciliği" },
                new Category() { Id = 21, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.Specialization, Name = "Ürünler/Markalar" },
                new Category() { Id = 22, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.Specialization, Name = "Üretim Merkezi" },
                new Category() { Id = 23, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.Specialization, Name = "Bilimsel Yayınlar" },
                new Category() { Id = 24, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.Specialization, Name = "İşbirlikleri" },
                new Category() { Id = 25, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.Specialization, Name = "Etkinlikler" },

                // FastAccess
                new Category() { Id = 26, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.FastAccess, Name = "E-Posta" },
                new Category() { Id = 27, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.FastAccess, Name = "EBYS" },
                new Category() { Id = 28, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.FastAccess, Name = "ÖBS/KYBS" },
                new Category() { Id = 29, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.FastAccess, Name = "UZEM" },
                new Category() { Id = 30, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.FastAccess, Name = "Kütüphane" },
                new Category() { Id = 31, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.FastAccess, Name = "Rehber" },
                new Category() { Id = 32, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.FastAccess, Name = "PBS" },
                new Category() { Id = 33, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.FastAccess, Name = "Staj" },
                new Category() { Id = 34, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.FastAccess, Name = "Havuz" },
                new Category() { Id = 35, CreatedTime = DateTime.Now, NavBarHeader = NavBarHeader.FastAccess, Name = "Yemek Menüsü" }
            );

            // Subtitles
            modelBuilder.Entity<Subtitle>().HasData(
                // University
                new Subtitle() { Id = 1, CreatedTime = DateTime.Now, Name = "Rektör", CategoryId = 3 },
                new Subtitle() { Id = 2, CreatedTime = DateTime.Now, Name = "Rektör Yardımcıları", CategoryId = 3 },
                new Subtitle() { Id = 3, CreatedTime = DateTime.Now, Name = "Senato", CategoryId = 3 },
                new Subtitle() { Id = 4, CreatedTime = DateTime.Now, Name = "Yönetim Kurulu", CategoryId = 3 },

                new Subtitle() { Id = 5, CreatedTime = DateTime.Now, Name = "Öğrenci Sayıları", CategoryId = 4 },
                new Subtitle() { Id = 6, CreatedTime = DateTime.Now, Name = "Personel Sayıları", CategoryId = 4 },
                new Subtitle() { Id = 7, CreatedTime = DateTime.Now, Name = "Proje Sayıları", CategoryId = 4 },
                new Subtitle() { Id = 8, CreatedTime = DateTime.Now, Name = "Fikri Mülkiyet", CategoryId = 4 },

                new Subtitle() { Id = 9, CreatedTime = DateTime.Now, Name = "URAP", CategoryId = 5 },
                new Subtitle() { Id = 10, CreatedTime = DateTime.Now, Name = "THE", CategoryId = 5 },
                new Subtitle() { Id = 11, CreatedTime = DateTime.Now, Name = "Green Metric", CategoryId = 5 },
                new Subtitle() { Id = 12, CreatedTime = DateTime.Now, Name = "InnovaLig", CategoryId = 5 },

                new Subtitle() { Id = 13, CreatedTime = DateTime.Now, Name = "Stratejik Plan", CategoryId = 7 },
                new Subtitle() { Id = 14, CreatedTime = DateTime.Now, Name = "Kalite Politikası", CategoryId = 7 },
                new Subtitle() { Id = 15, CreatedTime = DateTime.Now, Name = "Sürekli İyileştirme", CategoryId = 7 },
                new Subtitle() { Id = 16, CreatedTime = DateTime.Now, Name = "Sürdürülebilirlik Raporu", CategoryId = 7 },

            
                // Academic
                new Subtitle() { Id = 17, CreatedTime = DateTime.Now, Name = "Eğitim Fakültesi", CategoryId = 9 },
                new Subtitle() { Id = 18, CreatedTime = DateTime.Now, Name = "Mühendislik Fakültesi", CategoryId = 9 },
                new Subtitle() { Id = 19, CreatedTime = DateTime.Now, Name = "Tıp Fakültesi", CategoryId = 9 },
                new Subtitle() { Id = 20, CreatedTime = DateTime.Now, Name = "Fen Edebiyat Fakültesi", CategoryId = 9 },

                new Subtitle() { Id = 21, CreatedTime = DateTime.Now, Name = "Güzel Sanatlar Enstitüsü", CategoryId = 10 },
                new Subtitle() { Id = 22, CreatedTime = DateTime.Now, Name = "Fen Bilimleri Enstitüsü", CategoryId = 10 },
                new Subtitle() { Id = 23, CreatedTime = DateTime.Now, Name = "Sağlık Bilimleri Enstitüsü", CategoryId = 10 },
                new Subtitle() { Id = 24, CreatedTime = DateTime.Now, Name = "Sosyal Bilimler Enstitüsü", CategoryId = 10 },

                new Subtitle() { Id = 25, CreatedTime = DateTime.Now, Name = "Akçakoca Turizm İşletme", CategoryId = 11 },
                new Subtitle() { Id = 26, CreatedTime = DateTime.Now, Name = "Hakime Erciyas Yabancı Diller", CategoryId = 11 },

                new Subtitle() { Id = 27, CreatedTime = DateTime.Now, Name = "Akçakoca MYO", CategoryId = 12 },
                new Subtitle() { Id = 28, CreatedTime = DateTime.Now, Name = "Çilimli MYO", CategoryId = 12 },
                new Subtitle() { Id = 29, CreatedTime = DateTime.Now, Name = "Düzce MYO", CategoryId = 12 },
                new Subtitle() { Id = 30, CreatedTime = DateTime.Now, Name = "Gölyaka MYO", CategoryId = 12 },

                new Subtitle() { Id = 31, CreatedTime = DateTime.Now, Name = "Atatürk İlkeleri ve İnkılap Tarihi", CategoryId = 14 },
                new Subtitle() { Id = 32, CreatedTime = DateTime.Now, Name = "Türk Dili", CategoryId = 14 }
            );

            // Keyword
            modelBuilder.Entity<Keyword>().HasData(
                new Keyword() { Id = 1, CreatedTime = DateTime.Now, Title = "Mühendislik" },
                new Keyword() { Id = 2, CreatedTime = DateTime.Now, Title = "Tıp" },
                new Keyword() { Id = 3, CreatedTime = DateTime.Now, Title = "Ziraat" },
                new Keyword() { Id = 4, CreatedTime = DateTime.Now, Title = "Eğitim" },
                new Keyword() { Id = 5, CreatedTime = DateTime.Now, Title = "Fen Edebiyat" },
                new Keyword() { Id = 6, CreatedTime = DateTime.Now, Title = "Mimarlık" },
                new Keyword() { Id = 7, CreatedTime = DateTime.Now, Title = "İşletme" },
                new Keyword() { Id = 8, CreatedTime = DateTime.Now, Title = "Orman" },
                new Keyword() { Id = 9, CreatedTime = DateTime.Now, Title = "Sağlık Bilimleri" },
                new Keyword() { Id = 10, CreatedTime = DateTime.Now, Title = "Spor Bilimleri" },
                new Keyword() { Id = 11, CreatedTime = DateTime.Now, Title = "Eğitim" },
                new Keyword() { Id = 12, CreatedTime = DateTime.Now, Title = "Siyasal Bilgiler" }
            );

            // Contact
            modelBuilder.Entity<Contact>().HasData(
                new Contact() { Id = 1, CreatedTime = DateTime.Now, Email = "du@edu.tr", Fax = "+90 (380) 5421103", Phone = "+90 850 800 8181" }
            );

            // Statistic
            modelBuilder.Entity<Statistic>().HasData(
                new Statistic() { Id = 1, CreatedTime = DateTime.Now, NumberOfFaculty = 12, NumberOfTeacher = 1275, NumberOfStudent = 17592, NumberOfProject = 1231 }
            );

            // About
            modelBuilder.Entity<About>().HasData(
                new About() { Id = 1, CreatedTime = DateTime.Now, Paragraph = "Üniversitemizde öğrencilerimizin istedikleri alanda özelleşmelerine olanak sağlayan geniş yelpazeli seçmeli ders seçenekleri sunulmaktadır. Dileyen öğrencilerimiz diğer bölüm programlarıyla yandal ve çift anadal eğitimi alabilme imkânına sahiptir. Öğrencilerimize ilaveten Erasmus Öğrenci Değişim Programı kapsamında yurt dışında anlaşmalı olduğumuz üniversitelerde burslu eğitim alma imkânı da sağlanmaktadır. Bu program dahilinde öğrencilerimiz eğitimlerine bir veya iki dönem Avrupa’da devam edebilmektedirler." }
            );

            // Boxes
            modelBuilder.Entity<Box>().HasData(
                new Box() { Id = 1, CreatedTime = DateTime.Now, Header = "Nitelikli akademik kadro", Text = "Mesleki bilgileri kazanım için bir bölümdeki en önemli unsur öğretim kadrosudur.", AboutId = 1 },
                new Box() { Id = 2, CreatedTime = DateTime.Now, Header = "Güncel eğitim programı ve ders içerikleri", Text = "Dünyadaki eğilime uygun olarak bir endüstri mühendisine kazandırılması gereken yetkinlikler dikkate alınarak eğitim programı tasarlanmıştır.", AboutId = 1 },
                new Box() { Id = 3, CreatedTime = DateTime.Now, Header = "Öğrencinin sosyal, kültürel ve spor faaliyetleri", Text = "Kampüsümüzde devlet tiyatrosu mevcut olup burada tiyatro ve sanatsal etkinlikler düzenlenmektedir. Yine olimpik yüzme havuzunu, dans salonlarını, kapalı spor salonunu, tekno fitness salonunu içeren Türkiye’nin en büyük kapalı spor merkezi üniversitemizde mevcuttur.", AboutId = 1 }
            );

            // Pictures
            modelBuilder.Entity<Picture>().HasData(
                new Picture() { Id = 1, CreatedTime = DateTime.Now, Url = "https://studyinturkey.net/wp-content/uploads/2021/01/duzce-universitesi-kampus.jpg" },
                new Picture() { Id = 2, CreatedTime = DateTime.Now, Url = "https://static.daktilo.com/sites/622/uploads/2021/06/07/whatsapp-image-2021-06-07-at-164152-1.jpeg" },
                new Picture() { Id = 3, CreatedTime = DateTime.Now, Url = "https://pbs.twimg.com/media/FDa851KWUAEoNpt?format=jpg&name=large" }
            );

            // Videos
            modelBuilder.Entity<Video>().HasData(
                new Video() { Id = 1, CreatedTime = DateTime.Now, Title = "DÜ Tanıtım Filmi 2021", Url = "mSS-tfXDrT4" },
                new Video() { Id = 2, CreatedTime = DateTime.Now, Title = "DÜ Tanıtım Filmi 2018", Url = "-myyQEpicLY" },
                new Video() { Id = 3, CreatedTime = DateTime.Now, Title = "DÜ 15. Yıl Özel Belgeseli", Url = "z2hqyvV6Me0" }
            );
        }
    }
}
