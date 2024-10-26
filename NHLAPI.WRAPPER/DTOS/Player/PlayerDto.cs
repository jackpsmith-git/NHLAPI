namespace NHLAPI.WRAPPER.DTOS.Player;

public record PlayerDto(
    int playerId,
    StringWrapperDto lastName,
    StringWrapperDto firstName,
    string playerSlug
    ) : BaseDto
{
    public override string ToString() => $"{firstName} {lastName}";
}