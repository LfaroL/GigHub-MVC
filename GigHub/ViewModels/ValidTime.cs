using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.ViewModels
{
    // Custom Validation by deriving from ValidationAttribute Class
    public class ValidTime : ValidationAttribute

    {
        // Override IsValid method
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), 
                "HH:mm", 
                CultureInfo.CurrentCulture,
                DateTimeStyles.None, 
                out dateTime);

            return (isValid);
        }
    }
}