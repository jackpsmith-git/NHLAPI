namespace NHLAPI.WRAPPER.DTOS;

public record FranchiseCurrentStatsDto(
    string season,
    int gameType,
    SkaterDto[] skaters,
    GoalieDto[] goalies
    ) : BaseDto;