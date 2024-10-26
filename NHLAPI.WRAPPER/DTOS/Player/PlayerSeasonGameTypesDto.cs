namespace NHLAPI.WRAPPER.DTOS.Player;

public record PlayerSeasonGameTypesDto(
    int season,
    int[] gameTypes) : BaseDto;