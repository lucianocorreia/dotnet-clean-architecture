using AutoMapper;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Commands;

public class UpdateLeaveAllocationCommandHandler(
    ILeaveAllocationRepository leaveAllocationRepository,
    IMapper mapper
) : IRequestHandler<UpdateLeaveAllocationCommand>
{
    private readonly ILeaveAllocationRepository leaveAllocationRepository = leaveAllocationRepository;
    private readonly IMapper mapper = mapper;

    public async Task Handle(UpdateLeaveAllocationCommand request, CancellationToken cancellationToken)
    {
        var leaveAllocation = mapper.Map<Domain.LeaveAllocation>(request.UpdateLeaveRequestDto);
        mapper.Map(request.UpdateLeaveRequestDto, leaveAllocation);

        await leaveAllocationRepository.UpdateAsync(leaveAllocation);
    }
}
