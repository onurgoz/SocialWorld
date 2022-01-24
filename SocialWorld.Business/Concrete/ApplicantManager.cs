using SocialWorld.Business.Interfaces;
using SocialWorld.DataAccess.Interfaces;
using SocialWorld.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;
using SocialWorld.Business.DTOs.ApplicantDtos;


namespace SocialWorld.Business.Concrete
{
    public class ApplicantManager : GenericManager<Applicant>, IApplicantService
    {
        private readonly IGenericDal<Applicant> _genericDal;
        private readonly IApplicantDal _applicantDal;
        public ApplicantManager(IGenericDal<Applicant> genericDal,IApplicantDal applicantDal) : base(genericDal)
        {
            _genericDal = genericDal;
            _applicantDal = applicantDal;
        }


        public async Task<List<Applicant>> GetAllApplicantsByJobId(int id)
        {
            return await _genericDal.GetAllByFilter(I => I.JobId == id);
        }

        public async Task<List<ApplicantListDto>> GetAllApplicantDto()
        {

            return await _applicantDal.GetAllApplicantDto();
        }

        public async Task<List<Applicant>> GetUserApplications(int id)
        {
            return await _genericDal.GetAllByFilter(I => I.UserId == id);
        }
       
    }
}
