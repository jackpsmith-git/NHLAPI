namespace NHLAPI.WRAPPER.DTOS;

public record FirstNameDto(string @default)
{
    public override string ToString() => @default;
}