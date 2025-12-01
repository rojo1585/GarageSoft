using GarageSoft.Shared.DTOs.Client;
using System.Net.Http.Json;

namespace GarageSoft.Web.Services;
public interface IClientDataService
{
    Task<bool> CreateClientAsync(CreateClientDto client);
}

public class ClientDataService(HttpClient http) : IClientDataService
{
    public async Task<bool> CreateClientAsync(CreateClientDto client)
    {
        var response = await http.PostAsJsonAsync("api/Client", client);
        return response.IsSuccessStatusCode;
    }
}