namespace Repository.Models;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Code { get; set; }
    public bool IsDeleted { get; set; }
}
