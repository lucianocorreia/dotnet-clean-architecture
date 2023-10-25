using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveRequest.Requests;
using MediatR;

namespace HR.LeaveManagement.Application;

public class UpdateLeaveRequestCommandHandler(
    ILeaveRequestRepository leaveRequestRepository,
    IMapper mapper
) : IRequestHandler<UpdateLeaveRequestCommand>
{
    private readonly ILeaveRequestRepository leaveRequestRepository = leaveRequestRepository;
    private readonly IMapper mapper = mapper;

    public async Task Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
    {
        var leaveRequest = await leaveRequestRepository.GetByIdAsync(request.UpdateLeaveRequestApprovalDto.Id);

        if (request.LeaveRequestDto != null)
        {
            mapper.Map(request.LeaveRequestDto, leaveRequest);

            await leaveRequestRepository.UpdateAsync(leaveRequest);
        }
        else if (request.UpdateLeaveRequestApprovalDto != null)
        {
            await leaveRequestRepository.UpdateApprovalStatus(leaveRequest, request.UpdateLeaveRequestApprovalDto.Approved);
        }
    }
}
