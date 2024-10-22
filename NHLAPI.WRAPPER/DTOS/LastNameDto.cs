namespace NHLAPI.WRAPPER.DTOS;

public record LastNameDto(string @default)
{
    public override string ToString() => @default;
}
