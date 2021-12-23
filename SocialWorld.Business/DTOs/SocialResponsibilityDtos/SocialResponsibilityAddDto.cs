using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialWorld.Business.DTOs.SocialResponsibilityDtos
{
    public class SocialResponsibilityAddDto
    {
        public string Name { get; set; }
        public string Explanation { get; set; }
        public string PhotoString { get; set; }
        public int SocialResponsibilityTypeId { get; set; }
        public int CompanyId { get; set; }
    }
}
