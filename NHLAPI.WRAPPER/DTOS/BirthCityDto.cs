namespace NHLAPI.WRAPPER.DTOS;

public record BirthCityDto(string @default)
{
    public override string ToString() => @default;
}