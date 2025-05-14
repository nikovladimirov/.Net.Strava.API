using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using com.strava.v3.api.Common;

namespace com.strava.v3.api.Http
{
    public class HttpClientExtended
    {
        private readonly HttpClient _httpClient = new HttpClient();
        
        public async Task<T> SendPutAsync<T>(string url, string json, string accessToken)
        {
            // Создаем тело запроса
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

            // Отправляем PUT-запрос
            var response = await _httpClient.PutAsync(url, content);
            string responseBody = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                // Возвращаем JSON ответа
                return Unmarshaller<T>.Unmarshal(responseBody);
            }

            // Логируем или кидаем исключение с текстом ошибки
            throw new Exception($"Error {response.StatusCode}: {responseBody}");
        }
    }
}