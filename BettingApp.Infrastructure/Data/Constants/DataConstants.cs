namespace BettingApp.Infrastructure.Data.Constants
{
    public static class DataConstants
    {
        public static class Competition
        {
            public const int NameMaxLength = 100;

            public const int DescriptionMaxLength = 1000;
        }

        public static class Country
        {
            public const int NameMaxLength = 60;
        }

        public static class Employee
        {
            public const int FirstNameMaxLength = 50;

            public const int LastNameMaxLength = 50;
        }

        public static class Season
        {
            public const int CodeMaxLength = 9;
        }

        public static class Team
        {
            public const int NameMaxLength = 100;
        }

        public static class UserCard
        {
            public const int NumberMaxLength = 19;

            public const int ExpirationMaxLength = 5;
        }

        public static class Currency
        {
            public const int ISOCodeMaxLength = 3;

            public const int DescriptionMaxLength = 30;
        }
    }
}
