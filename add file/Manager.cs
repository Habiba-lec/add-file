public class Manager : Employee
{
    public Manager(string name) : base(name) { }

    public override string GetDetails()
    {
        return $"{Name} is a manager responsible for leading the team.";
    }
}
