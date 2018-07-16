using Microsoft.AspNetCore.Antiforgery;
using MyProj.Controllers;

namespace MyProj.Web.Host.Controllers
{
    public class AntiForgeryController : MyProjControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
