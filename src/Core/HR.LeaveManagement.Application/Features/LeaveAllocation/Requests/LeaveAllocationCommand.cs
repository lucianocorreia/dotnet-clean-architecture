using HR.LeaveManagement.Application.Dtos;
using MediatR;

namespace HR.LeaveManagement.Application.LeaveAllocations.Requests;

public class LeaveAllocationCommand : IRequest<int>
{
    public CreateLeaceAllocationDto CreateLeaceAllocationDto { get; set; } = default!;
}
