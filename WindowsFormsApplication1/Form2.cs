﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 formThreeTester = new Form3();
            formThreeTester.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 formFourTester = new Form4();
            formFourTester.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 formOneTester = new Form1();
            formOneTester.Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }
    }
}
