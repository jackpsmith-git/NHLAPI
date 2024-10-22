using NHLAPI.WRAPPER.DTOS;

namespace NHLAPI.WRAPPER.Requests;

public static class League
{
    public static async Task<string?> RequestCurrentStatLeadersAsync<T>(bool isGoalie, Params.Stat stat, int limit)
    {
        string uri = isGoalie ? Endpoints.GoalieCurrentStatsLeadersUri(stat, limit) : Endpoints.SkaterCurrentStatsLeadersUri(stat, limit);
        var dto = await Endpoints.CallEndpointAsync<T>(uri);
        return dto?.ToString();
    }

    public static async Task<string?> RequestStatLeadersAsync<T>(int season, bool isGoalie, Params.Stat stat, Params.GameType gameType, int limit)
    {
        string uri = isGoalie ? Endpoints.GoalieStatsLeadersUri(season, gameType, stat, limit) : Endpoints.SkaterStatsLeadersUri(season, gameType, stat, limit);
        var dto = await Endpoints.CallEndpointAsync<T>(uri);
        return dto?.ToString();
    }

    public static async Task<string?> RequestCurrentStandingsAsync()
    {
        string uri = Endpoints.StandingsCurrentUri;
        var dto = await Endpoints.CallEndpointAsync<StandingsDto>(uri);
        return dto?.ToString();
    }

    public static async Task<string?> RequestStandingsAsync(string date)
    {
        string uri = Endpoints.StandingsUri(date);
        var dto = await Endpoints.CallEndpointAsync<StandingsDto>(uri);
        return dto?.ToString();
    }

    public static async Task<string?> RequestStandingsEachSeasonAsync()
    {
        string uri = Endpoints.StandingsEachSeasonUri;
        var dto = await Endpoints.CallEndpointAsync<StandingsEachSeasonDto>(uri);
        return dto?.ToString();
    }
}