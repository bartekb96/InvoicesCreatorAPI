using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesCreator.WebApp.Models
{
    public abstract class RestClientAbstract
    {
        public readonly HttpClient client;

        public string responseString { get; set; }

        public HttpResponseMessage response { get; set; }

        public RestClientAbstract()
        {
            client = new HttpClient();
        }

        public abstract Task<bool> SendRequest(Enums.HttpMethod method, string endpoint, string data = null);
    }

    public class RestClient : RestClientAbstract
    {
        public RestClient() : base()
        {
        }

        public override async Task<bool> SendRequest(Enums.HttpMethod method, string endpoint, string data = null)
        {
            try
            {
                var uri = new Uri("https://localhost:44321/api/v1/" + endpoint);   // przenieść do appsettings

                responseString = "";
                response = null;
                var content = new StringContent(data, Encoding.UTF8, "application/json");

                switch (method)
                {
                    case Enums.HttpMethod.GET:
                        response = await client.GetAsync(uri);
                        if (response.IsSuccessStatusCode)
                        {
                            responseString = await response.Content.ReadAsStringAsync();
                        }
                        break;
                    case Enums.HttpMethod.POST:
                        response = await client.PostAsync(uri, content);
                        if (response.IsSuccessStatusCode)
                        {
                            responseString = await response.Content.ReadAsStringAsync();
                        }
                        break;
                    case Enums.HttpMethod.PUT:
                        response = await client.PutAsync(uri, content);
                        if (response.IsSuccessStatusCode)
                        {
                            responseString = await response.Content.ReadAsStringAsync();
                        }
                        break;
                    case Enums.HttpMethod.DELETE:
                        response = await client.DeleteAsync(uri);
                        if (response.IsSuccessStatusCode)
                        {
                            responseString = await response.Content.ReadAsStringAsync();
                        }
                        break;
                    default:
                        break;
                }

                return true;
            }
            catch (HttpRequestException e)
            {
                return false;
            }
        }
    }
}
