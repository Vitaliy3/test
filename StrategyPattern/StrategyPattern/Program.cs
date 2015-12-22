using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class Program
    {
        static void Main()
        {
            iWeapon weapon = null;
            Character YaJou = new Character();

            while (true)
            {
                Console.WriteLine("Choose a weapon for me. 1 - Sword, 2 - Axe, 3 - Stone");
                String input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        weapon = new Sword(); break;
                    case "2":
                        weapon = new Axe(); break;
                    case "3":
                        weapon = new Stone(); break;
                }

                YaJou.SetWeapon(weapon);
                YaJou.Attack();
            }
        }
    }
}
