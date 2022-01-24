using System;
using System.Collections.Generic;
using SocialWorld.Entities.Abstract;

namespace SocialWorld.Business.DTOs.AppUserDtos
{
    public class AppUserDto : IDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhotoString { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool IsValid { get; set; }
    }
}
