namespace NHLAPI.WRAPPER.DTOS.Player;

public record PlayerGameLogDto(
    int seasonId,
    int gameTypeId,
    PlayerSeasonGameTypesDto[] playerStatsSeasons,
    PlayerStatsGameDto[] gameLog) : BaseDto;