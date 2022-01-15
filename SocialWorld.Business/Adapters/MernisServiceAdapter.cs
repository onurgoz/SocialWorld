using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SocialWorld.Business.Interfaces;
using SocialWorld.Entities.Concrete;

namespace SocialWorld.Business.Adapters
{
    public class MernisServiceAdapter:IUserIdentificationNumberCheck
    {
        public async Task<bool> IdentificationNumberCheck(AppUser user)
        {
            

            //KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            //return client.TCKimlikNoDogrulaAsync(
            //    new TCKimlikNoDogrulaRequest(
            //        new TCKimlikNoDogrulaRequestBody(TCKimlikNo: Convert.ToInt64(user.NationalityId), Ad: user.FirstName.ToUpper(),Soyad: user.LastName.ToUpper(),DogumYili: user.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
            return true;
        }
    }
}
