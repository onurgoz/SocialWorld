using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using SocialWorld.Business.DTOs.SocialResponsibilityDtos;
using SocialWorld.Business.Interfaces;
using SocialWorld.Entities.Concrete;
using SocialWorld.WebApi.CustomFilters;

namespace SocialWorld.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialResponsibilityController : Controller
    {
        private readonly ISocialResponsibilityService _socialResponsibilityService;
        private readonly IMapper _mapper;

        public SocialResponsibilityController(ISocialResponsibilityService socialResponsibilityService,IMapper mapper)
        {
            _socialResponsibilityService = socialResponsibilityService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Member,Company,City")]
        [ValidModel]
        public async Task<IActionResult> GetAllSocialResponsibilitiesAsync()
        {
            return Ok(_mapper.Map<List<SocialResponsibilityListDto>>(await _socialResponsibilityService
                .GetAllActiveSocialResponsibilitiesAsync()));
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,Member,Company,City")]
        [ValidModel]
        public async Task<IActionResult> GetSocialResponsibilityByIdAsync(int id)
        {
            return Ok(_mapper.Map<SocialResponsibilityListDto>(await _socialResponsibilityService.FindByIdAsync(id)));
        }

        [HttpGet("[action]/{id}")]
        [Authorize(Roles = "Admin,Member,Company,City")]
        [ValidModel]
        public async Task<IActionResult> GetSocialResponsibilityByCompanyIdAsync(int id)
        {
            return Ok(_mapper.Map<SocialResponsibilityListDto>(await _socialResponsibilityService
                .GetAllSocialResponsibilitiesCompanyId(id)));
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Member,Company,City")]
        [ValidModel]
        public async Task<IActionResult> AddAsync(SocialResponsibilityAddDto SocialResponsibilityAddDto)
        {
            await _socialResponsibilityService.AddAsync(_mapper.Map<SocialResponsibility>(SocialResponsibilityAddDto));
            return Created("", SocialResponsibilityAddDto);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin,Member,Company,City")]
        [ValidModel]
        public async Task<IActionResult> EditAsync(int id, SocialResponsibilityEditDto SocialResponsibilityEditDto)
        {
            if (id != SocialResponsibilityEditDto.Id)
            {
                return BadRequest("Invalid Id");
            }

            var SocialResponsibility = await _socialResponsibilityService.FindByIdAsync(SocialResponsibilityEditDto.Id);
            if (SocialResponsibility != null)
            {
                SocialResponsibility.Name = SocialResponsibilityEditDto.Name;
                SocialResponsibility.LastEdit = DateTime.Now;
                SocialResponsibility.PhotoString = SocialResponsibilityEditDto.PhotoString;
                SocialResponsibility.Explanation = SocialResponsibilityEditDto.Explanation;

                await _socialResponsibilityService.UpdateAsync(SocialResponsibility);
                return Ok();
            }
            return NotFound("Bu id'ye ait iş bulunmamaktadır.");
        }


        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin,Member,Company,City")]
        public async Task<IActionResult> DeleteSocialResponsibility(int id)
        {
            var SocialResponsibility = await _socialResponsibilityService.FindByIdAsync(id);

            if (SocialResponsibility != null)
            {
                SocialResponsibility.isActive = false;
                await _socialResponsibilityService.UpdateAsync(SocialResponsibility);
                return NoContent();
            }
            return NotFound("Girilen Id'ye ait bir değer yoktur.");
        }
    }
}
