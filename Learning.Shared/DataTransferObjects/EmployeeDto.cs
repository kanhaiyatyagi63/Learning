using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Shared.DataTransferObjects
{
    public record EmployeeDto(Guid Id, string Name, int Age, string Position);

}
