namespace ConsoleApp;

public class Employee
{
    public int Id { get; init; }
    public string Name { get; set; }
    public Gender Gender { get; set; }
    public decimal Salary { get; set; }

    public Employee(int id, string name, Gender gender, decimal salary)
    {
        Id = id;
        Name = name;
        Gender = gender;
        Salary = salary;
    }

    protected bool Equals(Employee other)
    {
        return Id == other.Id;
    }

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Gender)}: {Gender}, {nameof(Salary)}: {Salary}";
    }
}

public enum Gender
{
    Male,
    Female
}
