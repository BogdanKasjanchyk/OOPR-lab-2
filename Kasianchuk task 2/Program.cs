namespace Kasianchuk_task_2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Виведе null, оскільки властивість Name в класі Human не була ініціалізована

            Human[] humans = new Human[3];
            humans[0] = new Manager();
            humans[1] = new Singer();
            humans[2] = new Visitor();

            List<Visitor> visitors = new List<Visitor>();
            visitors.Add(new Visitor("Mykola", "Stapanov", 11, "Male", 123, "Гопак"));
            visitors.Add(new Visitor("Іван", "Іванов", 22, "Male", 124, "Концерт 1"));
            visitors.Add(new Visitor("Марія", "Петренко", 33, "Female", 125, "Концерт 2"));

            using (StreamWriter writer = new StreamWriter("RegisteredVisitors.txt", true))
            {
                foreach (Visitor visitor in visitors)
                {
                    writer.WriteLine($"Ім'я: {visitor.name}, Прізвище: {visitor.surname}, Стать: {visitor.sex}, Вік: {visitor.age}, Обраний концерт: {visitor.chosenConcert}, ID: {visitor.GenerateTicketId()}");
                }
            }


            Application.Run(new Form1());
        }
    }
}
