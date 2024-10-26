namespace NHLAPI.WRAPPER.DTOS.Player;

public record PlayerStatsGameDto(
    int assists,
    StringWrapperDto commonName,
    string gameDate,
    int gameId,
    int gameTypeId,
    int gameWinningGoals,
    int goals,
    string homeRoadFlag,
    string opponentAbbrev,
    StringWrapperDto opponentCommonName,
    int otGoals,
    int pim,
    int plusMinus,
    int points,
    int powerPlayGoals,
    int powerPlayPoints,
    int shifts,
    int shorthandedGoals,
    int shorthandedPoints,
    int shots,
    string teamAbbrev,
    string toi
    ) : BaseDto;