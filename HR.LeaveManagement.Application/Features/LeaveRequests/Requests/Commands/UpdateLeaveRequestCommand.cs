﻿using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using HR.LeaveManagement.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class UpdateLeaveRequestCommand : IRequest<BaseCommandResponse>
    {
        public int Id { get; set; }
        public UpdateLeaveRequestDto LeaveRequestDto { get; set; }
        public ChangeLeaveRequestApprovalDto ChangeLeaveRequestApprovalDto { get; set;}
    }
}
