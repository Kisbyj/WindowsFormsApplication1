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

        /// <summary>
        /// Launches the White Box Tester Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            WhiteBoxTester formThreeTester = new WhiteBoxTester();
            formThreeTester.Show();
            this.Hide();
        }

        /// <summary>
        /// Launches the Developer Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Developer formFourTester = new Developer();
            formFourTester.Show();
            this.Hide();
        }

        /// <summary>
        /// Launches the Black Box Tester form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            BlackBoxTester formOneTester = new BlackBoxTester();
            formOneTester.Show();
            this.Hide();
        }

        /// <summary>
        /// Makes the application end the process on clicking the close button. Prevents the process staying open on close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
