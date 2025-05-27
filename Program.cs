namespace Commandos
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            string[] Tools = new string[5] { "roop", "water", "hammer", "chise", "bag" };
            
            Commando commando = new Commando("jon", "solider", Tools);
            Weapon weapon = new Weapon("AK-47", "Kalashnikov", 30);
            AirCommando airCommando = new AirCommando("asi", "colonel", Tools, "praper");
            SeaCommando seaCommando = new SeaCommando("ali", "general", Tools, "swimming");

            airCommando.Attack();
            Console.WriteLine("=====================================");
            seaCommando.Attack();


        }
    }
}
