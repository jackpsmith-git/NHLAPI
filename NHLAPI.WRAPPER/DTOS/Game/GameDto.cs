namespace NHLAPI.WRAPPER.DTOS.Game;

public record GameDto(
    int id,
    int season,
    int gameType,
    bool limitedScoring,
    string gameDate,
    StringWrapperDto venue,
    StringWrapperDto venueLocation,
    string startTimeUTC,
    string easternUTCOffset,
    string venueUTCOffset,
    TvBroadcastDto[] tvBroadcasts,
    string gameState,
    string gameScheduleState,
    PeriodDescriptorDto periodDescriptor,
    TeamDto awayTeam,
    TeamDto homeTeam,
    bool shootoutInUse,
    bool otInUse,
    ClockDto clock,
    SituationDto situation,
    int displayPeriod,
    int maxPeriods,
    RosterSpotDto[] rosterSpots,
    int regPeriods,
    SummaryDto summary
    ) : BaseDto;

public record TvBroadcastDto(
    int id,
    string market,
    string countryCode,
    string network,
    int sequenceNumber
    ) : BaseDto;

public record PeriodDescriptorDto(
    int number,
    string periodType,
    int maxRegulationPeriods
    ) : BaseDto;

public record TeamDto(
    RosterSpotDto[] forwards,
    RosterSpotDto[] defensemen,
    RosterSpotDto[] goalies,
    PenaltyBoxDto[] penaltyBoxes
    ) : BaseDto;

public record RosterSpotDto(
    int playerId,
    StringWrapperDto name,
    int sweaterNumber,
    string positionCode,
    string headshot,
    int totalSOI
    ) : BaseDto;

public record PenaltyBoxDto(
    int playerId,
    StringWrapperDto name,
    int sweaterNumber,
    string positionCode,
    string headshot,
    int secondsRemaining
    ) : BaseDto;

public record ClockDto(
    string timeRemaining,
    int secondsRemaining,
    bool running,
    bool inIntermission
    ) : BaseDto;

public record SituationDto(
    TeamDto homeTeam,
    TeamDto awayTeam,
    string situationCode,
    string timeRemaining,
    int secondsRemaining
    ) : BaseDto;

public record SummaryDto(
    IceSurfaceDto iceSurface
    ) : BaseDto;

public record IceSurfaceDto(
    TeamDto awayTeam,
    TeamDto homeTeam
    ) : BaseDto;