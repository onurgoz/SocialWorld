using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MernisVerification;
using Microsoft.AspNetCore.Authorization;
using SocialWorld.Business.Adapters;
using SocialWorld.Business.DTOs.AppUserDtos;
using SocialWorld.Business.Interfaces;
using SocialWorld.Entities.Concrete;

namespace SocialWorld.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IMapper _mapper;
        private readonly IJwtService _jwtService;
        public UserController(IJwtService jwtService, IMapper mapper, IAppUserService appUserService)
        {
            _appUserService = appUserService;
            _mapper = mapper;
            _jwtService = jwtService;
        }
        [HttpPut("[action]")]
        [Authorize(Roles = "Admin,Member")]
        public async Task<IActionResult> EditUser(AppUserDto appUserDto)
        {
            var updatedUser = await _appUserService.FindByIdAsync(appUserDto.Id);

            if (updatedUser != null)
            {
                updatedUser.FirstName = appUserDto.FirstName;
                updatedUser.LastName = appUserDto.LastName;
                updatedUser.Email = appUserDto.Email;
                updatedUser.NationalityId= appUserDto.NationalityId;
                updatedUser.DateOfBirth= appUserDto.DateOfBirth;
                

                await _appUserService.UpdateAsync(updatedUser);
                return NoContent();
            }
            else
            {
                return NotFound("Girilen id'ye ait herhangi bir değer bulunmamaktadır.");
            }
        }

        [HttpGet("[action]/{userId}")]
        [Authorize(Roles = "Admin,Member")]
        public async Task<IActionResult> GetUserDetails(int userId)
        {
            var user = await _appUserService.FindByIdAsync(userId);
            if (user != null)
            {
                AppUserDto userDto = new AppUserDto()
                {
                    Id = user.Id,
                    DateOfBirth = user.DateOfBirth,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    NationalityId = user.NationalityId,
                    Password = user.Password
                };
                return Ok(userDto);
            }
            return BadRequest("Kullanıcı Mevcut Değil");
        }

        [HttpGet("[action]/{userId}")]
        [Authorize(Roles = "Admin,Member")]
        public async Task<IActionResult> GetUserNationalityIdCheck(int userId)
        {
            var user = await _appUserService.FindByIdAsync(userId);
            var validation = _appUserService.IdentificationNumberCheck(user);
            if (user != null&&validation.Result)
            {
                user.IsValid = true;
                return Ok("Kimliğiniz Onaylandı.");
            }
            return BadRequest("Kullanıcı Bilgileri Doğru Değil");
        }
    }
}
