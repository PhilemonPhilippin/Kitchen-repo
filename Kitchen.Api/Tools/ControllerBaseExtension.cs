using Microsoft.AspNetCore.Mvc;

namespace Kitchen.Api.Tools
{
    public static class ControllerBaseExtension
    {
        public static ObjectResult InternalErrorCustom(this ControllerBase controller)
        {
            return controller.StatusCode(500, "A problem occured while handling the request.");
        }
    }
}
