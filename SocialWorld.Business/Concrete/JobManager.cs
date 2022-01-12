using SocialWorld.Business.Interfaces;
using SocialWorld.DataAccess.Interfaces;
using SocialWorld.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialWorld.Business.Concrete
{
    public class JobManager : GenericManager<Job>, IJobService
    {
        private readonly IGenericDal<Job> _genericDal;
        public JobManager(IGenericDal<Job> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<List<Job>> GetAllActiveJobsAsync()
        {
            return await _genericDal.GetAllByFilter(I => I.IsActive == true && I.Company.IsActive==true);
        }

        public async Task<List<Job>> GetAllJobsByCompanyId(int id)
        {
            return await _genericDal.GetAllByFilter(I => I.IsActive == true && I.CompanyId==id);
        }

        public async Task<List<Job>> GetAllJobsByJobTypeId(int id)
        {
            return await _genericDal.GetAllByFilter(I => I.IsActive == true && I.JobTypeId == id);
        }

    }
}
