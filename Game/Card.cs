namespace BattleOfCards.Game
{
    public class Card
    {

        public Card(string name, int attribute1, int attribute2, int attribute3)
        {
            this.Name = name;
            this.Attribute1 = attribute1;
            this.Attribute2 = attribute2;
            this.Attribute3 = attribute3;
        }

        public string Name { get; set; }
        public int Attribute1 { get; set; }
        public int Attribute2 { get; set; }
        public int Attribute3 { get; set; }


    }
}