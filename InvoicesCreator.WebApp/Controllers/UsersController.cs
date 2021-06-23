using InvoicesCreator.WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesCreator.WebApp.Controllers
{
    [Route("user")]
    public class UsersController : Controller
    {
        private readonly RestClientAbstract _restClient;

        public UsersController()
        {
            _restClient = new RestClient();
        }

        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            string data = JsonConvert.SerializeObject(user);
            
            if(await this._restClient.SendRequest(Enums.HttpMethod.POST, "Users/LogIn", data))
            {
                var response = _restClient.responseString;
            }


            return View("Index");
        }
    }
}
