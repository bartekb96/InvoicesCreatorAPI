using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.DataModels.Enums;
using WebApplication.DataModels.Models;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    //[Route("Home")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly RestClientAbstract _restClient;

        public HomeController(ILogger<HomeController> logger)
        {
            _restClient = new RestClient();
        }

        public async Task<IActionResult> LogIn(User user)
        {
            UserResponse userResponse = null;

            string data = JsonConvert.SerializeObject(user);

            if (await this._restClient.SendRequest(HttpMethod.POST, "Users/LogIn", data))
            {
                userResponse = JsonConvert.DeserializeObject<UserResponse>(_restClient.responseString);
            }

            if (userResponse != null)
            {
                HttpContext.Session.SetString("username", userResponse.UserName);
            }

            return View("AddInvoice");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AddInvoice()
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
