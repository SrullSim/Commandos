using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class SeaCommando : Commando
    {
        public string Swim;


        // constructor
        public SeaCommando(string name, string codename, string[] tools, string swim) : base(name, codename, tools)
        {
            this.Swim = swim;   
        }

        // print status 
        public void PrintStatus()
        {
            Console.WriteLine($"The Sea Commando {CodeName} is currently {Swim}");
        }




    }
}
