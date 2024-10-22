using NHLAPI.WRAPPER.DTOS.Team;

namespace NHLAPI.WRAPPER.DTOS.Player;

public record PlayerStatsGameDto(
    int assists,
    TeamCommonNameDto commonName,
    string gameDate,
    int gameId,
    int gameTypeId,
    int gameWinningGoals,
    int goals,
    string homeRoadFlag,
    string opponentAbbrev,
    TeamCommonNameDto opponentCommonName,
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
    );