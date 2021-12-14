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
    public class SocialResponsibilityManager:GenericManager<SocialResponsibility>,ISocialResponsibilityService
    {
        private readonly ISocialResponsibilityDal _socialResponsibilityDal;
        public SocialResponsibilityManager(ISocialResponsibilityDal socialResponsibilityDal) : base(socialResponsibilityDal)
        {
            _socialResponsibilityDal = socialResponsibilityDal;
        }

        public async Task<List<SocialResponsibility>> GetAllActiveSocialResponsibilitiesAsync()
        {
            return await _socialResponsibilityDal.GetAllByFilter(I => I.isActive == true && I.Company.isActive == true);
        }

        public async Task<List<SocialResponsibility>> GetAllSocialResponsibilitiesCompanyId(int companyId)
        {
            return await _socialResponsibilityDal.GetAllByFilter(I =>
                I.isActive == true & I.Company.isActive == true && I.CompanyId == companyId);
        }
    }
}
