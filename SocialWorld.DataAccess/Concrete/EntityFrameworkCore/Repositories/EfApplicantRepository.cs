using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SocialWorld.Business.DTOs.ApplicantDtos;
using SocialWorld.DataAccess.Concrete.EntityFrameworkCore.Context;
using SocialWorld.DataAccess.Interfaces;
using SocialWorld.Entities.Concrete;

namespace SocialWorld.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfApplicantRepository : EfGenericRepository<Applicant>, IApplicantDal
    {
        public async Task<List<ApplicantListDto>> GetAllApplicantDto()
        {
            using SocialWorldDbContext context = new();
            var result = from applicant in context.Applicants
                         join AppUser in context.AppUsers on applicant.UserId equals AppUser.Id
                         select new ApplicantListDto()
                         {
                             Id = applicant.Id,
                             Firstname = AppUser.FirstName,
                             LastName = AppUser.LastName,
                             ApplicationDate = applicant.ApplicationDate,
                             Email = AppUser.Email,
                             PhoneNumber = AppUser.PhoneNumber,
                             JobId = applicant.JobId
                         };
            return result.ToList();
        }

    }
}
