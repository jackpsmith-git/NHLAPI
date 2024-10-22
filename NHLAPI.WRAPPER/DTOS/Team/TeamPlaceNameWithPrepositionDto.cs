namespace NHLAPI.WRAPPER.DTOS.Team;

public record TeamPlaceNameWithPrepositionDto(
    string @default,
    string fr)
{
    public override string ToString() => @default;
}