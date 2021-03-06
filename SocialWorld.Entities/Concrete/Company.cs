using System.Collections.Generic;
using SocialWorld.Entities.Abstract;

namespace SocialWorld.Entities.Concrete
{
    public class Company : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Explanation { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PhotoString { get; set; }
        public string TaxNumber { get; set; }
        public bool IsActive { get; set; } = true;
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public List<Job> Jobs { get; set; }
        public int CompanyTypeId { get; set; }
        public CompanyType CompanyType { get; set; }
    }
}
