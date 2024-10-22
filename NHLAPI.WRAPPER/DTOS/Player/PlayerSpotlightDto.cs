namespace NHLAPI.WRAPPER.DTOS.Player;

public record PlayerSpotlightDto(
    int playerId,
    FirstNameDto name,
    string playerSlug,
    string position,
    int sweaterNumber,
    int teamId,
    string headshot,
    string teamTriCode,
    string teamlogo,
    int sortId
    );