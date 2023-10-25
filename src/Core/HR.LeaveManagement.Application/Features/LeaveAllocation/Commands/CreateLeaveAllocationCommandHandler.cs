using AutoMapper;
using HR.LeaveManagement.Application.LeaveAllocations.Requests;

using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Commands;

public class CreateLeaveAllocationCommandHandler(
    ILeaveAllocationRepository leaveAllocationRepository,
    IMapper mapper
) : IRequestHandler<CreateLeaveAllocationCommand, int>
{
    private readonly ILeaveAllocationRepository leaveAllocationRepository = leaveAllocationRepository;
    private readonly IMapper mapper = mapper;

    public async Task<int> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
    {
        var leaveAllocation = mapper.Map<Domain.LeaveAllocation>(request.CreateLeaceAllocationDto);
        leaveAllocation = await leaveAllocationRepository.AddAsync(leaveAllocation);
        return leaveAllocation.Id;
    }
}
