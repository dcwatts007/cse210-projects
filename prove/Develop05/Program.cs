using System.Text.Json;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json.Serialization;
using System.Formats.Asn1;
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
                if (!(answer.Substring(answer.Length - 4).Equals(".txt")))
                {
                    answer += ".txt";
                }
                person = DeserializePerson(answer);
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
                checklist.Max = (int.Parse(Console.ReadLine()));
                person.MyGoals.Add(checklist);
            }
            if (action == 7)
            {
                Console.WriteLine("What is your simple Goal?");
                Single single = new Single(500);
                single.Goal = Console.ReadLine();
                person.MyGoals.Add(single);
            }
            action = person.DisplayMenu();
        }
        Console.WriteLine("What would you like to name your file?");
        SerializePerson(person, Console.ReadLine());

    }
    public static void SerializePerson(Person person, String fileName)
    {
        if (!fileName.Substring(fileName.Length - 4).Equals(".txt"))
        {
            fileName += ".txt";
        }
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(person.Points);
            foreach (Goals goal in person.MyGoals)
            {
                outputFile.WriteLine(goal.Type);
                outputFile.WriteLine(goal.Goal);
                outputFile.WriteLine(goal.Complete);

                if (goal.Type == "Checklist")
                {
                    Checklist checklist = new Checklist();
                    checklist = (Checklist)goal;
                    outputFile.WriteLine(checklist.Max);
                }
            }
        }
    }
    public static Person DeserializePerson(string fileName)
    {
        if(!fileName.Substring(fileName.Length-4).Equals(".txt"))
        {
            fileName+=".txt";
        }
        Person person = new Person();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        person.Points = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            if (lines[i] == "Eternal")
            {
                Eternal eternal = new Eternal();
                i++;
                eternal.Goal = lines[i];
                i++;
                eternal.Complete = bool.Parse(lines[i]);
                person.MyGoals.Add(eternal);
            }
            else if (lines[i] == "checklist")
            {
                Checklist eternal = new Checklist();
                i++;
                eternal.Goal = lines[i];
                i++;
                eternal.Complete = bool.Parse(lines[i]);
                i++;
                eternal.Max = int.Parse(lines[i]);
                person.MyGoals.Add(eternal);
            }
            else if (lines[i] == "Single")
            {
                Single eternal = new Single();
                i++;
                eternal.Goal = lines[i];
                i++;
                eternal.Complete = bool.Parse(lines[i]);
                person.MyGoals.Add(eternal);
            }
        }
        return person;
    }

}