using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Overmind.PraticalEvaluation.Domain;
using System.Net.Http.Headers;

namespace Overmind.PraticalEvaluation.Infrastructure.Net.Http
{
    public class RestApiRequest<TDataKeyType,TEntity>
        where TEntity: BaseEntity<TDataKeyType>
    {
        private readonly HttpClient _client = new HttpClient();
        public RestApiRequest(string uri)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(uri);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<TEntity> Post(TEntity obj)
        {
            var response = await _client.PostAsJsonAsync("/objects", obj);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<TEntity>();
        }

        public async Task<TEntity> Put(TDataKeyType id, TEntity obj)
        {
            var response = await _client.PutAsJsonAsync($"/objects/{id}", obj);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<TEntity>();
        }

        public async Task Delete(TDataKeyType id)
        {
            var response = await _client.DeleteAsync($"/objects/{id}");
            response.EnsureSuccessStatusCode();
        }

        public async Task<IList<TEntity>> Get()
        {
            var response = await _client.GetAsync("/objects");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<TEntity>>();
        }

        public async Task<TEntity> Get(TDataKeyType id)
        {
            var response = await _client.GetAsync($"/objects/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<TEntity>();
        }
    }
}
