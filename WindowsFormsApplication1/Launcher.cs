using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WhiteBoxTester formThreeTester = new WhiteBoxTester();
            formThreeTester.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Developer formFourTester = new Developer();
            formFourTester.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BlackBoxTester formOneTester = new BlackBoxTester();
            formOneTester.Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }
    }
}
