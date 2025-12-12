using Prototype_DesignPattern;

public class AppointmentLetter : DocumentTemplate
{
    public AppointmentLetter(string body)
        : base("Appointment Letter", body, "Company Administration")
    {
    }

    public override DocumentTemplate Clone()
    {
        return new AppointmentLetter(this.Body);
    }

    public override void Customize(string name, string department, string extraInfo)
    {
        Body = $"Dear {name},\nYour appointment to the {department} department is confirmed.\n{extraInfo}";
    }
}
