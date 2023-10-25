using AutoMapper;
using HR.LeaveManagement.Application.LeaveAllocations.Requests;
using HR.LeaveManagement.Domain;
using MediatR;

namespace HR.LeaveManagement.Application;

public class LeaveAllocationCommandHandler(
    ILeaveAllocationRepository leaveAllocationRepository,
    IMapper mapper
) : IRequestHandler<LeaveAllocationCommand, int>
{
    private readonly ILeaveAllocationRepository leaveAllocationRepository = leaveAllocationRepository;
    private readonly IMapper mapper = mapper;

    public async Task<int> Handle(LeaveAllocationCommand request, CancellationToken cancellationToken)
    {
        var leaveAllocation = mapper.Map<LeaveAllocation>(request.LeaveAllocationDto);
        leaveAllocation = await leaveAllocationRepository.AddAsync(leaveAllocation);
        return leaveAllocation.Id;
    }
}
