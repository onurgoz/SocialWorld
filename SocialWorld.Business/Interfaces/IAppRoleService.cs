using SocialWorld.Entities.Concrete;
using System.Threading.Tasks;

namespace SocialWorld.Business.Interfaces
{
    public interface IAppRoleService : IGenericService<AppRole>
    {
        Task<AppRole> FindByNameAsync(string name);
    }
}
