namespace BettingApp.Core.Exceptions
{
    public class BettingAppException : ApplicationException 
    {
        public BettingAppException()
        {

        }

        public BettingAppException(string errorMessage)
            : base(errorMessage)
        {

        }
    }
}
