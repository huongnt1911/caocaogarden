using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CaoCaoGarden.Controllers
{
    public class AuthenticationController : Controller
    {
        [Route("/authenticate")]

        public async Task<IActionResult> Authenticate([FromQuery] string user, [FromQuery] string pwd)
        {
            if (user == "admin" && pwd == "1234")
            {
                var userClaims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, user),
                    new Claim(ClaimTypes.Email, "admin@eshop.com"),
                    new Claim(ClaimTypes.HomePhone, "12345678")
                };

                var userIdentity = new ClaimsIdentity(userClaims, "CaoCao.CookieAuth");
                var userPrincipal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync("CaoCao.CookieAuth", userPrincipal);

            }
            return Redirect("/donhangchuathanhtoan");
        }

        [Route("/logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/donhangchuathanhtoan");
        }
    }
}



