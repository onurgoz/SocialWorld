using SocialWorld.Entities.Abstract;

namespace SocialWorld.Business.DTOs.ApplicantDtos
{
    public class AddApplicantDto:IDto
    {
        public int UserId { get; set; }
        public int JobId { get; set; }
    }
}
