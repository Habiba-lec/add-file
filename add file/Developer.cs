public class Developer : Employee
{
    public Developer(string name) : base(name) { }

    public override string GetDetails()
    {
        return $"{Name} is a developer writing and maintaining code.";
    }
}

