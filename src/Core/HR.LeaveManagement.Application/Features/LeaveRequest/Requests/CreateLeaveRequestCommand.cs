using HR.LeaveManagement.Application.Dtos;
using MediatR;

namespace HR.LeaveManagement.Application.LeaveRequests.Requests;

public class CreateLeaveRequestCommand : IRequest<int>
{
    public LeaveRequestDto LeaveRequestDto { get; set; } = default!;

}
