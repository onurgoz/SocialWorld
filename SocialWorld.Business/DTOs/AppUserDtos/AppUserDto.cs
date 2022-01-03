using System.Collections.Generic;

namespace SocialWorld.Business.DTOs.AppUserDtos
{
    public class AppUserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> Roles{ get; set; }
    }
}
