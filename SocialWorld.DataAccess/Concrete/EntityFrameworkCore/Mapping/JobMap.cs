using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialWorld.Entities.Concrete;

namespace SocialWorld.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class JobMap : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasKey(X => X.Id);
            builder.Property(X => X.Id).UseIdentityColumn();
            builder.Property(X => X.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Explanation).HasMaxLength(int.MaxValue).IsRequired();
            builder.Property(x => x.PhotoString).HasMaxLength(int.MaxValue);
            builder.HasMany(X => X.Applicants).WithOne(X => X.Job).HasForeignKey(X => X.JobId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
