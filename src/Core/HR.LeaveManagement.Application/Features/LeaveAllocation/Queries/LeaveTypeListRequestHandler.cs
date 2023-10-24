using AutoMapper;
using HR.LeaveManagement.Application.Dtos;
using HR.LeaveManagement.Application.Features.LeaveAllocation.Requests;
using MediatR;

namespace HR.LeaveManagement.Application;

public class LeaveTypeListRequestHandler(
    ILeaveAllocationRepository leaveAllocationRepository,
    IMapper mapper
) : IRequestHandler<LeaveTypeListRequest, List<LeaveAllocationDto>>
{
    private readonly ILeaveAllocationRepository leaveAllocationRepository = leaveAllocationRepository;
    private readonly IMapper mapper = mapper;

    public async Task<List<LeaveAllocationDto>> Handle(LeaveTypeListRequest request, CancellationToken cancellationToken)
    {
        var LeaveAllocation = await leaveAllocationRepository.GetLeaveAllocationsWithDetails();
        return mapper.Map<List<LeaveAllocationDto>>(LeaveAllocation);
    }
}
