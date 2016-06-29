using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.ViewModels
{
    // Custom Validation by deriving from ValidationAttribute Class
    public class FutureDate : ValidationAttribute
    {
        // Override IsValid method
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), 
                "d MMM yyyy", 
                CultureInfo.CurrentCulture,
                DateTimeStyles.None, 
                out dateTime);

            return (isValid && dateTime > DateTime.Now);
        }
    }
}