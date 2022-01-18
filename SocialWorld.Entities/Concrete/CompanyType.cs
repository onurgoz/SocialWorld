using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialWorld.Entities.Abstract;

namespace SocialWorld.Entities.Concrete
{
    public class CompanyType:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Company> Companies { get; set; }
    }
}
