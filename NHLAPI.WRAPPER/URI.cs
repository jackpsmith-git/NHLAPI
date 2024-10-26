namespace NHLAPI.WRAPPER;

public static class URI
{
    const string BASE = "https://api-web.nhle.com/v1/";
    private static string PlayerBase(int playerId) => $"{BASE}player/{playerId}/";
    private static string SkaterStatsLeadersBase => $"{BASE}skater-stats-leaders/";
    private static string GoalieStatsLeadersBase => $"{BASE}goalie-stats-leaders/";
    private static string StandingsBase => $"{BASE}standings/";

    // Players
    internal static string PlayerInfo(int playerId) => $"{PlayerBase(playerId)}landing";
    internal static string PlayerGameLog(int playerId, int season, Params.GameType gameType) => $"{PlayerBase(playerId)}game-log/{season}/{(int)gameType}";
    internal static string PlayerCurrentGameLog(int playerId) => $"{PlayerBase(playerId)}game-log/now";
    internal static string PlayerSpotlight => $"{BASE}player-spotlight";

    // Skaters
    internal static string SkaterCurrentStatsLeaders(Params.Stat category = Params.Stat.points, int limit = -1) => $"{SkaterStatsLeadersBase}current?categories={category}&limit={limit}";
    internal static string SkaterStatsLeaders(int season = 20242025, Params.GameType gameType = Params.GameType.REGULAR_SEASON, Params.Stat category = Params.Stat.points, int limit = -1) => $"{SkaterStatsLeadersBase}{season}/{(int)gameType}?categories={category}&limit={limit}";

    // Goalies
    internal static string GoalieCurrentStatsLeaders(Params.Stat category = Params.Stat.wins, int limit = -1) => $"{GoalieStatsLeadersBase}current?categories={category}&limit={limit}";
    internal static string GoalieStatsLeaders(int season = 20242025, Params.GameType gameType = Params.GameType.REGULAR_SEASON, Params.Stat category = Params.Stat.wins, int limit = -1) => $"{GoalieStatsLeadersBase}{season}/{(int)gameType}?categories={category}&limit={limit}";

    // Draft

    // Team
    internal static string StandingsCurrent => $"{StandingsBase}now";
    internal static string Standings(string date) => $"{StandingsBase}{date}";
    internal static string StandingsEachSeason => $"{BASE}standings-season";
    internal static string FranchiseCurrentStats(string teamCode) => $"{BASE}club-stats/{teamCode}/now";

    // Game
    internal static string PlayByPlay(int gameId) => $"{BASE}gamecenter/{gameId}/play-by-play";
}