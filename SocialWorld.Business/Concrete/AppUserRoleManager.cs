using SocialWorld.Business.Interfaces;
using SocialWorld.DataAccess.Interfaces;
using SocialWorld.Entities.Concrete;

namespace SocialWorld.Business.Concrete
{
    public class AppUserRoleManager : GenericManager<AppUserRole>,  IAppUserRoleService
    {
        public AppUserRoleManager(IGenericDal<AppUserRole> genericDal) : base(genericDal)
        {
        }
    }
}
