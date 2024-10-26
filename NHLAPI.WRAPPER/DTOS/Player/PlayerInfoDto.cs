namespace NHLAPI.WRAPPER.DTOS.Player;

public record PlayerInfoDto(
    int playerId,
    bool isActive,
    int currentTeamId,
    string currentTeamAbbrev,
    StringWrapperDto fullTeamName,
    StringWrapperDto teamCommonName,
    StringWrapperDto teamPlaceNameWithPreposition,
    StringWrapperDto firstName,
    StringWrapperDto lastName,
    string teamLogo,
    int sweaterNumber,
    string position,
    string headshot,
    string heroImage,
    int heightInInches,
    int heightInCentimeters,
    int weightInPounds,
    int weightInKilograms,
    string birthDate,
    StringWrapperDto birthCity,
    string birthCountry,
    string shootsCatches,
    DraftDetailsDto draftDetails,
    string playerSlug,
    int inTop100AllTime,
    int inHHOF,
    FeaturedStatsDto featuredStats,
    CareerTotalsDto careerTotals,
    string shopLink,
    string twitterLink,
    string watchLink,
    PlayerStatsGameDto[] last5Games,
    AwardDto[] awards,
    PlayerDto[] currentTeamRoster
    ) : BaseDto
{
    public override string ToString()
    {
        string output = string.Empty;

        output += $"Name: {firstName} {lastName} \n";
        output += $"Team: {currentTeamAbbrev} \n";
        output += $"Number: {sweaterNumber} \n";
        output += $"Position: {position} \n";
        output += $"Height: {heightInInches}in/{heightInCentimeters}cm \n";
        output += $"Weight: {weightInPounds}lbs/{weightInKilograms}kgs \n";
        output += $"DOB: {birthDate} \n";
        output += $"Birth City: {birthCity}, {birthCountry} \n";
        output += $"R/L: {shootsCatches} \n \n";

        if (draftDetails != null)
            output += draftDetails.ToString();

        if (careerTotals != null)
            output += careerTotals.ToString(position == "G");

        if (awards != null)
        {
            output += "Awards: \n";
            foreach (AwardDto award in awards)
            {
                output += award.ToString();
            }
        }

        output += "\n";

        return output;
    }
}