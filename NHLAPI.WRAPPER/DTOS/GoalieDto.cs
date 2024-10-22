namespace NHLAPI.WRAPPER.DTOS;

public record GoalieDto(
    int playerId,
    string headshot,
    FirstNameDto firstName,
    LastNameDto lastName,
    int gamesPlayed,
    int gamesStarted,
    int wins,
    int losses,
    int ties,
    int overtimeLosses,
    float goalsAgainstAverage,
    float savePercentage,
    int shotsAgainst,
    int saves,
    int goalsAgainst,
    int shutouts,
    int goals,
    int assists,
    int points,
    int penaltMinutes,
    int timeOnIce
    );