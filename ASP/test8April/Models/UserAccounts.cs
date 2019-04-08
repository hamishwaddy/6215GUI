namespace test8April.Models
{
    public class Login
    {
        public string Name { get; set; }
        public int Password { get; set; } 

        public Login(string name, int pword)
        {
            Name = name;
            Password = pword;
        }
    }
}