namespace NHLAPI.WRAPPER.DTOS.Team;

public record TeamCommonNameDto(string @default)
{
    public override string ToString() => @default;
}