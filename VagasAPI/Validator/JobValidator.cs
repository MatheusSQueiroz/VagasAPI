using FluentValidation;
using VagasAPI.Model;

namespace VagasAPI.Validator
{
    public class JobValidator : AbstractValidator<Job>
    {
        public JobValidator() 
        {
            RuleFor(j => j.Title)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(50);

            RuleFor(j => j.Type)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(50);

            RuleFor(j => j.Description)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(500);

            RuleFor(j => j.Stack)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(50);

            RuleFor(j => j.Location)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(500);

            RuleFor(j => j.Url)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(500);

            RuleFor(j => j.Company)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(50);

            RuleFor(j => j.Company_url)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(500);
        }
    }
}
