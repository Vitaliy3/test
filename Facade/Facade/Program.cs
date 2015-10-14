using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Programm
    {
        static void Main()
        {
            var water = new WaterSystem();
            var owenOn = new OwenOn();
            var owenOff = new OwenOff();
            var kettle = new Kettle(water, owenOff,owenOn);

            Console.WriteLine("Чай");
            kettle.makeTea();

            Console.WriteLine("Кофе");
            kettle.makeCoffe();

            Console.ReadLine();
        }
    }


    class Kettle//чайник с использованием фасада
    {
        private WaterSystem _water;
        private OwenOn _owenOn;
        private OwenOff _owenOff;

        public Kettle(WaterSystem water, OwenOff owenOff, OwenOn owenOn)
        {
            _water = water;
            _owenOn = owenOn;
            _owenOff = owenOff;
        }

        public void makeTea()
        {
            _water.FillWater(2);
            _owenOn.OwenOnFunc();
            _water.Check();
            _owenOff.OwenOffFunc();
            _water.emptyTank();

        }

        public void makeCoffe()
        {
            _water.FillWater(1);
            _owenOn.OwenOnFunc();
            _owenOff.OwenOffFunc();
            _water.FillWater(1);
            _owenOn.OwenOnFunc();
            _water.Check();
            _owenOff.OwenOffFunc();
            _water.emptyTank();
        }
        
    }



    class OwenOn//включить чайник
    {
        public void OwenOnFunc() { Console.WriteLine("Owen is on"); }

    }

    class WaterSystem//использовать воду
    {
        public void FillWater(int liter)
        {

            Console.WriteLine("fill with {0} liter ",liter);
        }

        public void emptyTank()
        {
            Console.WriteLine("Tank is empty");
        }

        public void Check()
        {
            Console.WriteLine("Water is checked");
        }
    }
    
    class OwenOff//выключить чайник
    {
        public void OwenOffFunc() { Console.WriteLine("Owen is off"); }
    }


}