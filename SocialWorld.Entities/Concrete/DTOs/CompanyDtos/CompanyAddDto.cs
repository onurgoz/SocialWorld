using SocialWorld.Entities.Abstract;

namespace SocialWorld.Business.DTOs.CompanyDtos
{
    public class CompanyAddDto : IDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Explanation { get; set; }
        public string TaxNumber { get; set; }
        public int AppUserId { get; set; }
        public string Email { get; set; }
        public int CompanyTypeId { get; set; }
        public string PhoneNumber { get; set; }
        public string PhotoString { get; set; }
    }
}
