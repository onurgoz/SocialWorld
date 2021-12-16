using Microsoft.AspNetCore.Mvc;

namespace SocialWorld.Client.Infrastructure
{
    [Route("[controller]/[action]", Name = "[controller]_[action]")]
    public abstract class BaseController : Microsoft.AspNetCore.Mvc.Controller
    {
    }
}
