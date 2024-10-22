using NHLAPI.WRAPPER.DTOS.Player;

namespace NHLAPI.WRAPPER.Requests;

public static class Player
{
    public static async Task<string?> RequestInfoAsync(int playerId)
    {
        string uri = Endpoints.PlayerInfoUri(playerId);
        var dto = await Endpoints.CallEndpointAsync<PlayerInfoDto>(uri);
        return dto?.ToString();
    }

    public static async Task<string?> RequestGameLogAsync(int playerId, int season, Params.GameType gameType)
    {
        string uri = Endpoints.PlayerGameLogUri(playerId, season, gameType);
        var dto = await Endpoints.CallEndpointAsync<PlayerGameLogDto>(uri);
        return dto?.ToString();
    }

    public static async Task<string?> RequestCurrentGameLogAsync(int playerId)
    {
        string uri = Endpoints.PlayerCurrentGameLogUri(playerId);
        var dto = await Endpoints.CallEndpointAsync<PlayerGameLogDto>(uri);
        return dto?.ToString();
    }

    public static async Task<string?> RequestSpotlightAsync()
    {
        string uri = Endpoints.PlayerSpotlightUri;
        var dto = await Endpoints.CallEndpointAsync<PlayerSpotlightDto[]>(uri);
        return dto?.ToString();
    }
}