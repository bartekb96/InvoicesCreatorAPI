using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.DataModels.Enums;
using WebApplication.DataModels.Models;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace WebApplication.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly RestClientAbstract _restClient;
        public InvoiceController()
        {
            _restClient = new RestClient();
        }

        public async Task<IActionResult> CreateInvoice(Invoice invoice)
        {
            try
            {
                var sessionUserID = HttpContext.Session.Get("userId");
                var sessionUserIDAsString = Encoding.Default.GetString(sessionUserID);
                var userId = Int32.Parse(sessionUserIDAsString);
                invoice.UserID = userId;
            }
            catch(Exception ex)
            {

            }

            InvoiceResponse invoiceResponse = null;

            string data = JsonConvert.SerializeObject(invoice);

            if (await this._restClient.SendRequest(HttpMethod.POST, "Invoices/CreateInvoice", data))
            {
                invoiceResponse = JsonConvert.DeserializeObject<InvoiceResponse>(_restClient.responseString);
            }

            return View("Views/Home/AddInvoice");
        }
    }
}
