namespace BettingApp.Core.Models.Transaction
{
    public class CreditCardModel
    {
        public string CardNumber { get; set; } = null!;

        public int ExpirationMonth { get; set; }

        public int ExpirationYear { get; set; }
    }
}
