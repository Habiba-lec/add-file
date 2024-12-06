public class Intern : Employee
{
    public Intern(string name) : base(name) { }

    public override string GetDetails()
    {
        return $"{Name} is an intern learning the ropes.";
    }
}
