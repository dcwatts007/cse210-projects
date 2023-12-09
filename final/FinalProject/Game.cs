class Game
{
    public Deck Decks { get; set; }
    public List<Player> Players { get; set; }
    public Game()
    {
        Decks = new Deck();
        Players = new List<Player>();
    }
    public void Deal(int players)
    {
        Decks.Shuffle();
        for (int i = 0; i < players; i++)
        {
            Player player = new Player();
            Hand hand = new Hand();
            for(int j=51-i;j>0;j-=players)
            {
                Card card = new Card();
                card=Decks.Cards[j];
                hand.AllCards.Add(card);
                if(card.Suite=="Spades")
                {
                    hand.Spades.Add(card);
                }else if(card.Suite=="Hearts")
                {
                    hand.Hearts.Add(card);
                }else if(card.Suite=="Diamonds")
                {
                    hand.Diamonds.Add(card);
                }else
                {
                    hand.Clubs.Add(card);
                }
            }
            player.MyHand=hand;
            Players.Add(player);
        }
    }
    public virtual void Play()
    {
    }
}