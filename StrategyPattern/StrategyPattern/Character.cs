using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class Character
    {
        private iWeapon weapon;

        public void SetWeapon(iWeapon newWeapon)
        {
            weapon = newWeapon;
        }

        public void Attack()
        {
            weapon.Use();
        }
    }
}
