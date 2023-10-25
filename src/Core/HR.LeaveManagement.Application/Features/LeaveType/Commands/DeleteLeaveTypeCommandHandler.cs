using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveTypes.Requests;
using MediatR;

namespace HR.LeaveManagement.Application;

public class DeleteLeaveTypeCommandHandler(
    ILeaveTypeRepository leaveTypeRepository,
    IMapper mapper
) : IRequestHandler<DeleteLeaveTypeCommand>
{
    private readonly ILeaveTypeRepository leaveTypeRepository = leaveTypeRepository;
    private readonly IMapper mapper = mapper;

    public async Task Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        var leaveType = await leaveTypeRepository.GetByIdAsync(request.Id);

        await leaveTypeRepository.DeleteAsync(leaveType);
    }
}
