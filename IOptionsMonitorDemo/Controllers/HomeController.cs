using IOptionsMonitorDemo.Configurations;
using IOptionsMonitorDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace IOptionsMonitorDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOptionsMonitor<MailFeatureOptions> mailFeatureOptionsMonitor;

        public HomeController(ILogger<HomeController> logger, IOptionsMonitor<MailFeatureOptions> mailFeatureOptionsMonitor)
        {
            _logger = logger;
            this.mailFeatureOptionsMonitor = mailFeatureOptionsMonitor;
        }

        public IActionResult Index()
        {
            // Load in ViewData
            ViewData["IsEnabled"] = this.mailFeatureOptionsMonitor.CurrentValue.IsEnabled;
            ViewData["SmtpServer"] = this.mailFeatureOptionsMonitor.CurrentValue.SmtpServer;
            ViewData["FromEmailAddress"] = this.mailFeatureOptionsMonitor.CurrentValue.FromEmailAddress;
            ViewData["Subject"] = this.mailFeatureOptionsMonitor.CurrentValue.Subject;
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
}