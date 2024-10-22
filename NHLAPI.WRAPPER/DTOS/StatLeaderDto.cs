using NHLAPI.WRAPPER.DTOS.Team;

namespace NHLAPI.WRAPPER.DTOS;

public record StatLeaderDto(
    int id,
    FirstNameDto firstName,
    LastNameDto lastName,
    int sweaterNumber,
    string headshot,
    string teamAbbrev,
    TeamNameDto teamName,
    string teamLogo,
    string position,
    int value
    )
{
    public override string ToString() => $"{firstName} {lastName} ({teamAbbrev}) - {value} \n";
}