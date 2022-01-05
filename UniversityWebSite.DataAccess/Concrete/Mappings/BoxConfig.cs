using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.Entities.Concrete;

namespace UniversityWebSite.DataAccess.Concrete.Mappings
{
    public class BoxConfig : IEntityTypeConfiguration<Box>
    {
        public void Configure(EntityTypeBuilder<Box> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Header).IsRequired();
            builder.Property(x => x.Text).IsRequired();

            builder.HasOne(x => x.About).WithMany(x => x.Boxes).HasForeignKey(x => x.AboutId);
        }
    }
}
