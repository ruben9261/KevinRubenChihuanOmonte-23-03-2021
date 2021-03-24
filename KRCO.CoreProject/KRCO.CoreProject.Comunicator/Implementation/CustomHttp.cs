using KRCO.CoreProject.Common.Functions;
using KRCO.CoreProject.Comunicator.Contract;
using KRCO.CoreProject.Model.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KRCO.CoreProject.Comunicator.Implementation
{
    public class CustomHttp<Request, Response> : ICustomHttp<Request, Response>
    where Request : class
    where Response : class, new()
    {
        public async Task<Response> GetHttpAsync(Request request, String api)
        {
            Response response = null;
            using (HttpClient client = new HttpClient())
            {
                String Propertys = ServiceFunctions.SerializeUrlPropertys(request);
                var data = await client.GetAsync(String.Concat(api, Propertys));

                var jsonResponse = await data.Content.ReadAsStringAsync();
                if (jsonResponse != null)
                {
                    response = new Response();
                    response = JsonConvert.DeserializeObject<Response>(jsonResponse);
                }
                return response;
            }
        }

        public async Task<Result<Response>> TGetHttpAsync(Request request, String api)
        {
            Result<Response> response = null;
            using (HttpClient client = new HttpClient())
            {
                String Propertys = ServiceFunctions.SerializeUrlPropertys(request);
                var data = await client.GetAsync(String.Concat(api, Propertys));

                var jsonResponse = await data.Content.ReadAsStringAsync();
                if (jsonResponse != null)
                {
                    response = new Result<Response>();
                    response = JsonConvert.DeserializeObject<Result<Response>>(jsonResponse);
                }
                return response;
            }
        }

        public async Task<Response> PostHttpAsync(Request request, String api)
        {
            Response response = null;
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
                var data = await client.PostAsync(api, content);

                var jsonResponse = await data.Content.ReadAsStringAsync();
                if (jsonResponse != null)
                {
                    response = new Response();
                    response = JsonConvert.DeserializeObject<Response>(jsonResponse);
                }
                return response;
            }
        }

        public async Task<Result<Response>> TPostHttpAsync(Request request, String api)
        {
            Result<Response> response = null;
            using (HttpClient client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _accessToken);
                StringContent content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
                var data = await client.PostAsync(api, content);

                var jsonResponse = await data.Content.ReadAsStringAsync();
                if (jsonResponse != null)
                {
                    response = new Result<Response>();
                    response = JsonConvert.DeserializeObject<Result<Response>>(jsonResponse);
                }
                return response;
            }
        }


        public async Task<Result<T>> TPostHttpAsync<T>(T request, String api)
        {
            Result<T> response = null;
            using (HttpClient client = new HttpClient())
            {
                var JsonContent = JsonConvert.SerializeObject(request);
                StringContent content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
                var data = await client.PostAsync(api, content);

                var jsonResponse = await data.Content.ReadAsStringAsync();
                if (jsonResponse != null)
                {
                    response = new Result<T>();
                    response = JsonConvert.DeserializeObject<Result<T>>(jsonResponse);
                }
                return response;
            }

        }

        public async Task<Result<T>> TPostHttpAsync<T>(T request, String api, String _accessToken)
        {
            Result<T> response = null;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _accessToken);
                var JsonContent = JsonConvert.SerializeObject(request);
                StringContent content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
                var data = await client.PostAsync(api, content);

                var jsonResponse = await data.Content.ReadAsStringAsync();
                if (jsonResponse != null)
                {
                    response = new Result<T>();
                    response = JsonConvert.DeserializeObject<Result<T>>(jsonResponse);
                }
                return response;
            }
        }

    }
}
