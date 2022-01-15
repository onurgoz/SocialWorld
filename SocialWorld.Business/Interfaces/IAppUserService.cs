using SocialWorld.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialWorld.Business.Interfaces
{
    public interface IAppUserService : IGenericService<AppUser> ,IUserIdentificationNumberCheck
    {
        Task<AppUser> FindByEmail(string email);
        Task<List<AppRole>> GetRolesByEmail(string email);
    }
}
