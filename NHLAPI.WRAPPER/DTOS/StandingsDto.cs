namespace NHLAPI.WRAPPER.DTOS;

internal record StandingsDto(
    bool wildCardIndicator,
    TeamStatsDto[] standings
    ) : BaseDto
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