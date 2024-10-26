namespace NHLAPI.WRAPPER.DTOS;

public record AwardDto(
    StringWrapperDto trophy,
    SeasonStatsDto[] seasons
    ) : BaseDto
{
    public override string ToString()
    {
        string output = string.Empty;
        string seasonsString = string.Empty;
        int i = 0;
        foreach (SeasonStatsDto season in seasons)
        {
            seasonsString += season.seasonId.ToString().Substring(4);
            if (i != seasons.Length - 1)
            {
                seasonsString += ", ";
            }
            i++;
        }

        output += $"{trophy.@default}: {seasonsString} \n";

        return output;
    }
}