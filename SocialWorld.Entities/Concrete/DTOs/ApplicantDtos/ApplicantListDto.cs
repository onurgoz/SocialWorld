using System;
using SocialWorld.Entities.Abstract;

namespace SocialWorld.Business.DTOs.ApplicantDtos
{
    public class ApplicantListDto: IDto
    {
        public int Id { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int JobId { get; set; }
    }
}
