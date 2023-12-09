using System.ComponentModel;
using System.Transactions;

class Spades : Game
{
    public Spades()
    {
        for(int i = 0; i<4;i++)
        {
            Player player = new Player();
            Players.Add(player);
        }
    }
    public void Deal()
    {
        Decks.Shuffle();
        for (int i = 0; i < 4; i++)
        {
            Hand hand = new Hand();
            for (int j = 51 - i; j >= 0; j -= 4)
            {
                Card card = new Card();
                card = Decks.Cards[j];
                hand.AllCards.Add(card);
                if (card.Suite == "Spades")
                {
                    hand.Spades.Add(card);
                }
                else if (card.Suite == "Hearts")
                {
                    hand.Hearts.Add(card);
                }
                else if (card.Suite == "Diamonds")
                {
                    hand.Diamonds.Add(card);
                }
                else
                {
                    hand.Clubs.Add(card);
                }
            }
            hand.Sort();
            Players[i].MyHand = hand;
        }
    }
    public override void Play()
    {
        base.Deal(4);
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("What is the name of Player " + (i + 1));
            Players[i].Name = Console.ReadLine();
        }
        int lead = 0;
        Player leader = Players[lead];
        while (Players[0].Score < 500 && Players[1].Score < 500)
        {

            for (int i = 0; i < 4; i++)
            {

                Console.Clear();
                if (lead + i < 4)
                {
                    int index = lead+i;
                    if(index>3)
                    {
                        index-=4;
                    }
                    Console.WriteLine(Players[index].Name + "Press enter when ready");
                    Console.ReadLine();
                    Console.Write("Your cards are: ");
                    foreach(Card card in Players[index].MyHand.AllCards)
                    {
                        Console.Write(card.Value+" of "+card.Suite+" ");
                    }
                    Console.WriteLine(Players[lead + i].Name + " What would you like to bid?");
                    while (true)
                    {
                        try
                        {
                            Players[lead + i].Bid = int.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Enter the number of tricks you believe you will win.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine(Players[lead + i - 4].Name + "Press enter when ready");
                    Console.ReadLine();
                    Console.WriteLine(Players[lead + i - 4].Name + " What would you like to bid?");
                }
                while (true)
                {
                    try
                    {
                        Players[lead + i].Bid = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Enter the number of tricks you believe you will win.");
                    }
                }
            }
            for (int i = 0; i < 13; i++)
            {
                Tricks tricks = new Tricks();
                leader = tricks.Round(leader, Players);
                leader.TricksTaken += 1;
                Console.Clear();
            }
            foreach (Player player in Players)
            {
                if (player.Bid == 0)
                {
                    if (player.TricksTaken == 0)
                    {
                        player.Score += 100;
                        if(Players.IndexOf(player)<2)
                        {
                        Players[Players.IndexOf(player)+2].Score+=100;
                        }else
                        {
                            Players[Players.IndexOf(player)-2].Score+=100;
                        }
                    }
                    else
                    {
                        player.Score -= 100;
                        if(Players.IndexOf(player)<2)
                        {
                        Players[Players.IndexOf(player)+2].Score-=100;
                        }else
                        {
                            Players[Players.IndexOf(player)-2].Score-=100;
                        }
                    }
                }
                if(Players[0].TricksTaken+Players[2].TricksTaken>=Players[0].Bid+Players[2].Bid)
                {
                    Players[0].Score+=(Players[0].Bid+Players[2].Bid)*10;
                }else
                {
                    Players[0].Score-=(Players[0].Bid+Players[2].Bid)*10;
                }
                
                if(Players[1].TricksTaken+Players[3].TricksTaken>=Players[1].Bid+Players[3].Bid)
                {
                    Players[1].Score+=(Players[1].Bid+Players[3].Bid)*10;
                }else
                {
                    Players[1].Score-=(Players[1].Bid+Players[3].Bid)*10;
                }
            }
        }
    }
}