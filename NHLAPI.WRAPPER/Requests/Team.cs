using NHLAPI.WRAPPER.DTOS;

namespace NHLAPI.WRAPPER.Requests;

public static class Team
{
    public static async Task<string?> RequestCurrentFranchiseStatsAsync(string teamCode) => await BaseRequest.Request<FranchiseCurrentStatsDto>(URI.FranchiseCurrentStats(teamCode));
}