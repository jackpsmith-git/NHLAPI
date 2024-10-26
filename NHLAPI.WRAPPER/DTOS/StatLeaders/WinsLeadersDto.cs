namespace NHLAPI.WRAPPER.DTOS.StatLeaders;

public record WinsLeadersDto(
    StatLeaderDto[] wins
    ) : BaseDto
{
    public override string ToString()
    {
        string output = string.Empty;

        int i = 1;
        foreach (StatLeaderDto leader in wins)
        {
            output += $"{i}. {leader}";
            i++;
        }

        output += "\n";
        return output;
    }
}