using SocialWorld.Business.Interfaces;
using SocialWorld.DataAccess.Interfaces;
using SocialWorld.Entities.Concrete;
using System.Threading.Tasks;

namespace SocialWorld.Business.Concrete
{
    public class AppRoleManager : GenericManager<AppRole>, IAppRoleService
    {
        private readonly IGenericDal<AppRole> _genericDal;
        public AppRoleManager(IGenericDal<AppRole> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<AppRole> FindByNameAsync(string name)
        {
            return await _genericDal.GetByFilter(I => I.Name == name);
        }

    }
}
