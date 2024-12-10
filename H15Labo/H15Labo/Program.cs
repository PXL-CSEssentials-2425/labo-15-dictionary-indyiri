using System.Runtime.CompilerServices;
using System.Threading.Channels;

internal class Program
{
    static Dictionary<string, int> ranking = new Dictionary<string, int>();

    private static void Main(string[] args)
    {
        bool close = false;

        

        ranking.Add("Emma", 18);
        ranking.Add("Liam", 19);
        ranking.Add("Noah", 17);
        ranking.Add("Olivia", 20);

        do
        {
            Console.WriteLine("Welkom bij het Klassement Beheer Systeem!");
            Console.WriteLine("Kies een optie uit het menu:");
            Console.WriteLine("");
            Console.WriteLine("1. Toon het klassement");
            Console.WriteLine("2. Zoek de score van een deelnemer");
            Console.WriteLine("3. Pas de score van een deelnemer aan of voeg een nieuwe deelnemer toe");
            Console.WriteLine("4. Toon de gemiddelde score");
            Console.WriteLine("5. Toon de deelnemer met de hoogste score");
            Console.WriteLine("6. Stop het programma");
            Console.Write("Maak uw keuze: ");

            string inputChoice = Console.ReadLine();
            int choice;

            bool isInputValid = int.TryParse(inputChoice, out choice);

            if (!isInputValid || choice < 1 || choice > 6)
            {
                Console.WriteLine("Geef een geldige keuze in!");
                Console.ReadKey(true);
                Console.Clear();
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        foreach (var item in ranking)
                        {
                            Console.WriteLine($"{item.Key}: {item.Value} punten");
                        }
                        Console.ReadKey(true);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("Geef de naam van de deelnemer: ");
                        string inputName1 = Console.ReadLine();
                        bool existsName = ranking.ContainsKey(inputName1);
                        if (existsName == true)
                        {
                            Console.WriteLine($"{inputName1} heeft {ranking[inputName1]} punten.");
                        }
                        else if (existsName == false)
                        {
                            Console.WriteLine($"{inputName1} bestaat niet in het klassement");
                        }
                        Console.ReadKey(true);
                        Console.Clear();
                        break;
                    case 3:
                        AddOrUpdateDictionary();
                        Console.ReadKey(true);
                        Console.Clear();
                        break;
                    case 4:
                        double sum = 0.0; 
                        foreach (int item in ranking.Values)
                        {
                            sum += item;
                        }
                        Console.WriteLine($"De gemiddelde score van de deelnemers is {sum / ranking.Values.Count}");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;
                    case 5:
                        int highestScore = ranking.Values.Max();
                        string personWithHighestScore = "";

                        foreach (string key in ranking.Keys)
                        {
                            if (ranking[key] == highestScore)
                            { 
                                personWithHighestScore = key;
                            }
                        }

                        Console.WriteLine($"De deelnemer met de hoogste score is {personWithHighestScore} met {highestScore} punten.");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;
                    case 6:
                        close = true;
                        break;
                }
            }
        }
        while (close == false);
    }

    private static void AddOrUpdateDictionary()
    {
        Console.Write("Geef de naam van de deelnemer: ");
        string inputName2 = Console.ReadLine();
        bool existsNameAlready = ranking.ContainsKey(inputName2);
        int score;
        bool isInputScoreValid;
        if (existsNameAlready == true)
        {
            do
            {
                Console.Write($"Geef de nieuwe score van {inputName2}: ");
                string inputScore = Console.ReadLine();
                isInputScoreValid = int.TryParse(inputScore, out score);
                if (!isInputScoreValid || score < 0)
                {
                    Console.WriteLine("Geef een geldige score in");
                }
                else
                {
                    ranking[inputName2] = score;
                    Console.WriteLine($"De score van {inputName2} is bijgewerkt naar {score} punten");
                }
            }
            while (!isInputScoreValid || score < 0);

        }
        else if (existsNameAlready == false)
        {
            do
            {
                Console.Write($"Geef de score van de nieuwe deelnemer {inputName2}: ");
                string inputScore = Console.ReadLine();
                isInputScoreValid = int.TryParse(inputScore, out score);
                if (!isInputScoreValid || score < 0)
                {
                    Console.WriteLine("Geef een geldige score in");
                }
                else
                {
                    ranking.Add(inputName2, score);
                    Console.WriteLine($"De score van de nieuwe deelnemer {inputName2} is {score} punten");
                }
            }
            while (!isInputScoreValid || score < 0);
        }
    }
}