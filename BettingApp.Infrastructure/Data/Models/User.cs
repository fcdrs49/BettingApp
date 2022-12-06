﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.User;

namespace BettingApp.Infrastructure.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        [StringLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        public IEnumerable<UserCard> Cards { get; set; }
            = new List<UserCard>();

        public IEnumerable<Bet> Bets { get; set; }
            = new List<Bet>();

        public IEnumerable<Transaction> Transactions { get; set; }
            = new List<Transaction>();
    }
}
