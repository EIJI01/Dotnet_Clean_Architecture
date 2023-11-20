using HR.LeaveManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.DTOs
{
    public class LeaveTypeDto : BaseDto
    {
        public string Name { get; set; } = string.Empty;
        public string DefaultDays { get; set; } = string.Empty;
    }
}
