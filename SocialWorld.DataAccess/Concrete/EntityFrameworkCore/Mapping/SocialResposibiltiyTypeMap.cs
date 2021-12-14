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
    public class SocialResposibiltiyTypeMap : IEntityTypeConfiguration<SocialResponsibilityType>
    {
    public void Configure(EntityTypeBuilder<SocialResponsibilityType> builder)
    {
        builder.HasKey(I => I.Id);
        builder.Property(X => X.Id).UseIdentityColumn();

        builder.HasMany(I => I.SocialResponsibilities).WithOne(I => I.SocialResponsibilityType).HasForeignKey(I => I.JobTypeId).OnDelete(DeleteBehavior.NoAction);
    }
    }
}
