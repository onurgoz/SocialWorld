using System;
using SocialWorld.Business.Interfaces;
using SocialWorld.Business.StringInfo;
using System.Threading.Tasks;

namespace SocialWorld.WebApi
{
    public static class JwtIdentityInitializer
    {
        public static async Task Seed(IAppUserService appUserService, IAppUserRoleService appUserRoleService, IAppRoleService appRoleService)
        {
            var adminRole = await appRoleService.FindByNameAsync(RoleInfo.Admin);
            if (adminRole == null)
            {
                await appRoleService.AddAsync(new Entities.Concrete.AppRole
                {
                    Name = RoleInfo.Admin
                });
            }

            var memberRole = await appRoleService.FindByNameAsync(RoleInfo.Member);
            if (memberRole == null)
            {
                await appRoleService.AddAsync(new Entities.Concrete.AppRole
                {
                    Name = RoleInfo.Member
                });
            }

            var adminUser = await appUserService.FindByEmail("admin@test.com");
            if (adminUser == null)
            {
                string password = BCrypt.Net.BCrypt.HashPassword("1");

                await appUserService.AddAsync(new Entities.Concrete.AppUser
                {
                    FirstName="Admin",
                    LastName = "Test",
                    NationalityId = "11111111111",
                    DateOfBirth = new DateTime(1998,07,10),
                    Password = password,
                    Email = "admin@test.com",
                  
                });
                

                var role = await appRoleService.FindByNameAsync(RoleInfo.Admin);
                var admin = await appUserService.FindByEmail("admin@test.com");

                await appUserRoleService.AddAsync(new Entities.Concrete.AppUserRole
                {
                    AppUserId = admin.Id,
                    AppRoleId = role.Id
                });
            }
        }
    }
}
