﻿using System;

namespace SocialWorld.Business.DTOs.ApplicantDtos
{
    public class ApplicantListDto
    {
        public int Id { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int UserId { get; set; }
        public int JobId { get; set; }
    }
}
