using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialWorld.Entities.Concrete;

namespace SocialWorld.Business.Interfaces
{
    public interface IUserIdentificationNumberCheck
    {
        public Task<bool> IdentificationNumberCheck(AppUser user);
    }
}
