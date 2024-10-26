using Leaders = NHLAPI.WRAPPER.DTOS.StatLeaders;
using League = NHLAPI.WRAPPER.Requests.League;
using Player = NHLAPI.WRAPPER.Requests.Player;
using Params = NHLAPI.WRAPPER.Params;

await Main();

static async Task Main()
{
    Console.WriteLine("NHL Statistics Console v1.0.0");
    Console.WriteLine();
    await ExecuteMainLoop();
}

static async Task ExecuteMainLoop()
{
    Console.WriteLine("[0] Standings");
    Console.WriteLine("[1] Player Info");
    Console.WriteLine("[2] Current Stats Leaders");
    Console.WriteLine();

    string? response = Console.ReadLine();
    Console.WriteLine();
    bool success = int.TryParse(response, out int value);

    if (success)
    {
        switch (value)
        {
            case 0:
                await ExecuteStandingsLoop();
                break;
            case 1:
                await ExecutePlayerSearchLoop();
                break;
            case 2:
                await ExecuteStatsLeadersLoop();
                break;
            default:
                await ExecuteMainLoop();
                break;
        }
    }

    Console.WriteLine();
    await ExecuteMainLoop();
}

static async Task ExecuteStandingsLoop()
{
    string? currentStandingsData = await League.RequestCurrentStandingsAsync();
    Console.WriteLine(currentStandingsData);
}

static async Task ExecutePlayerSearchLoop()
{
    Console.Write("Enter a player ID: ");

    bool playerIdSuccess = int.TryParse(Console.ReadLine(), out int id);
    bool callEndpoint = playerIdSuccess && id > 0 && id.ToString().Length == 7;

    Console.WriteLine();

    if (callEndpoint)
    {
        string? playerInfoData = await Player.RequestInfoAsync(id);
        Console.WriteLine(playerInfoData);
    }
    else
    {
        Console.WriteLine("Invalid player ID. ID must be a 7-digit integer. \n" +
            "Ex. Connor McDavid = 8478402.");
    }

    Console.WriteLine();
}

static async Task ExecuteStatsLeadersLoop()
{
    Console.WriteLine("[0] G");
    Console.WriteLine("[1] A");
    Console.WriteLine("[2] P");
    Console.WriteLine("[3] W");
    Console.WriteLine();

    string? statResponse = Console.ReadLine();
    Console.WriteLine();
    bool statResponseSuccess = int.TryParse(statResponse, out int statValue);

    if (statResponseSuccess)
    {
        string? statLeadersData = statValue switch
        {
            0 => await League.RequestCurrentStatLeadersAsync<Leaders.GoalsLeadersDto>(false, Params.Stat.goals, 10),
            1 => await League.RequestCurrentStatLeadersAsync<Leaders.AssistsLeadersDto>(false, Params.Stat.assists, 10),
            2 => await League.RequestCurrentStatLeadersAsync<Leaders.PointsLeadersDto>(false, Params.Stat.points, 10),
            3 => await League.RequestCurrentStatLeadersAsync<Leaders.WinsLeadersDto>(true, Params.Stat.wins, 10),
            _ => await League.RequestCurrentStatLeadersAsync<Leaders.PointsLeadersDto>(false, Params.Stat.points, 10),
        };

        Console.WriteLine(statLeadersData);
    }
}