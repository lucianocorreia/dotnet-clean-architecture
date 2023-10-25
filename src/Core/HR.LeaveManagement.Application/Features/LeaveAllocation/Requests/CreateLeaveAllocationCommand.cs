using HR.LeaveManagement.Application.Dtos;
using MediatR;

namespace HR.LeaveManagement.Application.LeaveAllocations.Requests;

public class CreateLeaveAllocationCommand : IRequest<int>
{
    public CreateLeaveAllocationDto CreateLeaceAllocationDto { get; set; } = default!;
}
