using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Weapon
    {

        public string Name;
        public string Compani;
        public int bulletCount;


        // constructor
        public Weapon(string name, string compani, int bulletCount)
        {
            this.Name = name;
            this.Compani = compani;
            this.bulletCount = bulletCount;
        }


        // shoot method 
        public void shoot()
        {
            if ( this.bulletCount > 0)
            {
                this.bulletCount -= 1;
                Console.WriteLine("shoot fired");
            }
        }
















    }
}
