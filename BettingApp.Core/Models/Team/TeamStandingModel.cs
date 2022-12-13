﻿namespace BettingApp.Core.Models.Team
{
    public class TeamStandingModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Matches { get; set; }

        public int Wins { get; set; }

        public int Draws { get; set; }

        public int Losses { get; set; }

        public int GoalsFor { get; set; }

        public int GoalsAgainst { get; set; }

        public int Points { get; set; }

        public string? ImageUrl { get; set; }
    }
}
