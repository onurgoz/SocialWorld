using System.Collections.Generic;
using System.Threading.Tasks;
using SocialWorld.Business.DTOs.ApplicantDtos;
using SocialWorld.Entities.Concrete;

namespace SocialWorld.DataAccess.Interfaces
{
    public interface IApplicantDal : IGenericDal<Applicant>
    {
        public Task<List<ApplicantListDto>> GetAllApplicantDto();
    }
}
