using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security;

class Tricks
{
    public String Suite { get; set; }
    public bool IsTrumped { get; set; }
    public Player Round(Player lead, List<Player> players)
    {
        Console.Clear();
        Console.WriteLine(lead.Name + " Press Enter when ready to play.");
        Console.ReadLine();
        Console.WriteLine("Select your Card");
        IsTrumped = false;
        for (int i = 0; i < lead.MyHand.AllCards.Count; i++)
        {
            Console.WriteLine("For the " + lead.MyHand.AllCards[i].Value + " of " + lead.MyHand.AllCards[i].Suite + " type " + i);
        }
        List<Card> cards = new List<Card>();
        while (cards.Count == 0)
        {
            try
            {
                cards.Add(lead.MyHand.AllCards[int.Parse(Console.ReadLine())]);
            }
            catch
            {
                Console.WriteLine("Invalid input. Enter the number that is associated with your card.");
            }
        }
        Suite = cards[0].Suite;
        for (int i = 1; i < 4; i++)
        {
            int index = players.IndexOf(lead) + i;
            if (index > 3)
            {
                index -= 4;
            }
            Console.Clear();
            Console.WriteLine(players[index].Name + " press Enter when ready to play.");
            Console.ReadLine();
            for (int j = 0; j < cards.Count; j++)
            {
                if (j + players.IndexOf(lead) > 3)
                {
                    Console.WriteLine(players[j + players.IndexOf(lead) - 4] + " played " + cards[j]);
                }
                else
                {
                    Console.WriteLine(players[j + players.IndexOf(lead)] + " played " + cards[j]);
                }
            }
            if (Suite == "Hearts" && players[index].MyHand.Hearts.Count != 0)
            {
                for (int j = 0; j < players[index].MyHand.Hearts.Count(); j++)
                {
                    Console.WriteLine("To play the " + players[index].MyHand.Hearts[j] + " of hearts, press " + j);
                }
                while (true)
                {
                    try
                    {
                        int choice = int.Parse(Console.ReadLine());
                        cards.Add(players[index].MyHand.Hearts[choice]);
                        players[index].MyHand.Hearts.RemoveAt(choice);
                        players[index].MyHand.AllCards.Remove(cards[cards.Count - 1]);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input. Enter the number that is associated with your card.");
                    }
                }
            }
            else if (Suite == "Spades" && players[index].MyHand.Spades.Count != 0)
            {

                for (int j = 0; j < players[index].MyHand.Spades.Count(); j++)
                {
                    Console.WriteLine("To play the " + players[index].MyHand.Spades[j] + " of Spades, press " + j);
                }
                while (true)
                {
                    try
                    {
                        int choice = int.Parse(Console.ReadLine());
                        cards.Add(players[index].MyHand.Spades[choice]);
                        players[index].MyHand.Spades.RemoveAt(choice);
                        players[index].MyHand.AllCards.Remove(cards[cards.Count - 1]);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input. Enter the number that is associated with your card.");
                    }
                }
            }
            else if (Suite == "Diamonds" && players[index].MyHand.Diamonds.Count != 0)
            {

                for (int j = 0; j < players[index].MyHand.Diamonds.Count(); j++)
                {
                    Console.WriteLine("To play the " + players[index].MyHand.Diamonds[j] + " of Diamonds, press " + j);
                }
                while (true)
                {
                    try
                    {
                        int choice = int.Parse(Console.ReadLine());
                        cards.Add(players[index].MyHand.Diamonds[choice]);
                        players[index].MyHand.Diamonds.RemoveAt(choice);
                        players[index].MyHand.AllCards.Remove(cards[cards.Count - 1]);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input. Enter the number that is associated with your card.");
                    }
                }
            }
            else if (Suite == "Clubs" && players[index].MyHand.Clubs.Count != 0)
            {

                for (int j = 0; j < players[index].MyHand.Clubs.Count(); j++)
                {
                    Console.WriteLine("To play the " + players[index].MyHand.Clubs[j] + " of Clubs, press " + j);
                }
                while (true)
                {
                    try
                    {
                        int choice = int.Parse(Console.ReadLine());
                        cards.Add(players[index].MyHand.Clubs[choice]);
                        players[index].MyHand.Clubs.RemoveAt(choice);
                        players[index].MyHand.AllCards.Remove(cards[cards.Count - 1]);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input. Enter the number that is associated with your card.");
                    }
                }
            }
            else
            {
                for (int j = 0; j < players[index].MyHand.AllCards.Count(); j++)
                {
                    Console.WriteLine("To play the " + players[index].MyHand.AllCards[j] + " of " + players[index].MyHand.AllCards[j].Suite + ", press " + j);
                }
                while (true)
                {
                    try
                    {
                        int choice = int.Parse(Console.ReadLine());
                        cards.Add(players[index].MyHand.Clubs[choice]);
                        players[index].MyHand.Clubs.RemoveAt(choice);
                        players[index].MyHand.AllCards.Remove(cards[cards.Count - 1]);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input. Enter the number that is associated with your card.");
                    }
                }
                if (cards[cards.Count - 1].Suite == "Spades")
                {
                    IsTrumped = true;
                }
            }
        }
        int winner = FindWinner(cards);
        if(players.IndexOf(lead)+winner>3)
        {
            return players[players.IndexOf(lead)+winner-4];
        }
        return players[players.IndexOf(lead)+winner];
    }
    public int FindWinner(List<Card> cards)
    {
        if(IsTrumped)
        {
        int winner=cards.FindIndex(x=>x.Suite=="Spades");
        foreach(Card card in cards)
        {
            if(card.Suite=="Spades"&&cards[winner].Value<card.Value)
            {
                winner=cards.IndexOf(card);
            }
        }
        return winner;
        }else
        {
        int winner=0;
        foreach(Card card in cards)
        {
            if(card.Suite==Suite&&cards[winner].Value<card.Value)
            {
                winner=cards.IndexOf(card);
            }
        }
        return winner;
        }
    }
}
