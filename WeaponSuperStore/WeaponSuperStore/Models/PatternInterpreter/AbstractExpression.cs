using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeaponSuperStore.Models.PatternInterpreter
{
    public abstract class AbstractExpression
    {
        public abstract void InfoOut(Weapon weapon);
    }

    class InfoAmmo : AbstractExpression
    {
        public override void InfoOut(Weapon weapon)
        {
            Console.WriteLine("Пример вывода информации о аммуниции");
        }
    }

    class InfoPatronaj : AbstractExpression
    {
        public override void InfoOut(Weapon weapon)
        {
            Console.WriteLine("Пример вывода информации о патронаже");
        }
    }
}