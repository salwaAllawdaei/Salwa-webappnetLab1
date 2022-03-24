using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Salwa_webappnetLab1.Pages;

public class ContactModel : PageModel
{
    public string Message { get; private set; } = "Message!";
    private readonly ILogger<ContactModel> _logger;

    public ContactModel(ILogger<ContactModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Message += $" the time is {DateTime.Now}";
    }
}

