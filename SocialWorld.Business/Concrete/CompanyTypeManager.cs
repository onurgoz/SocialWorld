using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialWorld.Business.Interfaces;
using SocialWorld.DataAccess.Interfaces;
using SocialWorld.Entities.Concrete;

namespace SocialWorld.Business.Concrete
{
    public class CompanyTypeManager:GenericManager<CompanyType>,ICompanyTypeService
    {
        
        public CompanyTypeManager(IGenericDal<CompanyType> genericDal) : base(genericDal)
        {
            
        }
    }
}
