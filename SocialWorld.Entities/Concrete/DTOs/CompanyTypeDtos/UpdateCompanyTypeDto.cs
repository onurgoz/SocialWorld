using SocialWorld.Entities.Abstract;

namespace SocialWorld.Business.DTOs.CompanyTypeDtos
{
    public class UpdateCompanyTypeDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}