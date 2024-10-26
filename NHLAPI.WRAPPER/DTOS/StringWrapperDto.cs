namespace NHLAPI.WRAPPER.DTOS;

public record StringWrapperDto(string @default) : BaseDto
{
    public override string ToString() => @default;
}
