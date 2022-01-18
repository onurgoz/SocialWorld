using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MernisVerification;
using SocialWorld.Business.Interfaces;
using SocialWorld.Entities.Concrete;

namespace SocialWorld.Business.Adapters
{
    public class MernisServiceAdapter:IUserIdentificationNumberCheck
    {
        public async Task<bool> IdentificationNumberCheck(AppUser user)
        {

            KPSPublicSoapClient client = new(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var result = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(user.NationalityId), user.FirstName.ToUpper(), user.LastName.ToUpper(), user.DateOfBirth.Year);
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
