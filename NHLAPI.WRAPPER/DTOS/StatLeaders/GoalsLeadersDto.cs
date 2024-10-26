namespace NHLAPI.WRAPPER.DTOS.StatLeaders;

public record GoalsLeadersDto(
    StatLeaderDto[] goals
    ) : BaseDto
{
    public override string ToString()
    {
        string output = string.Empty;

        int i = 1;
        foreach (StatLeaderDto leader in goals)
        {
            output += $"{i}. {leader}";
            i++;
        }

        output += "\n";
        return output;
    }
}