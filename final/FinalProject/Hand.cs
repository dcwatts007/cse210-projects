using System.Runtime.InteropServices;

class Hand
{
    public List<Card> Hearts { get; set; }
    public List<Card> Spades { get; set; }
    public List<Card> Diamonds { get; set; }
    public List<Card> Clubs { get; set; }
    public List<Card> AllCards {get; set; }
    public Hand()
    {
        Hearts=new List<Card>();
        Spades=new List<Card>();
        Diamonds=new List<Card>();
        Clubs=new List<Card>();
        AllCards=new List<Card>();
    }
    public void Sort()
    {
        Hearts.Sort((x,y)=>x.Value.CompareTo(y.Value));
        Spades.Sort((x,y)=>x.Value.CompareTo(y.Value));
        Diamonds.Sort((x,y)=>x.Value.CompareTo(y.Value));
        Clubs.Sort((x,y)=>x.Value.CompareTo(y.Value));
        AllCards.Clear();
        for(int i=0;i<13;i++)
        {
            if(i<Spades.Count)
            {
                AllCards.Add(Spades[i]);
            }else if(i-Spades.Count<Hearts.Count)
            {
                AllCards.Add(Hearts[i-Spades.Count]);
            }else if(i-(Spades.Count+Hearts.Count)<Diamonds.Count)
            {
                AllCards.Add(Diamonds[i-(Hearts.Count+Spades.Count)]);
            }else
            {
                AllCards.Add(Clubs[i-(Hearts.Count+Spades.Count+Diamonds.Count)]);
            }
        }
    }
}