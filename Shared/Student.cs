namespace Shared;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Address> Addresses { get; set; } = new List<Address>();
}