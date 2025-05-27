namespace Commandos
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            string[] Tools = new string[5] { "roop", "water", "hammer", "chise", "bag" };
            
            Commando commando = new Commando();
            commando.commando("jon", "solider", Tools);
            commando.Walk();
            Console.ReadLine();
            commando.Hide();
            commando.Attack();

            Weapon weapon = new Weapon("AK-47", "Kalashnikov", 30);
            weapon.shoot();
        }
    }
}
