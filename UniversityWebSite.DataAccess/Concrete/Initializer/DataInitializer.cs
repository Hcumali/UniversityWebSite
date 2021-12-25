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
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Admin
            modelBuilder.Entity<Admin>().HasData(new Admin() { Id = 1, Username = "admin", Password = "123456a" });

            // Category
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, NavBarHeader = NavBarHeader.University, Name = "Düzce" },
                new Category() { Id = 2, NavBarHeader = NavBarHeader.University, Name = "Kuruluş" },
                new Category() { Id = 3, NavBarHeader = NavBarHeader.University, Name = "Sayılarla DÜ"}
            );

            // Subtitle
            modelBuilder.Entity<Subtitle>().HasData(
                new Subtitle() { Id = 1, Name = "subtitle1", CategoryId = 2 },
                new Subtitle() { Id = 2, Name = "subtitle2", CategoryId = 2 }
            );
        }
    }
}
