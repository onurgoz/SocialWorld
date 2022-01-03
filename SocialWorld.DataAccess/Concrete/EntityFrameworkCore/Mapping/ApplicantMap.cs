using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialWorld.Entities.Concrete;

namespace SocialWorld.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class ApplicantMap : IEntityTypeConfiguration<Applicant>
    {
        public void Configure(EntityTypeBuilder<Applicant> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(X => X.Id).UseIdentityColumn();

            builder.HasIndex(I => new { I.JobId, I.UserId }).IsUnique();
        }
    }
}
