using NHLAPI.WRAPPER.DTOS;

namespace NHLAPI.WRAPPER.Requests;

public static class Team
{
    public static async Task<string?> RequestCurrentFranchiseStatsAsync(string teamCode)
    {
        string uri = Endpoints.FranchiseCurrentStatsUri(teamCode);
        var dto = await Endpoints.CallEndpointAsync<FranchiseCurrentStatsDto>(uri);
        return dto?.ToString();
    }
}