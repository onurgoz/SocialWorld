using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialWorld.Entities.Abstract;

namespace SocialWorld.Entities.Concrete
{
    public class SocialResponsibilityType : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        
        public List<SocialResponsibility> SocialResponsibilities { get; set; }
    }
}
