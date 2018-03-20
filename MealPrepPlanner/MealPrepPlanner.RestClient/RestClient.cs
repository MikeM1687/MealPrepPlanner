using MealPrepPlanner.Entities;
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
    public class RestClient : IDisposable
    {
        private HttpClient _client;

        public RestClient(Uri uri)
        {
            _client = new HttpClient()
            {
                BaseAddress = uri
            };
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("User-Agent", "MeaplPrepPlanner REST Client");
        }

        private async Task<T> GetAsync<T>(string uri, CancellationToken cancellationToken)
        {
            HttpResponseMessage response = await _client.GetAsync(uri, cancellationToken);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<T>(json);
                return result;
            }

            return default(T);
        }

        public async Task<IEnumerable<Meal>>GetMeals(CancellationToken token)
        {
            try
            {
                return await GetAsync<IEnumerable<Meal>>("api/meals/", token);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
