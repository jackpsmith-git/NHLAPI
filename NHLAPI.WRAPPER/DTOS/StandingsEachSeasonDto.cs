namespace NHLAPI.WRAPPER;

public record StandingsEachSeasonDto(
    string currentDate,
    SeasonDto[] seasons
    );