using SocialWorld.Business.Settings;
using SocialWorld.Entities.Concrete;
using System.Collections.Generic;

namespace SocialWorld.Business.Interfaces
{
    public interface IJwtService
    {
        JwtToken GenerateJwt(AppUser appUser, List<AppRole> roles);
    }
}
