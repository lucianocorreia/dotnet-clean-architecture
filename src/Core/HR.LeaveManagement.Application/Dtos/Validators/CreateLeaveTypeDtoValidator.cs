using FluentValidation;
using HR.LeaveManagement.Application.Dtos;

namespace HR.LeaveManagement.Application.Dtos.Validators;

public class CreateLeaveTypeDtoValidator : AbstractValidator<ILeaveTypeDto>
{
    public CreateLeaveTypeDtoValidator()
    {
        Include(new LeaveTypeDtoValidator());
    }
}

