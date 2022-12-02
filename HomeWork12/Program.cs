using System;
using System.Security.Principal;

namespace Home
{
    class PersonEvent
    {
        public PersonEvent(string m)
        {
            Message = m;
        }
        public string Message
        {
            get; set; 
        }
    }
    class Person
    {
        public delegate void ThisEvent(Person person, PersonEvent e);
        public static event ThisEvent? Notify;
        public Person(string meropriyatie)
        {
            Meropriyatie = meropriyatie.ToLower();
        }

        string Meropriyatie { get; set; }
        public void Reaction(string s)
        {
            string[] arrayPhrases = { "\"Ура, я так счастлив(а), что это наконец произошло!!!\"", "Сюда!!!", "Наконец-то!","Кайф!" };
            Random random = new Random(); int f = random.Next(arrayPhrases.Length);
            if(Meropriyatie.Contains(s.ToLower()))    
                Notify?.Invoke(this, new PersonEvent(arrayPhrases[f]));//да, кринж, но наглядно
            else
                Notify?.Invoke(this, new PersonEvent("Ваще п***й"));
        }
        public void DeletePodpiska(string s)
        {
            Meropriyatie = Meropriyatie.Replace(s, string.Empty).ToLower();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person.Notify += E;
            Person person1 = new Person("Концерт Папин Олимпос");
            Person person2 = new Person("Концерт Shadowraze");
            Person person3 = new Person("Пара по проге(практика)"); //тУМаков-некруто

            string s = Console.ReadLine();
            person1.Reaction(s);
            person1.DeletePodpiska(s);
            person1.Reaction(s);
            //person2.Reaction(s);
            //person3.Reaction(s);
            void E(Person sender, PersonEvent e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}