namespace Part_5._5___Making_a_Die
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die();
            Die die2 = new Die(3);

            Console.WriteLine($"You rolled a {die1.Roll}");
            die1.DrawDie();
            die2.DrawDie(); // will draw a three

            die1.RollDie();
            die1.DrawDie();
            //Console.WriteLine($"You rolled a {die1}");
        }
    }
}