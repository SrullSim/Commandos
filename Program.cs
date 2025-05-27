namespace Commandos
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            string[] Tools = new string[5] { "roop", "water", "hammer", "chise", "bag" };
            
            Commando commando = new Commando("jon", "solider", Tools);
            //Console.WriteLine(commando.SayName());
            Console.WriteLine(commando.CodeName);
            string ddd = Console.ReadLine();
            commando.CodeName = "haim";
            Console.WriteLine(commando.CodeName);
            Console.WriteLine(commando.SayName());

            
            Weapon weapon = new Weapon("AK-47", "Kalashnikov", 30);
            weapon.shoot();
        }
    }
}
