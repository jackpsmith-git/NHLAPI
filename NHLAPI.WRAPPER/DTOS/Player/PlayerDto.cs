namespace NHLAPI.WRAPPER.DTOS.Player;

public record PlayerDto(
    int playerId,
    LastNameDto lastName,
    FirstNameDto firstName,
    string playerSlug
    )
{
    public override string ToString() => $"{firstName} {lastName}";
}