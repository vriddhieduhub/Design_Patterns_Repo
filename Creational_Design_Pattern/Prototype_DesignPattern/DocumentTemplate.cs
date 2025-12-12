namespace Prototype_DesignPattern
{
    public abstract class DocumentTemplate : IDocumentPrototype<DocumentTemplate>
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }

        protected DocumentTemplate(string title, string body, string footer)
        {
            Title = title;
            Body = body;
            Footer = footer;
        }

        public abstract DocumentTemplate Clone();

        public abstract void Customize(string employeeName, string roleOrDept, string extraInfo);

        public void Print()
        {
            Console.WriteLine($"=== {Title} ===");
            Console.WriteLine($"Body:\n{Body}");
            Console.WriteLine($"Footer: {Footer}\n");
        }
    }

}