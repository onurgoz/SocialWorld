using SocialWorld.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;
using SocialWorld.Business.DTOs.ApplicantDtos;

namespace SocialWorld.Business.Interfaces
{
    public interface IApplicantService : IGenericService<Applicant>
    {
        Task<List<Applicant>> GetAllApplicantsByJobId(int id);
        Task<List<Applicant>> GetUserApplications(int id);
        Task<List<ApplicantListDto>> GetAllApplicantDto();

    }

}
