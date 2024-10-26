namespace NHLAPI.WRAPPER.DTOS;

public record SeasonStatsDto(
    int assists,
    int blockedShots,
    int gameTypeId,
    int gamesPlayed,
    int goals,
    int hits,
    int pim,
    int plusMinus,
    int points,
    int seasonId
    ) : BaseDto
{
    public override string ToString() => seasonId.ToString();
}