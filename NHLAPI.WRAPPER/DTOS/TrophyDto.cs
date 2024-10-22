namespace NHLAPI.WRAPPER.DTOS;

public record TrophyDto(
    string @default, 
    string fr
    )
{
    public override string ToString() => @default;
}
