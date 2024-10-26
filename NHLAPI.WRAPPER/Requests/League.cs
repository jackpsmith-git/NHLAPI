using NHLAPI.WRAPPER.DTOS;

namespace NHLAPI.WRAPPER.Requests;

public static class League
{
    public static async Task<string?> RequestCurrentStatLeadersAsync<T>(bool isGoalie, Params.Stat stat, int limit) where T : BaseDto
    {
        string uri = isGoalie ? 
            URI.GoalieCurrentStatsLeaders(stat, limit) : 
            URI.SkaterCurrentStatsLeaders(stat, limit);

        return await BaseRequest.Request<T>(uri);
    }

    public static async Task<string?> RequestStatLeadersAsync<T>(int season, bool isGoalie, Params.Stat stat, Params.GameType gameType, int limit) where T : BaseDto
    {
        string uri = isGoalie ? 
            URI.GoalieStatsLeaders(season, gameType, stat, limit) : 
            URI.SkaterStatsLeaders(season, gameType, stat, limit);

        return await BaseRequest.Request<T>(uri);
    }

    public static async Task<string?> RequestCurrentStandingsAsync() => await BaseRequest.Request<StandingsDto>(URI.StandingsCurrent);
    public static async Task<string?> RequestStandingsAsync(string date) => await BaseRequest.Request<StandingsDto>(URI.Standings(date));
    public static async Task<string?> RequestStandingsEachSeasonAsync() => await BaseRequest.Request<StandingsEachSeasonDto>(URI.StandingsEachSeason);
}