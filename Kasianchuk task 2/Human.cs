using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasianchuk_task_2
{
    internal class Human
    {
        private string Name { get; set; }
        protected string Surname { get; set; }
        protected int Age { get; set; }
        protected string Sex { get; set; }

        public string name
        { get { return Name; } 
          set { Name = value; }
        }

        public string surname
        {
            get { return Surname; }
            set { Surname = value; }
        }

        public int age
        {
            get { return Age; }
            set { Age = value; }
        }

        public string sex
        {
            get { return Sex; }
            set { Sex = value; }
        }

        public static List<Human> Humans { get; set; } = new List<Human>();

        public static void AddToHumansList(Human human)
        {
            Humans.Add(human);
        }
        public static void DisplayHumansList()
        {
            foreach (var human in Humans)
            {
                Console.WriteLine(human);
            }
        }

        public Human() { }

        public Human(string name, string surname, int age, string sex)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Sex = sex;
        }

        public virtual void Display()
        {
            Console.WriteLine("Ім'я: {Name}, Прізвище: {Surname}, Вік: {Age}, Стать: {Sex}");
        }

    }
}
