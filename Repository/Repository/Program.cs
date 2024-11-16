using Npgsql;
using Repository.Models;
using Repository.Repositories.Abstracts;
using Repository.Repositories.Implements;

namespace Repository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStudentRepository repo = new StudentPostgresRepository();
            repo.GetAll().ForEach(x => Console.WriteLine(x.Name + " " + x.Surname));
        }
    }
}
