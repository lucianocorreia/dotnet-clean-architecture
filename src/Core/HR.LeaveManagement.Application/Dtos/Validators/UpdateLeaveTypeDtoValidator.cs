using System.Data;
using FluentValidation;
using HR.LeaveManagement.Application.Dtos;

namespace HR.LeaveManagement.Application.Dtos.Validators;

public class UpdateLeaveTypeDtoValidator : AbstractValidator<LeaveTypeDto>
{
    public UpdateLeaveTypeDtoValidator()
    {
        Include(new LeaveTypeDtoValidator());

        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull();
    }
}

