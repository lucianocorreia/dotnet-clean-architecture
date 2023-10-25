using HR.LeaveManagement.Application.Dtos;
using MediatR;

namespace HR.LeaveManagement.Application;

public class UpdateLeaveAllocationCommand : IRequest
{
    public UpdateLeaveRequestDto UpdateLeaveRequestDto { get; set; } = default!;
}
