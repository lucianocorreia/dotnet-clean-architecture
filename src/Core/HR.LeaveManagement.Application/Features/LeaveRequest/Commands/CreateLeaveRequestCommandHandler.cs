using AutoMapper;
using HR.LeaveManagement.Application.LeaveRequests.Requests;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Commands;

public class CreateLeaveRequestCommandHandler(
    ILeaveRequestRepository leaveRequestRepository,
    IMapper mapper
) : IRequestHandler<CreateLeaveRequestCommand, int>
{
    private readonly ILeaveRequestRepository leaveRequestRepository = leaveRequestRepository;
    private readonly IMapper mapper = mapper;

    public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
    {
        var leaveRequest = mapper.Map<Domain.LeaveRequest>(request.CreateLeaveRequestDto);
        leaveRequest = await leaveRequestRepository.AddAsync(leaveRequest);
        return leaveRequest.Id;
    }
}
