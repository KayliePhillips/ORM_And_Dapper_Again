using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_And_Dapper_Again
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();

    }
}
