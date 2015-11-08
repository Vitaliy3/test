using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbstractFactory.Factories;
using AbstractFactory.Products.Chocolate;
using AbstractFactory.Products.KitKat;
using AbstractFactory.Products.Sweet;

namespace AbstractFactory
{
    public partial class Form1 : Form
    {
        static FactoryA factoryA = new FactoryA();
        static FactoryB factoryB = new FactoryB();
        static AbstracTFactory factory = factoryA;

        static IChocolate chocolate = new ChocolateA();
        static IKitKat kitkat = new KitKatA();
        static ISweet sweet = new SweetA();

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateChocolate_Click(object sender, EventArgs e)
        {
            chocolate = factory.CreateChocolate();
            String line = "Quality=" + chocolate.GetQuality();
            Info.Text = line;
        }

        private void CreateSweet_Click(object sender, EventArgs e)
        {
            sweet = factory.CreateSweet();
            String line = "Price=" + sweet.GetPrice();
            Info.Text = line;
        }

        private void CreateKitKat_Click(object sender, EventArgs e)
        {
            kitkat = factory.CreateKitKat();
            String line = "Taste=" + kitkat.GetTaste();
            Info.Text = line;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                factory = factoryA;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                factory = factoryB;
            }
        }
    }
}
