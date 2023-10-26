using FluentValidation;
using HR.LeaveManagement.Application.Dtos;

namespace HR.LeaveManagement.Application.Dtos.Validators;

public class LeaveRequestDtoValidator : AbstractValidator<ILeaveRequestDto>
{
    private readonly ILeaveTypeRepository leaveTypeRepository;

    public LeaveRequestDtoValidator(ILeaveTypeRepository leaveTypeRepository)
    {
        RuleFor(p => p.StartDate)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .LessThan(p => p.EndDate).WithMessage("{PropertyName} must be less than End Date.");

        RuleFor(p => p.EndDate)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .GreaterThan(p => p.StartDate).WithMessage("{PropertyName} must be greater than Start Date.");

        RuleFor(p => p.LeaveTypeId)
            .GreaterThan(0).WithMessage("{PropertyName} is required.")
            .MustAsync(this.LeaveTypeExists).WithMessage("{PropertyName} does not exist.");
        this.leaveTypeRepository = leaveTypeRepository;
    }

    private async Task<bool> LeaveTypeExists(int id, CancellationToken token)
    {
        var leaveTypeExists = await leaveTypeRepository.Exists(id);
        return !leaveTypeExists;
    }
}
