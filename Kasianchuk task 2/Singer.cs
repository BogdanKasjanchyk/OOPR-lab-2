using Kasianchuk_task_2;

internal class Singer : Human
{
    public int Fee { get; set; }

    public Singer() { }

    public Singer(string name, string surname, int age, string sex, int fee)
        : base(name, surname, age, sex)
    {
        Fee = fee;
    }

    public void ReceiveNotification()
    {
        Console.WriteLine("Singer received the concert details.");
    }
}
