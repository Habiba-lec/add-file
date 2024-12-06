
public class Employee
{
    public string Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }

    public virtual string GetDetails()
    {
        return $"{Name} is an employee.";
    }
}

