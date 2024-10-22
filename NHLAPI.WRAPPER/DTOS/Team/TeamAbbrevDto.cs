namespace NHLAPI.WRAPPER.DTOS.Team;

public record TeamAbbrevDto(string @default, string fr)
{
    public override string ToString() => @default;
}