using AutoMapper;
using SocialWorld.Business.DTOs.ApplicantDtos;
using SocialWorld.Business.DTOs.AppUserDtos;
using SocialWorld.Business.DTOs.CompanyDtos;
using SocialWorld.Business.DTOs.JobDtos;
using SocialWorld.Business.DTOs.JobTypeDtos;
using SocialWorld.Entities.Concrete;
using ApplicantListDto = SocialWorld.Business.DTOs.ApplicantDtos.ApplicantListDto;

namespace SocialWorld.WebApi.Mapping.AutoMapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            #region AppUser
            CreateMap<AppUserLoginDto, AppUser>();
            CreateMap<AppUser, AppUserLoginDto>();

            CreateMap<AppUserAddDto, AppUser>();
            CreateMap<AppUser, AppUserAddDto>();
            CreateMap<AppUserDto, AppUser>();
            CreateMap<AppUser, AppUserDto>();
            #endregion

            #region Company
            CreateMap<CompanyAddDto, Company>();
            CreateMap<Company, CompanyAddDto>();

            CreateMap<CompanyEditDto, Company>();
            CreateMap<Company, CompanyEditDto>();
            #endregion

            #region Job
            CreateMap<Job, JobAddDto>();
            CreateMap<JobAddDto, Job>();

            CreateMap<Job, JobListDto>();
            CreateMap<JobListDto, Job>();

            CreateMap<Job, JobEditDto>();
            CreateMap<JobEditDto, Job>();
            #endregion

            #region JobType

            CreateMap<JobType, AddJobTypeDto>();
            CreateMap<AddJobTypeDto,JobType>();
            CreateMap<JobType, UpdateJobTypeDto>();
            CreateMap<UpdateJobTypeDto,JobType>();

            #endregion

            #region Applicant
            CreateMap<Applicant, ApplicantListDto>();
            CreateMap<ApplicantListDto, Applicant>();

            CreateMap<Applicant, AddApplicantDto>();
            CreateMap<AddApplicantDto, Applicant>();
            #endregion

           
        }
    }
}
