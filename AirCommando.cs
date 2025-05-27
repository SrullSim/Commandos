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











    }

}
