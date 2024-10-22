namespace NHLAPI.WRAPPER.DTOS;

public record WinsLeadersDto(
    StatLeaderDto[] wins
    )
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