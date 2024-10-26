using NHLAPI.WRAPPER.DTOS.Player;

namespace NHLAPI.WRAPPER.Requests;

public static class Player
{
    public static async Task<string?> RequestInfoAsync(int playerId) => await BaseRequest.Request<PlayerInfoDto>(URI.PlayerInfo(playerId));
    public static async Task<string?> RequestGameLogAsync(int playerId, int season, Params.GameType gameType) => await BaseRequest.Request<PlayerGameLogDto>(URI.PlayerGameLog(playerId, season, gameType));
    public static async Task<string?> RequestCurrentGameLogAsync(int playerId) => await BaseRequest.Request<PlayerGameLogDto>(URI.PlayerCurrentGameLog(playerId));
    public static async Task<string?> RequestSpotlightAsync() => await BaseRequest.Request<PlayerSpotlightDto>(URI.PlayerSpotlight);
}