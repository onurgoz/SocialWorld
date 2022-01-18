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
    public class CompanyTypeMap: IEntityTypeConfiguration<CompanyType>
    {
        public void Configure(EntityTypeBuilder<CompanyType> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(X => X.Id).UseIdentityColumn();
            builder.HasMany(I => I.Companies).WithOne(I => I.CompanyType).HasForeignKey(I => I.CompanyTypeId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
