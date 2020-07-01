namespace BattleOfCards.Player
{
    public class Card
    {
        private string name;
        private int atribute1;
        private int atribute2;
        private int atribute3;

        public Card(int atribute1, int atribute2, int atribute3)
        {
            Atribute1 = this.atribute1;
            Atribute2 = this.atribute2;
            Atribute3 = this.atribute3;
        }

        public string Name { get => this.name; set => this.name = value; }
        
        public int Atribute1 { get => this.atribute1; set => this.atribute1 = value; }
        public int Atribute2 { get => this.atribute2; set => this.atribute2 = value; }
        public int Atribute3 { get => this.atribute3; set => this.atribute3 = value; }


    }
}