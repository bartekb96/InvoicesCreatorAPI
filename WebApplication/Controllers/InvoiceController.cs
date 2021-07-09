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
using WebApplication.Extentions;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly RestClientAbstract _restClient;
        private readonly IHostingEnvironment _hostingEnvitonment;

        public InvoiceController(IHostingEnvironment hostingEnvitonment)
        {
            _restClient = new RestClient();
            _hostingEnvitonment = hostingEnvitonment;
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

            //ViewBag.InvoiceTypeEnumList = InvoiceTypeEnum.Proforma.ToSelectList();
            //return View("~/Views/Home/AddInvoice.cshtml");

            return View("~/Views/Invoice/Invoice.cshtml", invoiceResponse);
        }
    }
}
