using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Requests;

public class DeleteLeaveRequestCommand : IRequest
{
    public int Id { get; set; }
}
