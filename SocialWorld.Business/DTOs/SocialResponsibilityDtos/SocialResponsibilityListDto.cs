namespace SocialWorld.Business.DTOs.SocialResponsibilityDtos
{
    public class SocialResponsibilityListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public string PhotoString { get; set; }
        public int SocialResponsibilityTypeId { get; set; }
        public int CompanyId { get; set; }
        
    }
}