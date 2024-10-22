namespace NHLAPI.WRAPPER;

public static class Params
{
    public enum Stat
    {
        goals,
        assists,
        points,
        wins,
        losses
    }

    public enum GameType
    {
        UNKNOWN,
        PRESEASON,
        REGULAR_SEASON,
        PLAYOFFS
    }
}