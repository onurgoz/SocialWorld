using Microsoft.AspNetCore.Mvc.Filters;

namespace SocialWorld.Client.Infrastructure.ErrorHandling
{
    public abstract class ModelStateTransfer : ActionFilterAttribute
    {
        protected const string Key = nameof(ModelStateTransfer);
    }
}