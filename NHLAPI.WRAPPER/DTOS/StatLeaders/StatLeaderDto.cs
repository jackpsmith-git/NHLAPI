namespace NHLAPI.WRAPPER.DTOS.StatLeaders;

public record StatLeaderDto(
    int id,
    StringWrapperDto firstName,
    StringWrapperDto lastName,
    int sweaterNumber,
    string headshot,
    string teamAbbrev,
    StringWrapperDto teamName,
    string teamLogo,
    string position,
    int value
    ) : BaseDto
{
    public override string ToString() => $"{firstName} {lastName} ({teamAbbrev}) - {value} \n";
}