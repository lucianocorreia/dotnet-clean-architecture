using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveAllocation.Requests;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Commands;

public class DeleteLeaveAllocationCommandHandler(
    ILeaveAllocationRepository leaveAllocationRepository,
    IMapper mapper
) : IRequestHandler<DeleteLeaveAllocationCommand>
{
    private readonly ILeaveAllocationRepository leaveAllocationRepository = leaveAllocationRepository;
    private readonly IMapper mapper = mapper;

    public async Task Handle(DeleteLeaveAllocationCommand request, CancellationToken cancellationToken)
    {
        var leaveAllocation = await leaveAllocationRepository.GetByIdAsync(request.Id);

        await leaveAllocationRepository.DeleteAsync(leaveAllocation);
    }
}
