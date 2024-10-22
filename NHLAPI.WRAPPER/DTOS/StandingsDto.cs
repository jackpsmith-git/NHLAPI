using NHLAPI.WRAPPER.DTOS.Team;

namespace NHLAPI.WRAPPER.DTOS;

internal record StandingsDto(
    bool wildCardIndicator,
    TeamStatsDto[] standings
    )
{
    public override string ToString()
    {
        string output = string.Empty;

        int i = 1;
        foreach (TeamStatsDto standing in standings)
        {
            output += $"{i}: {standing} \n";
            i++;
        }

        return output;
    }
}