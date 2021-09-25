using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Claims_Application.Structures;
using Claims_Application.Database;
using Microsoft.AspNetCore.Mvc;

namespace Claims_Application.Pages
{
    //Provides Model for the Loss Types View - Viewing of all Loss Types (providing logged in)
    public class LossViewModel : PageModel
    {
        private readonly ILogger<LoginModel> _logger;
        public string DisplayName; //Store current users Display Name
        public int UserID; //Store current users UserID
        public LossType[] LossTypes; //Store the Array of LossTypes retrieved from the Database

        public LossViewModel(ILogger<LoginModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            if (TempData.ContainsKey("CurrentUser") && TempData.ContainsKey("UserID")) //Values required provided
            {
                //Obtain User Details - Given by Login Form
                DisplayName = TempData["CurrentUser"].ToString();
                UserID = (int)TempData["UserID"];

                //Ensure Display Name and UserID Values Persist
                TempData.Keep("CurrentUser");
                TempData.Keep("UserID");

                LossTypes = DatabaseHandler.RetrieveLossTypes(_logger);
                return Page(); //Return Page Result
            }
            else //Assume not logged in - Redirect to Login
            {
                return RedirectToPage("/Login"); //Perform Redirection to Login Page
            }
        }
    }
}
