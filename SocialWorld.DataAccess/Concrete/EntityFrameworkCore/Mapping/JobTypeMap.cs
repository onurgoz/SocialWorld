using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialWorld.Entities.Concrete;

namespace SocialWorld.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class JobTypeMap : IEntityTypeConfiguration<JobType>
    {
        public void Configure(EntityTypeBuilder<JobType> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(X => X.Id).UseIdentityColumn();
            builder.HasMany(I => I.Jobs).WithOne(I => I.JobType).HasForeignKey(I => I.JobTypeId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
