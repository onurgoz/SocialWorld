using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialWorld.Entities.Concrete;

namespace SocialWorld.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class SocialResponsibilityMap : IEntityTypeConfiguration<SocialResponsibility>
    {
        public void Configure(EntityTypeBuilder<SocialResponsibility> builder)
        {
            builder.HasKey(X => X.Id);
            builder.Property(X => X.Id).UseIdentityColumn();

            builder.Property(X => X.Name).HasMaxLength(100).IsRequired();

            builder.Property(x => x.Explanation).HasMaxLength(300).IsRequired();
            builder.Property(x => x.PhotoString).HasMaxLength(500);

            builder.HasMany(X => X.Applicants).WithOne(X => X.SocialResponsibility).HasForeignKey(X => X.JobId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
