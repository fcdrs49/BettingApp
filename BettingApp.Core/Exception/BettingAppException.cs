namespace BettingApp.Core.Exception
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
