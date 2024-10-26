using NHLAPI.WRAPPER.DTOS;

namespace NHLAPI.WRAPPER;

public record SeasonDto(
    int id,
    bool conferencesInUse,
    bool divisionsInUse,
    bool pointForOTlossInUse,
    bool rowInUse,
    string standingsEnd,
    string standingsStart,
    bool tiesInUse,
    bool wildcardInUse
    ) : BaseDto;