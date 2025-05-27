using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{

    internal class Commando
    {

        private string Name; 
        public string CodeName { get; set; }
        public string[] Tools = new string[5];
        public string Status;


        // constractor
        public Commando(string name, string codeName, string[] tools)
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
        public virtual void  Attack()
        {
            Console.WriteLine($"the commando {CodeName} now attacking");
        }


        // get name 
        public string SayName()
        {
            Console.WriteLine("=== enter your rank ==== \n");
            string clearance = Console.ReadLine().ToLower();

            switch (clearance)
            {
                case "general":
                    return this.Name;
                case "colonel":
                    return this.CodeName;
                case "solider":
                    return "you are not allowed to know the name";
                default:
                    Console.WriteLine("invalid input");
                    SayName();
                    return "you are not allowed to know the name";

            }
        }

       

    }



    }

