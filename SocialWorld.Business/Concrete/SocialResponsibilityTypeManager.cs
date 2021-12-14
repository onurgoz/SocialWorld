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
    public class SocialResponsibilityTypeManager : GenericManager<SocialResponsibilityType>,ISocialResponsibilityTypeService
    {
        private readonly ISocialResponsibilityTypeDal _socialResponsibilityTypeDal;
        public SocialResponsibilityTypeManager(ISocialResponsibilityTypeDal socialResponsibilityTypeDal) : base(socialResponsibilityTypeDal)
        {
            _socialResponsibilityTypeDal = socialResponsibilityTypeDal;
        }
    }
}
