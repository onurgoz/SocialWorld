using System.Collections.Generic;
using SocialWorld.Entities.Abstract;

namespace SocialWorld.Entities.Concrete
{
    public class AppRole : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<AppUserRole> AppUserRoles { get; set; }

    }
}
