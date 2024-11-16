using AdoNET.Helpers;
using AdoNET.Models;
using AdoNET.Services;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNET
{
    internal class Program
    {
        const string conString = "Server=.\\SQLEXPRESS;Database=BP215;Trusted_Connection=True;TrustServerCertificate=True";
        static void Main(string[] args)
        {
            Student std = new Student
            {
                Name = "Kanan",
                Surname = "Gurbanli",
                Code = "0012"
            };
            using (SqlConnection conn = new(conString))
            {
                //students = conn.Query<Student>("SELECT * FROM Students").ToList();
                conn.Execute("INSERT INTO Students (Name, Surname,Code, IsDeleted) VALUES (@Name, @Surname,@Code,0)", std);
            }
            //foreach (var item in students)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //ORM - Object-Related Mapping (Dapper, Entity Framework and etc.)

            //CreateStudent("Xalid", "Mamisov","0009");
            //ReadDataTable();
            //DeleteStudent(19);
            //StudentService.Add(new Student
            //{
            //    Name = "Togrul",
            //    Surname = "Mehdiyev",
            //    Code = "0010"
            //});
            //StudentService.Add(new Student
            //{
            //    Name = "Samir",
            //    Surname = "Habibov",
            //    Code = "0011"
            //});
            //StudentService.GetAll().ForEach(s => Console.WriteLine(s.Name + " " + s.Surname));

        }
        //static void CreateStudent(string name, string surname, string code)
        //{
        //    SqlHelper.Exec($"INSERT INTO Students VALUES (N'{name}',N'{surname}','{code}',0)");
        //}
        //static void DeleteStudent(int id)
        //{
        //    if (SqlHelper.Exec($"DELETE Students WHERE Id = {id}"))
        //    {
        //        Console.WriteLine("Student deleted successfully");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Student doesnt exist in database");
        //    }
        //}
        //static void ReadDataTable()
        //{
        //    string query = "SELECT * FROM Students WHERE IsDeleted = 0";
        //    //DataTable dt = new DataTable();
        //    //using (SqlConnection connection = new(conString))
        //    //{
        //    //    using (SqlDataAdapter sda = new(query, connection))
        //    //    {
        //    //        connection.Open();
        //    //        sda.Fill(dt);
        //    //    }
        //    //}
        //    foreach (DataRow item in SqlHelper.Read(query).Rows)
        //    {
        //        Console.WriteLine(item[0] + " " + item[1] + " " + item["Code"]);
        //    }
        //}
        //static void ReadWithReader()
        //{
        //    string query = "SELECT * FROM Students";
        //    using (SqlConnection conn = new SqlConnection(conString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            conn.Open();
        //            var reader = cmd.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                Console.WriteLine(reader[0] + " " + reader[1] + " " + reader["Code"]);
        //            }
        //        }
        //    }
        //}
        string query = "SELECT top 1 * FROM Users WHERE Username = '' or '1' = '1' and Password = 'pasword'";
    }
}
