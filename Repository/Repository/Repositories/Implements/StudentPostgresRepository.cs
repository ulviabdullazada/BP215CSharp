using Npgsql;
using Repository.Models;
using Repository.Repositories.Abstracts;
using System.Collections.Generic;
using System.Data;

namespace Repository.Repositories.Implements;
class StudentPostgresRepository : IStudentRepository
{
    public bool Create(Student data)
    {
        
        throw new NotImplementedException();
    }
    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }
    public List<Student> GetAll()
    {
        using NpgsqlConnection conn = new("Server=127.0.0.1;Port=5432;Database=postgres;User Id=postgres;Password=pass123;");
        using NpgsqlDataAdapter nda = new("SELECT * FROM Students", conn);
        DataTable dt = new DataTable();
        conn.Open();
        nda.Fill(dt);
        conn.Close();
        List<Student> list = new();
        foreach (DataRow item in dt.Rows)
        {
            list.Add(new Student
            {
                Id = Convert.ToInt32(item[0]),
                Name = item[1].ToString(),
                Surname = item[2].ToString(),
                Code = item[3].ToString(),
            });
        }
        return list;
    }
    public Student? GetById(int id)
    {
        throw new NotImplementedException();
    }
    public bool Update(int id, Student data)
    {
        throw new NotImplementedException();
    }
}
