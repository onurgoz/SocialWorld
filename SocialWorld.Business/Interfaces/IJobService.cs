using SocialWorld.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialWorld.Business.Interfaces
{
    public interface IJobService : IGenericService<Job>
    {
        Task<List<Job>> GetAllActiveJobsAsync();
        Task<List<Job>> GetAllJobsByCompanyId(int id);
    }
}
