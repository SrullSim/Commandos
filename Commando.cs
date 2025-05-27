using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    
    internal class Commando
    {

        public string Name;
        public string CodeName;
        public string[] Tools = new string[5];
        public string Status;


        // constractor
        public void commando(string name, string codeName, string[] tools)
        {
            this.Name = name;
            this.CodeName = codeName;
            this.Tools = tools;
            this.Status = "standing";
        }


        // status walk 
        public void Walk()
        {
            this.Status = "walking";
            Console.WriteLine($"the commando {Name} now walking");
        }


        // status hide
        public void Hide()
        {
            this.Status = "hiding";
            Console.WriteLine($"the commando {Name} now hiding");
        }


        // status attack
        public void Attack()
        {
            Console.WriteLine($"the commando {CodeName} now attacking");
        }




    }
}
