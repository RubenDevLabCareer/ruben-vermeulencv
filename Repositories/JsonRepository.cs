using System.Net.Http.Json;

namespace CvBlazor.Repositories
{
    public abstract class JsonRepository<T> : IJsonRepository<T>
    {
        private readonly string _jsonPath;
        private readonly HttpClient _client;    

        public JsonRepository(HttpClient client, string jsonPath)
        {
            _client = client;
            _jsonPath = jsonPath;
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await _client.GetFromJsonAsync<List<T>>(_jsonPath) ?? new List<T>();
        }
    }
}




