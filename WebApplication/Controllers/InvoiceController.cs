using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.DataModels.Models;

namespace WebApplication.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly RestClientAbstract _restClient;
        public InvoiceController()
        {
            _restClient = new RestClient();
        }

        public IActionResult CreateInvoice(Invoice invoice)
        {
            return View();
        }
    }
}
