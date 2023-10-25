using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveRequest.Requests;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Commands;

public class DeleteLeaveRequestCommandHandler(
    ILeaveRequestRepository leaveRequestRepository,
    IMapper mapper
) : IRequestHandler<DeleteLeaveRequestCommand>
{
    private readonly ILeaveRequestRepository leaveRequestRepository = leaveRequestRepository;
    private readonly IMapper mapper = mapper;

    public async Task Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
    {
        var leaveRequest = await leaveRequestRepository.GetByIdAsync(request.Id);

        await leaveRequestRepository.DeleteAsync(leaveRequest);
    }
}
