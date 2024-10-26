using NHLAPI.WRAPPER.DTOS;
using System.Text.Json;
using static Jpsmith.Data.Http.Http;

namespace NHLAPI.WRAPPER.Requests;

public static class BaseRequest
{
    internal static async Task<string?> Request<T>(string uri) where T : BaseDto
    {
        string json = await CallEndpointAsync(HttpMethod.Get, uri);
        var dto = JsonSerializer.Deserialize<T>(json);
        return dto?.ToString();
    }
}