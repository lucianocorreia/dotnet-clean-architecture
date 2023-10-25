using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Requests;

public class DeleteLeaveAllocationCommand : IRequest
{
    public int Id { get; set; }
}
