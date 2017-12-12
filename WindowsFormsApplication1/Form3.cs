﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        SqlConnection mySqlConnection;

        public void populateListBox()
        {
            mySqlConnection =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\WindowsFormsApplication1\Database1.mdf;Integrated Security=True;Connect Timeout=30 ");

            String selcmd = "SELECT ApplicationName, BugDescription, BugOccurence, SourceFile, ProjectName, ClassName, MethodName, LineNumber, ErrorMessage FROM BugTable ORDER BY ID";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                mySqlDataReader.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public bool checkInputs()
        {
            bool rtnvalue = true;

            if (string.IsNullOrEmpty(txtId.Text) ||
                string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Error: Please check your inputs");
                rtnvalue = false;
            }

            return (rtnvalue);

        }
        public void insertRecord(String ID, String name, String address, String commandString)
        {
            try
            {
                SqlCommand cmdInsert = new SqlCommand(commandString, mySqlConnection);

                cmdInsert.Parameters.AddWithValue("@ID", ID);
                cmdInsert.Parameters.AddWithValue("@name", name);
                cmdInsert.Parameters.AddWithValue("@address", address);
                cmdInsert.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ID + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public Form3()
        {
            InitializeComponent();
            populateListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                String commandString = "INSERT INTO BugTable(ApplicationName, BugDescription, BugOccurence) VALUES (@ID, @name, @address)";
                insertRecord(txtId.Text, txtName.Text, txtAddress.Text, commandString);
                //   populateListBox();
                //cleartxtBoxes();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
