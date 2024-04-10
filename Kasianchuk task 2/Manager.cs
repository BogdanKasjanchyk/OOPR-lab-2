using Kasianchuk_task_2;

internal class Manager : Human
{
    public Concert Concert { get; set; }

    public new string Name { get; set; }

    public Manager() { }

    public Manager(string name, string surname, int age, string sex, Concert concert)
        : base(name, surname, age, sex)
    {
        Concert = concert;
        this.Name = name;
    }

    public void SetConcertDetails(string concertName, string location, string date, int ticketPrice, bool isSoldOut)
    {
        Concert.ConcertName = concertName;
        Concert.Location = location;
        Concert.Date = date;
        Concert.TicketPrice = ticketPrice;
        Concert.IsSoldOut = isSoldOut;
    }

    public void NotifySinger(Singer singer)
    {
        singer.ReceiveNotification();
    }

    public override void Display()
    {
        base.Display();
        MessageBox.Show($"Manager Name: {Name}");
    }
}
