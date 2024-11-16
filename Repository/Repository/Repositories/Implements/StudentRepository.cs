using Repository.Helpers;
using Repository.Models;
using Repository.Repositories.Abstracts;
using System.Data;

namespace Repository.Repositories.Implements;

class StudentRepository : IStudentRepository
{
    public bool Create(Student data)
    {
        return SqlHelper.Exec($"INSERT INTO Students VALUES (N'{data.Name}',N'{data.Surname}','{data.Code}',0)");
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Student> GetAll()
    {
        List<Student> list = [];
        var dt = SqlHelper.Read("SELECT * FROM Students");
        foreach (DataRow item in dt.Rows)
        {
            list.Add(new Student
            {
                Id = Convert.ToInt32(item[0]),
                Name = item[1].ToString(),
                Surname = item[2].ToString(),
                Code = item[3].ToString(),
                IsDeleted = Convert.ToBoolean(item[4])
            });
        }
        return list;
    }

    public Student? GetById(int id)
    {
        var dt = SqlHelper.Read("SELECT * FROM Students WHERE Id = " + id);
        if (dt.Rows.Count > 0)
        {
            return new Student
            {
                Id = Convert.ToInt32(dt.Rows[0]),
                Name = dt.Rows[1].ToString(),
                Surname = dt.Rows[2].ToString(),
                Code = dt.Rows[3].ToString(),
                IsDeleted = Convert.ToBoolean(dt.Rows[4])
            };
        }
        return null;
    }

    public bool Update(int id, Student data)
    {
        throw new NotImplementedException();
    }
}
