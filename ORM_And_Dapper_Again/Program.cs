using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using ORM_And_Dapper_Again;
//^^^^MUST HAVE USING DIRECTIVES^^^^

var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
string connString = config.GetConnectionString("DefaultConnection");
IDbConnection conn = new MySqlConnection(connString);


var departmentRepo = new DapperDepartmentRepository(conn);

var departments = departmentRepo.GetAllDepartments();

 
foreach (var department in departments)
{
    Console.WriteLine($"{department.DepartmentID} {department.Name}");
}