using System.ComponentModel.DataAnnotations;
using static BettingApp.Core.Constants.ExceptionMessages;

namespace BettingApp.Core.ValidationAttributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MinAgeAttribute : ValidationAttribute
    {
        private readonly int _limit;

        public MinAgeAttribute(int limit)
        {
            _limit = limit;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var bDay = DateTime.Parse(value.ToString());
            var today = DateTime.Today;
            var age = today.Year - bDay.Year;
            if (bDay > today.AddYears(-age))
            {
                age--;
            }

            if (age >= _limit) return ValidationResult.Success;

            var result = new ValidationResult(string.Format(MinAgeLimitErrorMessage, _limit));
            return result;
        }
    }
}
