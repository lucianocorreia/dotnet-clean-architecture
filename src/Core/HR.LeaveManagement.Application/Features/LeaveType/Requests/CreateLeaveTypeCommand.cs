﻿using HR.LeaveManagement.Application.Dtos;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests;

public class CreateLeaveTypeCommand : IRequest<int>
{
    public CreateLeaveTypeDto CreateLeaveTypeDto { get; set; } = default!;

}
