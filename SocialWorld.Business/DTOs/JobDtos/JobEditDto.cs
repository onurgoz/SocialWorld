using System.Runtime.InteropServices.ComTypes;

namespace SocialWorld.Business.DTOs.JobDtos
{
    public class JobEditDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public string PhotoString { get; set; }
        public int JobTypeId { get; set; }
    }
}
