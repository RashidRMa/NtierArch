using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quizer.Models.Entities;

namespace Quizer.DataAccess.Configurations
{
    internal class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(x => x.Id).HasColumnType("uniqueidentifier");
            builder.Property(x => x.Code).HasColumnType("nvarchar").HasMaxLength(7).IsRequired();
            builder.Property(x => x.QuestionSetId).HasColumnType("uniqueidentifier").IsRequired();
            builder.Property(x => x.CreatedDate).HasColumnType("datetime").IsRequired();


            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Code).IsUnique();
            builder.ToTable("Sessions");

            builder.HasOne<QuestionSet>()
                .WithMany()
                .HasForeignKey(x => x.QuestionSetId);


        }
    }
}
