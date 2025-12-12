using Prototype_DesignPattern;

public class OfferLetter : DocumentTemplate
{
    public OfferLetter(string body)
        : base("Offer Letter", body, "HR Department")
    {
    }

    public override DocumentTemplate Clone()
    {
        return new OfferLetter(this.Body);
    }

    public override void Customize(string name, string position, string extraInfo)
    {
        Body = $"Dear {name},\nWe are pleased to offer you the role of {position}.\n{extraInfo}";
    }
}
