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
    public class StatisticConfig : IEntityTypeConfiguration<Statistic>
    {
        public void Configure(EntityTypeBuilder<Statistic> builder)
        {
            builder.Property(x => x.NumberOfFaculty).IsRequired();
            builder.Property(x => x.NumberOfProject).IsRequired();
            builder.Property(x => x.NumberOfStudent).IsRequired();
            builder.Property(x => x.NumberOfTeacher).IsRequired();
        }
    }
}
