using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialWorld.Entities.Abstract;

namespace SocialWorld.Business.DTOs.CompanyTypeDtos
{
    public class AddCompanyTypeDto : IDto
    {
        public string Name { get; set; }
    }
}
