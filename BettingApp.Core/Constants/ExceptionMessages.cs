namespace BettingApp.Core.Constants
{
    public static class ExceptionMessages
    {
        public const string NotFound = "{0} with Id {1} can not be found!";
        public const string EntityExistsMessageOnDelete = "{0} {1} can not be deleted! {2} for this {0} exist!";
        public const string MinAgeLimitErrorMessage = "You are not allowed to register! You need to be at least {0} years old!";
        public const string MaxAgeLimitErrorMessage = "You are not allowed to register! You need to be at most {0} years old!";
    }
}
