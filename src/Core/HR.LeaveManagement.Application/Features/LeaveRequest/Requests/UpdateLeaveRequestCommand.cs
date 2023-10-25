using HR.LeaveManagement.Application.Dtos;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Requests;

public class UpdateLeaveRequestCommand : IRequest
{
    public LeaveRequestDto LeaveRequestDto { get; set; } = default!;

    public UpdateLeaveRequestApprovalDto UpdateLeaveRequestApprovalDto { get; set; } = default!;
}
