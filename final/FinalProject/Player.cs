using System.ComponentModel;

class Player 
{
    public int TricksTaken { get; set; }
    public int Score { get; set; }
    public string Name { get; set; }
    public Hand MyHand { get; set; }
    public int Bid { get; set; }
    public Player()
    {
        MyHand=new Hand();
    }
}