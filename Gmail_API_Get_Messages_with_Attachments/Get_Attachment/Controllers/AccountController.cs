namespace Get_Attachment.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Authentication;

    public class AccountController : Controller
    {
        [HttpGet]
        //[AllowAnonymous]
        //[Route("/localhost:44302/Google/GoogleResponse")]
        // public async Task LoginGoogle() => await HttpContext.ChallengeAsync("Google", new AuthenticationProperties() { RedirectUri = "/" });
        public IActionResult LoginGoogle(string returnUrl = "/") => Challenge(new AuthenticationProperties() { RedirectUri = returnUrl }, "Google");


        [HttpGet]
        [Authorize]
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}