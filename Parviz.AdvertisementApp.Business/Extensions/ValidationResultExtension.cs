using Parviz.AdvertisementApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parviz.AdvertisementApp.Business.Extensions
{
    public static class ValidationResultExtension
    {
        public static List<CustomValidationError> ConvertValidationFromCustomValidationError(this FluentValidation.Results.ValidationResult validationResult)
        {
            List<CustomValidationError> customValidationErrors = new List<CustomValidationError>();
            foreach (var x in validationResult.Errors)
            {
                customValidationErrors.Add(new()
                {
                    ErrorMessage = x.ErrorMessage,
                    PropertyName = x.PropertyName
                });
            }
            return customValidationErrors;
        }
    }
}
