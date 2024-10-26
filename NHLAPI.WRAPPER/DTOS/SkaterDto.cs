namespace NHLAPI.WRAPPER.DTOS;

public record SkaterDto(
    int playerId,
    string headshot,
    StringWrapperDto firstName,
    StringWrapperDto lastName,
    string positionCode,
    int gamesPlayed,
    int goals,
    int assists,
    int points,
    int plusMinus,
    int penaltyMinutes,
    int powerPlayGoals,
    int shorthandedGoals,
    int gameWinningGoals,
    int overtimeGoals,
    int shots,
    float shootingPctg,
    float avgTimeOnIcePerGame,
    float avgShiftsPerGame,
    float faceoffWinPctg
    ) : BaseDto;