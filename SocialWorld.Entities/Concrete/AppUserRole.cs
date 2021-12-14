using System;
using System.Collections.Generic;
using System.Text;
using SocialWorld.Entities.Abstract;

namespace SocialWorld.Entities.Concrete
{
    public class AppUserRole : Entity
    {
        public int Id { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int AppRoleId { get; set; }
        public AppRole AppRole { get; set; }

    }
}
