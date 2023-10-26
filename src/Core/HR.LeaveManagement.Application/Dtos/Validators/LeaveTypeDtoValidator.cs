using FluentValidation;

namespace HR.LeaveManagement.Application.Dtos.Validators;

public class LeaveTypeDtoValidator : AbstractValidator<ILeaveTypeDto>
{
    public LeaveTypeDtoValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

        RuleFor(p => p.DefaultDays)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .GreaterThan(0).WithMessage("{PropertyName} must be greater than zero.");
    }
}
