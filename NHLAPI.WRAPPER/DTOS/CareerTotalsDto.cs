using NHLAPI.WRAPPER.DTOS.Player;

namespace NHLAPI.WRAPPER.DTOS;

public record CareerTotalsDto(
    PlayerStatsSeasonDto regularSeason,
    PlayerStatsSeasonDto playoffs
    )
{
    public string ToString(bool isGoalie)
    {
        string output = string.Empty;

        output += regularSeason.ToString(isGoalie);
        output += playoffs.ToString(isGoalie);

        return output;
    }
}