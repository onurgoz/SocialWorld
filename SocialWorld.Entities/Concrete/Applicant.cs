using System;
using SocialWorld.Entities.Abstract;

namespace SocialWorld.Entities.Concrete
{
    public class Applicant : IEntity
    {
        public int Id { get; set; }
        public DateTime ApplicationDate { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        public AppUser AppUser { get; set; }

        public int JobId { get; set; }
        public Job Job { get; set; }
    }
}
