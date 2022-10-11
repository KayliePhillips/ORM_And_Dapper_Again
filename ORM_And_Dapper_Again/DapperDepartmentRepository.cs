using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_And_Dapper_Again
{
    public class DapperDepartmentRepository : IDepartmentRepository
    {

        private readonly IDbConnection _conn;

        public DapperDepartmentRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _conn.Query<Department>("SELECT * FROM Departments");
        }


        public void InsertDepartment(string Name)
        {
            _conn.Execute("INSERT INTO Departments (Name) VALUES (@Name);",
                new {Name = Name});
        }


    }
}
