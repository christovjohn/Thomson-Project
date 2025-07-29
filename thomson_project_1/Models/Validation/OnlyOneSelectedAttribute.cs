using System.ComponentModel.DataAnnotations;
namespace thomson_project_1.Models.Validation
{
    public class OnlyOneSelectedAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = (ContactFormModel)validationContext.ObjectInstance;

            if (model.Complaints && model.Enquiry)
            {
                return new ValidationResult("You can select either Complaints or Enquiry, not both.");
            }

            if (!model.Complaints && !model.Enquiry)
            {
                return new ValidationResult("Please select either Complaints or Enquiry.");
            }

            return ValidationResult.Success;
        }
    }
}
