using System;
using System.Collections.Generic;

namespace SocialWorld.Business.DTOs.AppUserDtos
{
    public class AppUserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
