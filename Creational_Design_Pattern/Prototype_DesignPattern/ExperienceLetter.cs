using Prototype_DesignPattern;

public class ExperienceLetter : DocumentTemplate
{
    public ExperienceLetter(string body)
        : base("Experience Letter", body, "HR & Admin Dept.")
    {
    }

    public override DocumentTemplate Clone()
    {
        return new ExperienceLetter(this.Body);
    }

    public override void Customize(string name, string years, string extraInfo)
    {
        Body = $"To whom it may concern,\n{name} has worked with us for {years} years.\n{extraInfo}";
    }
}
