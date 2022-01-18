using SocialWorld.Business.Interfaces;
using SocialWorld.DataAccess.Interfaces;
using SocialWorld.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialWorld.Business.Concrete
{
    public class CompanyManager : GenericManager<Company>, ICompanyService
    {
        private readonly IGenericDal<Company> _genericDal;
        public CompanyManager(IGenericDal<Company> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<List<Company>> GetByAppUserIdAsync(int appUserId)
        {
            return await _genericDal.GetAllByFilter(I => I.AppUserId == appUserId && I.IsActive==true);
        }
        public async Task<List<Company>> GetAllCompanyByCompanyTypeId(int id)
        {
            return await _genericDal.GetAllByFilter(I => I.IsActive == true && I.CompanyTypeId == id);
        }

        public async Task<List<Company>> GetAllCompanyByExceptThisCompanyTypeId(int id)
        {
            return await _genericDal.GetAllByFilter(I => I.IsActive == true && I.CompanyTypeId != id);
        }
    }
}
