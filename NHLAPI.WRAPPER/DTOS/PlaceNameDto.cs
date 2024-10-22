namespace NHLAPI.WRAPPER.DTOS;

public record PlaceNameDto(string @default)
{
    public override string ToString() => @default;
}