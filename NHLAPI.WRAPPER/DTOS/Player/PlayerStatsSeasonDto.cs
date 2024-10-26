namespace NHLAPI.WRAPPER.DTOS.Player;

public record PlayerStatsSeasonDto(
    int assists,
    string avgToi,
    float faceoffWinningPctg,
    int gameWinningGoals,
    int gamesPlayed,
    int gamesStarted,
    int goals,
    int goalsAgainst,
    float goalsAgainstAvg,
    int losses,
    int otGoals,
    int otLosses,
    int pim,
    int plusMinus,
    int points,
    int powerPlayGoals,
    int powerPlayPoints,
    float savePctg,
    float shootingPctg,
    int shorthandedGoals,
    int shorthandedPoints,
    int shots,
    int shotsAgainst,
    int shutouts,
    string timeOnIce,
    int wins
    ) : BaseDto
{
    public string ToString(bool isGoalie)
    {
        string output = string.Empty;
        output += $"GP: {gamesPlayed} \n";

        if (!isGoalie)
        {
            output += $"G: {goals} \n";
            output += $"A: {assists} \n";
            output += $"P: {points} \n";
            output += $"SH%: {shootingPctg} \n";
            output += $"xTOI: {avgToi} \n";
        }
        else
        {
            output += $"W: {wins} \n";
            output += $"L: {losses} \n";
            output += $"OTL: {otLosses} \n";
            output += $"GA: {goalsAgainst} \n";
            output += $"SV: {shotsAgainst - goalsAgainst} \n";
            output += $"GAA: {goalsAgainstAvg} \n";
            output += $"SV%: {savePctg} \n";
            output += $"SO: {shutouts} \n";
            output += $"TOI: {timeOnIce} \n";
        }

        output += $"PIM: {pim} \n";
        output += "\n";

        return output;
    }
}