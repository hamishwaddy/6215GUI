namespace test8April.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Height { get; set; } 

        public Player(string name, int height)
        {
            Name = name;
            Height = height;
        }
    }
}