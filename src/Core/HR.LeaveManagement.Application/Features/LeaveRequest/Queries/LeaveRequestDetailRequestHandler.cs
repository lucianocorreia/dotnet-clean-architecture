using AutoMapper;
using HR.LeaveManagement.Application.Dtos;
using HR.LeaveManagement.Application.Features.LeaveRequest.Requests;
using MediatR;

namespace HR.LeaveManagement.Application;

public class LeaveRequestDetailRequestHandler(
    ILeaveRequestRepository leaveRequestRepository,
    IMapper mapper
) : IRequestHandler<LeaveRequestDetailRequest, LeaveRequestDto>
{
    private readonly ILeaveRequestRepository leaveRequestRepository = leaveRequestRepository;
    private readonly IMapper mapper = mapper;

    public async Task<LeaveRequestDto> Handle(LeaveRequestDetailRequest request, CancellationToken cancellationToken)
    {
        var leaveRequest = await leaveRequestRepository.GetLeaveRequestWithDetails(request.Id);
        return mapper.Map<LeaveRequestDto>(leaveRequest);
    }
}
