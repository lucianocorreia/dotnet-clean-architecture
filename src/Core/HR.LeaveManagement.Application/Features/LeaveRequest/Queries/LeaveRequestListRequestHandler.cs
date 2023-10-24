using AutoMapper;
using HR.LeaveManagement.Application.Dtos;
using HR.LeaveManagement.Application.Features.LeaveRequest.Requests;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Queries;

public class LeaveRequestListRequestHandler(
    ILeaveRequestRepository leaveRequestRepository,
    IMapper mapper
) : IRequestHandler<LeaveRequestListRequest, List<LeaveRequestDto>>
{
    private readonly ILeaveRequestRepository leaveRequestRepository = leaveRequestRepository;
    private readonly IMapper mapper = mapper;

    public async Task<List<LeaveRequestDto>> Handle(LeaveRequestListRequest request, CancellationToken cancellationToken)
    {
        var leaveRequests = await leaveRequestRepository.GetLeaveRequestsWithDetails();
        return mapper.Map<List<LeaveRequestDto>>(leaveRequests);
    }
}
