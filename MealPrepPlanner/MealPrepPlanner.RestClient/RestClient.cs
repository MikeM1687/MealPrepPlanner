using MealPrepPlanner.Entities;
using MealPrepPlanner.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace MealPrepPlanner.Client
{
    public class RestClient<T> : IRestClient
    {
        private HttpClient _client;
        private IHttpHandler _handler;

        public RestClient(Uri uri, IHttpHandler httpHandler)
        {
            _handler = httpHandler;

            _client = new HttpClient()
            {
                BaseAddress = uri
            };
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("User-Agent", "MeaplPrepPlanner REST Client");
        }

        //private async Task<T> GetAsync<T>(string uri, CancellationToken cancellationToken)
        //{
        //    HttpResponseMessage response = await _client.GetAsync(uri, cancellationToken);

        //    if (response.IsSuccessStatusCode)
        //    {
        //        var json = await response.Content.ReadAsStringAsync();
        //        var result = JsonConvert.DeserializeObject<T>(json);
        //        return result;
        //    }

        //    return default(T);
        //}

        public async Task<IEnumerable<Meal>>GetMeals(CancellationToken token)
        {
            var meals = new List<Meal>();

            try
            {
                var response = await _handler.GetAsync("api/meals/");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    meals = JsonConvert.DeserializeObject<List<Meal>>(json);
                    
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return meals;
        }
    }
}
