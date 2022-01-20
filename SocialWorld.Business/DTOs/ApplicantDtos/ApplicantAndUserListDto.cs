using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialWorld.Business.DTOs.ApplicantDtos
{
    public class ApplicantAndUserListDto
    {
        public int Id { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int JobId { get; set; }
    }
}
