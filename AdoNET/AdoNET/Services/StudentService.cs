using AdoNET.Helpers;
using AdoNET.Models;
using System.Data;

namespace AdoNET.Services
{
    static class StudentService
    {
        public static void Add(Student std)
        {
            string query = $"INSERT INTO Students VALUES (N'{std.Name}',N'{std.Surname}',N'{std.Code}',0)";
            SqlHelper.Exec(query);
        }
        public static List<Student> GetAll()
        {
            string query = "SELECT * FROM Students";
            var dataTable = SqlHelper.Read(query);
            List<Student> students = new List<Student>();
            foreach (DataRow dr in dataTable.Rows)
            {
                students.Add(new Student
                {
                    Id = (int)dr["Id"],
                    Code = (string)dr["Code"],
                    IsDeleted = (bool)dr["IsDeleted"],
                    Name = (string)dr["Name"],
                    Surname = (string)dr["Surname"]
                });
            }
            return students;
        }
    }
}
