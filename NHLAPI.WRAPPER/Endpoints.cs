using System.Text.Json;

namespace NHLAPI.WRAPPER;

public static class Endpoints
{
    const string BASE_URI = "https://api-web.nhle.com/v1/";
    private static string PlayerBaseUri(int playerId) => $"{BASE_URI}player/{playerId}/";
    private static string SkaterStatsLeadersBaseUri => $"{BASE_URI}skater-stats-leaders/";
    private static string GoalieStatsLeadersBaseUri => $"{BASE_URI}goalie-stats-leaders/";
    private static string StandingsBaseUri => $"{BASE_URI}standings/";

    // Players
    internal static string PlayerInfoUri(int playerId) => $"{PlayerBaseUri(playerId)}landing";
    internal static string PlayerGameLogUri(int playerId, int season, Params.GameType gameType) => $"{PlayerBaseUri(playerId)}game-log/{season}/{(int)gameType}";
    internal static string PlayerCurrentGameLogUri(int playerId) => $"{PlayerBaseUri(playerId)}game-log/now";

    // Skaters
    internal static string SkaterCurrentStatsLeadersUri(Params.Stat category = Params.Stat.points, int limit = -1) => $"{SkaterStatsLeadersBaseUri}current?categories={category}&limit={limit}";
    internal static string SkaterStatsLeadersUri(int season = 20242025, Params.GameType gameType = Params.GameType.REGULAR_SEASON, Params.Stat category = Params.Stat.points, int limit = -1) => $"{SkaterStatsLeadersBaseUri}{season}/{(int)gameType}?categories={category}&limit={limit}";

    // Goalies
    internal static string GoalieCurrentStatsLeadersUri(Params.Stat category = Params.Stat.wins, int limit = -1) => $"{GoalieStatsLeadersBaseUri}current?categories={category}&limit={limit}";
    internal static string GoalieStatsLeadersUri(int season = 20242025, Params.GameType gameType = Params.GameType.REGULAR_SEASON, Params.Stat category = Params.Stat.wins, int limit = -1) => $"{GoalieStatsLeadersBaseUri}{season}/{(int)gameType}?categories={category}&limit={limit}";

    // Draft Info

    // Player Spotlight
    internal static string PlayerSpotlightUri => $"{BASE_URI}player-spotlight";

    // Team Info
    internal static string StandingsCurrentUri => $"{StandingsBaseUri}now";
    internal static string StandingsUri(string date) => $"{StandingsBaseUri}{date}";
    internal static string StandingsEachSeasonUri => $"{BASE_URI}standings-season";
    internal static string FranchiseCurrentStatsUri(string teamCode) => $"{BASE_URI}club-stats/{teamCode}/now";

    internal static async Task<T?> CallEndpointAsync<T>(string uri)
    {
        using var httpClient = new HttpClient();
        using var httpRequestMessage = new HttpRequestMessage(new HttpMethod("GET"), uri);
        var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
        string json = await httpResponseMessage.Content.ReadAsStringAsync();
        T? dto = JsonSerializer.Deserialize<T>(json);
        return dto;
    }

    // TESTING ONLY
    public static async Task<string> GetJsonTemplateResponse()
    {
        using var httpClient = new HttpClient();
        using var httpRequestMessage = new HttpRequestMessage(new HttpMethod("GET"), FranchiseCurrentStatsUri("NYR"));
        var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
        string json = await httpResponseMessage.Content.ReadAsStringAsync();
        return json;
    }
}