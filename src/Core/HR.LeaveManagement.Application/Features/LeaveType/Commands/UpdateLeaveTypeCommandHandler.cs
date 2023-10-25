using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveTypes.Requests;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Commands;

public class UpdateLeaveTypeCommandHandler(
    ILeaveTypeRepository leaveTypeRepository,
    IMapper mapper
) : IRequestHandler<UpdateLeaveTypeCommand>
{
    private readonly ILeaveTypeRepository leaveTypeRepository = leaveTypeRepository;
    private readonly IMapper mapper = mapper;

    public async Task Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        var leaveType = await leaveTypeRepository.GetByIdAsync(request.LeaveTypeDto.Id);
        mapper.Map(request.LeaveTypeDto, leaveType);

        await leaveTypeRepository.UpdateAsync(leaveType);
    }
}
