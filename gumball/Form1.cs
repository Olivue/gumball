using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gumball
{
    public partial class Form1 : Form
    {
        GumballMachine machine;
        int CostMumble = 5;
        int Mumbels = 20;

        public Form1()
        {
            InitializeComponent();
            machine = new GumballMachine(Mumbels, CostMumble, (int)numericCoins.Value);
        }

        private void numericCoins_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            machine = new GumballMachine(Mumbels, CostMumble, (int)numericCoins.Value);
            machine.DispenseOneGumball(CostMumble, (int)numericCoins.Value);
        }
    }
}
