namespace NHLAPI.WRAPPER.DTOS;

public record FullTeamNameDto(
    string @default,
    string fr
    )
{
    public override string ToString() => @default;
}