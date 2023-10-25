using HR.LeaveManagement.Application.Dtos;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests;

public class UpdateLeaveTypeCommand : IRequest
{
    public LeaveTypeDto LeaveTypeDto { get; set; } = default!;
}
