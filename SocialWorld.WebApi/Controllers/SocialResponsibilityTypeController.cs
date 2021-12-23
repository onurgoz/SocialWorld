using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using SocialWorld.Business.DTOs.SocialResponsibilityTypeDtos;
using SocialWorld.Business.Interfaces;
using SocialWorld.Entities.Concrete;
using SocialWorld.WebApi.CustomFilters;

namespace SocialWorld.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialResponsibilityTypeController : Controller
    {
        private readonly ISocialResponsibilityTypeService _SocialResponsibilityTypeService;
        private readonly IMapper _mapper;
        public SocialResponsibilityTypeController(ISocialResponsibilityTypeService SocialResponsibilityTypeService, IMapper mapper)
        {
            _SocialResponsibilityTypeService = SocialResponsibilityTypeService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Member,Company,City")]
        public async Task<IActionResult> GetAllSocialResponsibilityTypes()
        {
            return Ok(await _SocialResponsibilityTypeService.GetAllAsync());
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidModel]
        public async Task<IActionResult> AddSocialResponsibilityType(SocialResponsibilityTypeAddDto socialResponsibilityTypeAddDto)
        {
            await _SocialResponsibilityTypeService.AddAsync(_mapper.Map<SocialResponsibilityType>(socialResponsibilityTypeAddDto));
            return Created("", socialResponsibilityTypeAddDto);
        }
    }
}
