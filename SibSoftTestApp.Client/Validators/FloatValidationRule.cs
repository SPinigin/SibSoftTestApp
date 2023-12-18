using System.Globalization;
using System.Windows.Controls;

namespace SibSoftTestApp.Client.Validators
{
    public class FloatValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string input = value as string;
            
            if(string.IsNullOrEmpty(input))
            {
                return new ValidationResult(false, "Введите число");
            }

            bool isValid = double.TryParse(input,NumberStyles.Float,cultureInfo,out double result);

            if (!isValid)
            {
                return new ValidationResult(false, "Введите корректное число");
            }

            return ValidationResult.ValidResult;
        }
    }
}