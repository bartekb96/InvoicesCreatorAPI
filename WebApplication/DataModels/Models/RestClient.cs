using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.DataModels.Models
{
    public abstract class RestClientAbstract
    {
        public readonly HttpClient client;

        public string responseString { get; set; }

        public Task<HttpResponseMessage> response { get; set; }

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
                        response = client.GetAsync(uri);
                        response.Wait();
                        if (response.Result.IsSuccessStatusCode)
                        {
                            responseString = await response.Result.Content.ReadAsStringAsync();
                        }
                        break;
                    case Enums.HttpMethod.POST:
                        response = client.PostAsync(uri, content);
                        response.Wait();
                        if (response.Result.IsSuccessStatusCode)
                        {
                            responseString = await response.Result.Content.ReadAsStringAsync();
                        }
                        break;
                    case Enums.HttpMethod.PUT:
                        response = client.PutAsync(uri, content);
                        response.Wait();
                        if (response.Result.IsSuccessStatusCode)
                        {
                            responseString = await response.Result.Content.ReadAsStringAsync();
                        }
                        break;
                    case Enums.HttpMethod.DELETE:
                        response = client.DeleteAsync(uri);
                        response.Wait();
                        if (response.Result.IsSuccessStatusCode)
                        {
                            responseString = await response.Result.Content.ReadAsStringAsync();
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
