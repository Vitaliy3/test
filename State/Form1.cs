using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using State.States;

namespace State
{
    public partial class Form1 : Form
    {
        static StateA stateA = new StateA();
        static StateB stateB = new StateB();
        static StateC stateC = new StateC();
        static IState state = new StateA();

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                state = stateA;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                state = stateB;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                state = stateC;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String line = state.Say();
            Info.Text = line;
        }
    }
}
