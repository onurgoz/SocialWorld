using Microsoft.EntityFrameworkCore;
using SocialWorld.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using SocialWorld.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialWorld.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class SocialWorldDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
	        optionsBuilder.UseSqlServer("Server=DESKTOP-2BJFEU7; Database=SocialWorld;uid=sa;pwd=1234;");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApplicantMap());
            modelBuilder.ApplyConfiguration(new AppRoleMap());
            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new AppUserRoleMap());
            modelBuilder.ApplyConfiguration(new CompanyMap());
            modelBuilder.ApplyConfiguration(new JobMap());
            modelBuilder.ApplyConfiguration(new JobTypeMap());
            modelBuilder.ApplyConfiguration(new SocialResponsibilityMap());
            modelBuilder.ApplyConfiguration(new SocialResposibiltiyTypeMap());
        }

        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserRole> AppUserRoles { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobType> JobTypes { get; set; }

        public DbSet<SocialResponsibility> SocialResponsibilities { get; set; }
        public DbSet<SocialResponsibilityType> SocialResponsibilityTypes { get; set; }


    }
}
