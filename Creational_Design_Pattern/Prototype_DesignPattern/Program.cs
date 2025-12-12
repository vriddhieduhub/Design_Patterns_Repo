namespace Prototype_DesignPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            // Base templates
            var baseOffer = new OfferLetter("Base offer letter template text.");
            var baseAppointment = new AppointmentLetter("Base appointment letter text.");
            var baseExperience = new ExperienceLetter("Base experience letter text.");

            // Clone & customize Offer Letter
            var offerJohn = baseOffer.Clone();
            offerJohn.Customize("John Doe", "Software Engineer", "Joining Date: 10 March 2025.");

            // Clone & customize Appointment Letter
            var appointJohn = baseAppointment.Clone();
            appointJohn.Customize("John Doe", "IT", "Please report to HR at 9 AM.");

            // Clone & customize Experience Letter
            var expJohn = baseExperience.Clone();
            expJohn.Customize("John Doe", "4", "He has demonstrated excellent performance.");

            // Print all
            offerJohn.Print();
            appointJohn.Print();
            expJohn.Print();

            Console.WriteLine("----------END of  from Prototype_DesignPattern!---------");
        }
    }
}

/*---------

A company has multiple types of documents:

Offer Letter
Appointment Letter
Experience Letter

Each has a base template, but must be cloned and customized per employee.

Prototype lets us clone objects instead of creating from scratch.

*/