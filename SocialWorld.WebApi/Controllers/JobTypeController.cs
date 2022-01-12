using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SocialWorld.Business.DTOs.JobTypeDtos;
using SocialWorld.Business.Interfaces;
using SocialWorld.Entities.Concrete;
using SocialWorld.WebApi.CustomFilters;
using System.Threading.Tasks;

namespace SocialWorld.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobTypeController : ControllerBase
    {
        private readonly IJobTypeService _jobTypeService;
        private readonly IMapper _mapper;
        public JobTypeController(IJobTypeService jobTypeService,IMapper mapper)
        {
            _jobTypeService = jobTypeService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Member")]
        public async Task<IActionResult> GetAllJobTypes()
        {
            return Ok(await _jobTypeService.GetAllAsync());
        }

        [HttpGet("{action}/{id}")]
        [Authorize(Roles = "Admin,Member")]
        public async Task<IActionResult> GetByIdJobType(int id)
        {
            var jobType = await _jobTypeService.FindByIdAsync(id);
            if (jobType != null)
            {
                return Ok(jobType);
            }
            return BadRequest("Id doğru değil");
        }

        [HttpPost("{action}")]
        [Authorize(Roles ="Admin")]
        [ValidModel]
        public async Task<IActionResult> AddJobType(AddJobTypeDto addJobTypeDto)
        {
            await _jobTypeService.AddAsync(_mapper.Map<JobType>(addJobTypeDto));
            return Created("", addJobTypeDto);
        }
        [HttpPut]
        [Authorize(Roles = "Admin")]
        [ValidModel]
        public async Task<IActionResult> UpdateJobType(UpdateJobTypeDto updateJobTypeDto)
        {
            await _jobTypeService.UpdateAsync(_mapper.Map<JobType>(updateJobTypeDto));
            return Created("", updateJobTypeDto);
        }

        [HttpDelete("{action}/{id}")]
        [Authorize(Roles = "Admin,Member")]
        [ValidModel]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            var jobType = await _jobTypeService.FindByIdAsync(id);
            if (jobType != null)
            {
                await _jobTypeService.UpdateAsync(jobType);
                return NoContent();
            }
            return BadRequest("Id doğru değil");
        }
    }
}
