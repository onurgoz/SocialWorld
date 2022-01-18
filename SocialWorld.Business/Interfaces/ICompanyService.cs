using SocialWorld.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialWorld.Business.Interfaces
{
    public interface ICompanyService : IGenericService<Company>
    {
        Task<List<Company>> GetByAppUserIdAsync(int appUserId);
        public Task<List<Company>> GetAllCompanyByCompanyTypeId(int id);
        public Task<List<Company>> GetAllCompanyByExceptThisCompanyTypeId(int id);
    }
}
