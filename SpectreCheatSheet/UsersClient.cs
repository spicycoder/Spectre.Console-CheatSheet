using System.Text.Json;

namespace SpectreCheatSheet
{
    public class UsersClient
    {
        public async Task<Response?> GetUser(int id)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Spectre-CheatSheet");
            var response = await client.GetAsync($"https://reqres.in/api/users/{id}");
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Response>(content);
        }
    }
}
