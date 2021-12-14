using System;
using System.Collections.Generic;
using System.Text;
using SocialWorld.Entities.Abstract;

namespace SocialWorld.Entities.Concrete
{
    public class Applicant : Entity
    {
        public int Id { get; set; }
        public DateTime ApplicationDate { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        public AppUser AppUser { get; set; }

        public int JobId { get; set; }
        public Job Job { get; set; }

        public SocialResponsibility SocialResponsibility { get; set; } 



    }
}
