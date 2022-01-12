using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using SocialWorld.Entities.Abstract;

namespace SocialWorld.Entities.Concrete
{
    public class Job : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AddedTime { get; set; } = DateTime.Now;
        public DateTime LastEdit { get; set; } = DateTime.Now;
        public string  Explanation { get; set; }
        public string PhotoString { get; set; }
        public bool IsActive { get; set; } = true;
        public int JobTypeId { get; set; }
        public JobType JobType { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        [ForeignKey("AppUser")]
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public List<Applicant> Applicants { get; set; }
    }
}
