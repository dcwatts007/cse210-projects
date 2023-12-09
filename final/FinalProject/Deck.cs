class Deck
{
    public List<Card> Cards {get;set;}
    public Deck()
    {
        Cards=new List<Card>();
        for(int i=0;i<4;i++)
        {
            for(int j=1;j<=13;j++)
            {
                Card card = new Card();
                card.Value=j;
                if(i==0)
                {
                    card.Suite="Clubs";
                }else if(i==1)
                {
                    card.Suite="Diamonds";
                }else if(i==2)
                {
                    card.Suite="Hearts";
                }
                else
                {
                    card.Suite="Spades";
                }
                Cards.Add(card);
            }
        }
    }
    public void Shuffle()
    {
        for(int i=0;i<52;i++)
        {
            Random rand = new Random();
            Card holder = new Card();
            int index=rand.Next(52);
            holder=Cards[index];
            Cards[index]=Cards[i];
            Cards[i]=holder;
        }
    }
}