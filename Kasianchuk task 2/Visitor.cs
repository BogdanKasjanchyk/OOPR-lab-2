using Kasianchuk_task_2;

internal sealed class Visitor : Human
{
    protected string ChosenConcert { get; set; }
    public int TicketId { get; set; }

    public Visitor() { }

    public Visitor(string name, string surname, int age, string sex, int TicketId, string chosenConcert)
        : base(name, surname, age, sex)
    {
        TicketId = GenerateTicketId();
        this.chosenConcert = chosenConcert;
    }

    public string chosenConcert
    {
        get { return ChosenConcert; }
        set { ChosenConcert = value; }
    }

    public int GenerateTicketId()
    {
        Random random = new Random();
        return random.Next(100, 1000); // Генерує випадкове число від 100 до 999
    }
}
