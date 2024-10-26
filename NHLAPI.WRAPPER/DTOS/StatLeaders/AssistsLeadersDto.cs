namespace NHLAPI.WRAPPER.DTOS.StatLeaders;

public record AssistsLeadersDto(
    StatLeaderDto[] assists
    ) : BaseDto
{
    public override string ToString()
    {
        string output = string.Empty;

        int i = 1;
        foreach (StatLeaderDto leader in assists)
        {
            output += $"{i}. {leader}";
            i++;
        }

        output += "\n";
        return output;
    }
}
