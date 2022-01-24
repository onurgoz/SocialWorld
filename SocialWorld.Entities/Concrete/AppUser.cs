using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using SocialWorld.Entities.Abstract;

namespace SocialWorld.Entities.Concrete
{
    public class AppUser : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string PhotoString { get; set; }
        public bool IsValid { get; set; } = false;
        public bool IsActive { get; set; } = true;

        public List<AppUserRole> AppUserRoles { get; set; }
        public List<Company> Companies { get; set; }
        public List<Job> Jobs { get; set; }
        public List<Applicant> Applicants { get; set; }
    }
}
