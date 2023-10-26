using System.ComponentModel.DataAnnotations;
using AutoMapper;
using HR.LeaveManagement.Application.Dtos.Validators;
using HR.LeaveManagement.Application.Features.LeaveTypes.Requests;
using HR.LeaveManagement.Domain;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Commands;

public class CreateLeaveTypeCommandHandler(
    ILeaveTypeRepository leaveTypeRepository,
    IMapper mapper
) : IRequestHandler<CreateLeaveTypeCommand, int>
{
    private readonly ILeaveTypeRepository leaveTypeRepository = leaveTypeRepository;
    private readonly IMapper mapper = mapper;

    public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateLeaveTypeDtoValidator();
        var validatorResult = await validator.ValidateAsync(request.CreateLeaveTypeDto, cancellationToken);
        if (!validatorResult.IsValid)
            throw new Exception();

        var leaveType = mapper.Map<LeaveType>(request.CreateLeaveTypeDto);
        leaveType = await leaveTypeRepository.AddAsync(leaveType);
        return leaveType.Id;
    }
}
