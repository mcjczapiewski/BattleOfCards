namespace BattleOfCards.Game
{
    public class Card
    {

        public Card(string name, int atribute1, int atribute2, int atribute3)
        {
            this.Name = name;
            this.Atribute1 = atribute1;
            this.Atribute2 = atribute2;
            this.Atribute3 = atribute3;
        }

        public string Name { get; set; }
        public int Atribute1 { get; set; }
        public int Atribute2 { get; set; }
        public int Atribute3 { get; set; }


    }
}