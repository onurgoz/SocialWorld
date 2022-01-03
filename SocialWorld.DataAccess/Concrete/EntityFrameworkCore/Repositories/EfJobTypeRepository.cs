using SocialWorld.DataAccess.Interfaces;
using SocialWorld.Entities.Concrete;

namespace SocialWorld.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfJobTypeRepository : EfGenericRepository<JobType>, IJobTypeDal
    {
    }
}
