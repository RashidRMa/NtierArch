using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quizer.Models.Entities;

namespace Quizer.DataAccess.Configurations
{
    internal class QuestionSetConfiguration : IEntityTypeConfiguration<QuestionSet>
    {
        public void Configure(EntityTypeBuilder<QuestionSet> builder)
        {
            builder.Property(x=> x.Id).HasColumnType("uniqueidentifier");
            builder.Property(x => x.Subject).HasColumnType("nvarchar").HasMaxLength(500).IsRequired();


            builder.HasKey(x => x.Id);
            builder.ToTable("QuestionSets");


        }
    }
}
