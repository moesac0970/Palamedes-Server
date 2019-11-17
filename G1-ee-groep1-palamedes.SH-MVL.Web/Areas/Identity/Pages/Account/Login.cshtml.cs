using G1_ee_groep1_palamedes.SH_MVL.Web.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly IEmailSender _emailSender;
        private PasswordHasher<IdentityUser> _passwordHasher;
        public LoginModel(
            SignInManager<IdentityUser> signInManager,
            ILogger<LoginModel> logger,
            UserManager<IdentityUser> userManager,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _logger = logger;
            _passwordHasher = new PasswordHasher<IdentityUser>();
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            HttpClient client = new HttpClient();
            returnUrl = returnUrl ?? Url.Content("~/");
            var uri = "http://localhost:5000";

            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };

                // if can signin user 
                var signIn = await _signInManager.CanSignInAsync(user);
                if (signIn)
                {
                    var webRequest = WebRequest.Create(uri + "/auth/token");
                    webRequest.Headers["Authorization"] = "Basic "
                                                        + Convert.ToBase64String(Encoding.Default.GetBytes(Input.Email
                                                        ));
                    webRequest.Method = "POST";

                    // repsons from auth controller containing the bearer token 
                    var respons = await webRequest.GetResponseAsync();
                    var responsstream = respons.GetResponseStream();
                    var reader = new StreamReader(responsstream);
                    var bearerToken = reader.ReadToEnd();
                    if(bearerToken != "not valid user")
                    {
                        // set cookieoptions, and save cookie on client, and signin user with the signinmanager
                        // todo domain date on cookie from the beaertoken
                        var cookieOptions = new CookieOptions
                        {
                            Expires = DateTimeOffset.Now.AddDays(1).AddMinutes(-5),
                            HttpOnly = false,
                            Secure = true
                        };
                        HttpContext.Response.Cookies.Append("bearerToken", bearerToken, cookieOptions);

                        //signin user with the signinManager
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        _logger.LogInformation("User logged in.");
                    }
                    else
                    {
                        return Page();
                    }

                    return LocalRedirect(returnUrl);
                }
                // this is to far returns page if didn't succeed
                return Page();
                
            }
            return Page();
        }

        public async Task<IActionResult> OnPostSendVerificationEmailAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.FindByEmailAsync(Input.Email);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Verification email sent. Please check your email.");
            }

            var userId = await _userManager.GetUserIdAsync(user);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var callbackUrl = Url.Page(
                "/Account/ConfirmEmail",
                pageHandler: null,
                values: new { userId = userId, code = code },
                protocol: Request.Scheme);
            await _emailSender.SendEmailAsync(
                Input.Email,
                "Confirm your email",
                $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

            ModelState.AddModelError(string.Empty, "Verification email sent. Please check your email.");
            return Page();
        }
    }
}
