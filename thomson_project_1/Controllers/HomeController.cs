using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using thomson_project_1.Models;
using Microsoft.Extensions.Logging;


namespace thomson_project_1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Gallery()
    {
        return View();
    }
    public IActionResult Mission() { return View(); }
    [HttpPost]
    public IActionResult SendContactEmail(ContactFormModel model)
    {
        if (ModelState.IsValid)
        {
            var subject = "New Contact Request";
            var body = $@"
            Name: {model.Name}
            Email: {model.Email}
            Address: {model.Address}
            Address 2: {model.Address2}
            Landmark: {model.Landmark}
            City: {model.City}
            State: {model.State}
            Zip: {model.Zip}
            Phone: {model.Phone}
            Message: {model.Message}
            Complaints: {model.Complaints}
            Enquiry: {model.Enquiry}
        ";

            // Call the email sender (see Step 4)
            SendEmail("mapalavarghese@gmail.com", subject, body); // Replace with your recipient email
            return RedirectToAction("ThankYou"); // Create a ThankYou.cshtml
        }

        return View("ContactUs", model); // show validation errors
    }
    private void SendEmail(string to, string subject, string body)
    {
        var smtpClient = new SmtpClient("smtp.gmail.com")
        {
            Port = 587,
            Credentials = new NetworkCredential("mapalavarghese@gmail.com", "tfdz kice tmey rryz"),
            EnableSsl = true,
        };

        var mailMessage = new MailMessage
        {
            From = new MailAddress("mapalavarghese@gmail.com"),
            Subject = subject,
            Body = body,
            IsBodyHtml = false,
        };
        mailMessage.To.Add(to);

        smtpClient.Send(mailMessage);
    }
    public IActionResult ContactUs() { return View(); }
    public IActionResult ThankYou()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
