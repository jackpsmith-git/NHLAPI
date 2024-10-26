namespace NHLAPI.WRAPPER.DTOS.StatLeaders;

public record PointsLeadersDto(
    StatLeaderDto[] points
    ) : BaseDto
{
    public override string ToString()
    {
        string output = string.Empty;

        int i = 1;
        foreach (StatLeaderDto leader in points)
        {
            output += $"{i}. {leader}";
            i++;
        }

        output += "\n";
        return output;
    }
}