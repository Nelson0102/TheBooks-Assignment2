using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TheBooks.Pages
{
    // This is the Razor Page class for the "Privacy" page of "The Books" website.
    public class PrivacyModel : PageModel
    {
        // Private field to store an instance of the ILogger<PrivacyModel> for logging.
        private readonly ILogger<PrivacyModel> _logger;

        // Constructor with dependency injection of ILogger<PrivacyModel>.
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            // Initialize the _logger field with the injected ILogger instance.
            _logger = logger;
        }

        // This method is executed when the "Privacy" page is requested (HTTP GET).
        public void OnGet()
        {
            // This method is currently empty, as there is no specific logic to be executed for this page.
            // If there were any specific actions to be performed when the page is requested, they would be placed here.
            // In this case, it is left empty as there is no specific logic to be executed.
        }
    }
}
