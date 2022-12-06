namespace BettingApp.Infrastructure.Data.Constants
{
    public static class DataConstants
    {
        public static class Common
        {
            public const int ImageUrlMinLength = 10;
            public const int ImageUrlMaxLength = 1024;
        }

        public static class Competition
        {
            public const int NameMaxLength = 100;

            public const int DescriptionMaxLength = 1000;
        }

        public static class Country
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 60;
        }

        public static class Employee
        {
            public const int FirstNameMinLength = 3;
            public const int FirstNameMaxLength = 50;

            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 50;
        }

        public static class Season
        {
            public const int CodeMinLength = 4;
            public const int CodeMaxLength = 9;
        }

        public static class Team
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 100;
        }

        public static class UserCard
        {
            public const int NumberMaxLength = 19;

            public const int ExpirationMaxLength = 5;
        }

        public static class Currency
        {
            public const int ISOCodeLength = 3;

            public const int DescriptionMinLength = 3;
            public const int DescriptionMaxLength = 30;

            public const int ShortDescriptionMinLength = 1; 
            public const int ShortDescriptionMaxLength = 5;
        }

        public static class User
        {
            public const int FirstNameMaxLength = 30;

            public const int LastNameMaxLength = 30;
        }
    }
}
