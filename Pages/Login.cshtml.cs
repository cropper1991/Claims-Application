using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Claims_Application.Structures;

namespace Claims_Application.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(ILogger<LoginModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnPost()
        {
            Account account = Claims_Application.Database.DatabaseHandler.RetrieveAccountByUsername(Request.Form["Username"], _logger); //Retrieve Account by Username

            if (account.UserID > 0)
            { //Located User
                if (account.Active) //Check if User Account Active
                {
                    if (account.Password == Request.Form["Password"])
                    {
                        TempData["CurrentUser"] = account.DisplayName;
                        TempData["UserID"] = account.UserID;
                        return RedirectToPage("/LossView"); //Perform Redirection to LossView 
                    }
                    else
                    { //Password Incorrect - Provide Error Message
                        ModelState.AddModelError("Password", "Incorrect password provided");
                    }
                }
                else
                { //Inactive Account - Provide Error Message
                    ModelState.AddModelError("Username", "In-active user account specified");
                }
            }
            else
            { //User not located - Provide Error Message
                ModelState.AddModelError("Username", "Incorrect username provided");
            }

            return Page(); //Return Page
        }
    }
}
