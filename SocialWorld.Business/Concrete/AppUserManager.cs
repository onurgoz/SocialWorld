using SocialWorld.Business.Interfaces;
using SocialWorld.DataAccess.Interfaces;
using SocialWorld.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialWorld.Business.Concrete
{
    public class AppUserManager : GenericManager<AppUser>, IAppUserService
    {
        private readonly IAppUserDal _appUserDal;
        private readonly IGenericDal<AppUser> _genericDal;
        private readonly IUserIdentificationNumberCheck _identificationNumberCheck;
        public AppUserManager(IAppUserDal appUserDal, IGenericDal<AppUser> genericDal,IUserIdentificationNumberCheck identificationNumberCheck) : base(genericDal)
        {
            _genericDal = genericDal;
            _appUserDal = appUserDal;
            _identificationNumberCheck = identificationNumberCheck;
        }

        public async Task<AppUser> FindByEmail(string email)
        {
            return await _genericDal.GetByFilter(I => I.Email == email);
        }

        public async Task<List<AppRole>> GetRolesByEmail(string email)
        {
            return await _appUserDal.GetRolesByEmail(email);
        }

        

        public async Task<bool> IdentificationNumberCheck(AppUser user)
        {
            if (await _identificationNumberCheck.IdentificationNumberCheck(user))
            {
                user.IsValid = true;
                await _appUserDal.UpdateAsync(user);
            }
            return await _identificationNumberCheck.IdentificationNumberCheck(user);

        }
    }
}
