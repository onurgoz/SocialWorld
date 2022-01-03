using SocialWorld.Business.Interfaces;
using SocialWorld.DataAccess.Interfaces;
using SocialWorld.Entities.Concrete;

namespace SocialWorld.Business.Concrete
{
    public class JobTypeManager : GenericManager<JobType>, IJobTypeService
    {
        public JobTypeManager(IGenericDal<JobType> genericDal) : base(genericDal)
        {
        }
    }
}
