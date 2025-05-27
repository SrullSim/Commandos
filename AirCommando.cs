using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class AirCommando: Commando
    {
        public string Parachute { get; set;}


        // constructor
        public AirCommando(string name , string codename, string[] tools, string parachute): base(name, codename, tools)
        {
            this.Parachute = parachute;
        }


        // print status 
        public void PrintStatus()
        {
            Console.WriteLine($"The Sea Commando {CodeName} is currently {Parachute}");
        }


        // override attack method
        public override void Attack()
        {
            Console.WriteLine($"the {CodeName} now attacking from the air ");
        }








    }

}
