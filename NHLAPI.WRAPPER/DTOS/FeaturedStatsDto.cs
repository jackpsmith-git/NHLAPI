﻿using NHLAPI.WRAPPER.DTOS.Player;

namespace NHLAPI.WRAPPER.DTOS;

public record FeaturedStatsDto(
    int season,
    PlayerStatsSeasonDto regularSeason
    )
{
    public override string ToString() => regularSeason.ToString();
}