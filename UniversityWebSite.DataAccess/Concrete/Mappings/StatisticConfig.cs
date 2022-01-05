using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversityWebSite.Entities.Concrete;

namespace UniversityWebSite.DataAccess.Concrete.Mappings
{
    public class StatisticConfig : IEntityTypeConfiguration<Statistic>
    {
        public void Configure(EntityTypeBuilder<Statistic> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.NumberOfFaculty).IsRequired();
            builder.Property(x => x.NumberOfProject).IsRequired();
            builder.Property(x => x.NumberOfStudent).IsRequired();
            builder.Property(x => x.NumberOfTeacher).IsRequired();
        }
    }
}
