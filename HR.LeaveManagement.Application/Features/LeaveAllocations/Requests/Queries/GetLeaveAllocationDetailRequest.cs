﻿using HR.LeaveManagement.Application.DTOs.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Queries
{
    internal class GetLeaveAllocationDetailRequest : IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}
