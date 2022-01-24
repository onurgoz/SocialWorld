using SocialWorld.Entities.Abstract;

namespace SocialWorld.Business.DTOs.AppUserDtos
{
    public class AppUserLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
