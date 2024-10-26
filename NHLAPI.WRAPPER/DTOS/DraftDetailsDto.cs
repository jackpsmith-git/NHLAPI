namespace NHLAPI.WRAPPER.DTOS;

public record DraftDetailsDto(
    int year,
    string teamAbbrev,
    int round,
    int pickInRound,
    int overallPick) : BaseDto
{
    public override string ToString()
    {
        string output = string.Empty;

        output += "Draft Details: \n";
        output += $"Year: {year} \n";
        output += $"Team: {teamAbbrev} \n";
        output += $"Round: {round} \n";
        output += $"Pick In Round: {pickInRound} \n";
        output += $"Overall: {overallPick} \n \n";

        return output;
    }
}