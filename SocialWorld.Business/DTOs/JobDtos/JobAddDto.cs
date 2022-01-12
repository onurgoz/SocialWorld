namespace SocialWorld.Business.DTOs.JobDtos
{
    public class JobAddDto
    {
        public string Name { get; set; }
        public string Explanation { get; set; }
        public string PhotoString { get; set; }
        public int JobTypeId { get; set; }
        public int CompanyId { get; set; }
        public int AppUserId { get; set; }
    }
}
