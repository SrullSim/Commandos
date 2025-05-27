namespace Commandos
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            string[] Tools = new string[5] { "roop", "water", "hammer", "chise", "bag" };
            
            Commando commando = new Commando("jon", "solider", Tools);
            commando.SayName();
            
            Weapon weapon = new Weapon("AK-47", "Kalashnikov", 30);
            weapon.shoot();
        }
    }
}
