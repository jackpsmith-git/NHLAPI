namespace NHLAPI.WRAPPER.DTOS.Team;

public record TeamNameDto(
    string @default,
    string fr
    )
{
    public override string ToString() => @default;
}
