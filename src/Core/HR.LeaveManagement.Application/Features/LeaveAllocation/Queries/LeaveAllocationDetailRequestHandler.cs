using AutoMapper;
using HR.LeaveManagement.Application.Dtos;
using HR.LeaveManagement.Application.Features.LeaveAllocation.Requests;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Queries;

public class LeaveAllocationDetailRequestHandler(
    ILeaveAllocationRepository leaveAllocationRepository,
    IMapper mapper
) : IRequestHandler<LeaveAllocationDetailRequest, LeaveAllocationDto>
{
    private readonly ILeaveAllocationRepository leaveAllocationRepository = leaveAllocationRepository;
    private readonly IMapper mapper = mapper;

    public async Task<LeaveAllocationDto> Handle(LeaveAllocationDetailRequest request, CancellationToken cancellationToken)
    {
        var leaveAllocation = await leaveAllocationRepository.GetLeaveAllocationWithDetails(request.Id);
        return mapper.Map<LeaveAllocationDto>(leaveAllocation);
    }
}
