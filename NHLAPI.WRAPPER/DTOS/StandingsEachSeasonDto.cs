using NHLAPI.WRAPPER.DTOS;

namespace NHLAPI.WRAPPER;

public record StandingsEachSeasonDto(
    string currentDate,
    SeasonDto[] seasons
    ) : BaseDto;