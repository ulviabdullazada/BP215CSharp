using Repository.Models;

namespace Repository.Repositories.Abstracts
{
    interface IStudentRepository
    {
        List<Student> GetAll();
        Student? GetById(int id);
        bool Create(Student data);
        bool Delete(int id);
        bool Update(int id, Student data);
    }
}
