using System.Text.Json;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        int action = person.DisplayMenu();
        while (action != 2)
        {
            if (action == 1)
            {
                Console.WriteLine("What is your file called?");
                string answer = Console.ReadLine();
                if(!(answer.Substring(answer.Length-4).Equals(".json")))
                {
                    answer+=".json";
                }
                string json = File.ReadAllText(answer);
                person = JsonSerializer.Deserialize<Person>(json);
            }
            if (action == 4)
            {
                person.Record();
            }
            if (action == 5)
            {
                Console.WriteLine("What is your eternal Goal?");
                Eternal eternal = new Eternal(100);
                eternal.Goal = Console.ReadLine();
                person.MyGoals.Add(eternal);
            }
            if (action == 6)
            {
                Console.WriteLine("What is your checklist Goal?");
                Checklist checklist = new Checklist(100, 10);
                checklist.Goal = Console.ReadLine();
                Console.WriteLine("How many times do you want to work on your goal?");
                checklist.Max=(int.Parse(Console.ReadLine()));
                person.MyGoals.Add(checklist);
            }
            if (action == 7)
            {
                Console.WriteLine("What is your simple Goal?");
                Single single = new Single(500);
                single.Goal = Console.ReadLine();
                person.MyGoals.Add(single);
            }
            action=person.DisplayMenu();
        }
        string jsonString = JsonSerializer.Serialize(person);
        Console.WriteLine("What would you like to name your file?");
        File.WriteAllText(Console.ReadLine() + ".json", jsonString);
    }
}