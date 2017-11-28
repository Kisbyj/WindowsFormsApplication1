using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection mySqlConnection;

    
        	public void populateListBox()
    	{
       	mySqlConnection =
            	new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\c3439421\Documents\Database1.mdf;Integrated Security=True;Connect Timeout=30 ");
 
       	String selcmd = "SELECT studentId, studentName, studentAddress FROM students ORDER BY studentName";
 
       	SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);
 
       	try
       	{
           	mySqlConnection.Open();
 
           	SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
 
           	lbxstudents.Items.Clear();
 
           	while (mySqlDataReader.Read())
           	{
 
                   lbxstudents.Items.Add(mySqlDataReader["studentID"] + " " +
                      	mySqlDataReader["studentName"] + mySqlDataReader["studentAddress"]);
 
 
           	}
                mySqlDataReader.Close();
         	}




       	catch (SqlException ex)
       	{
 
         	  MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
       	}
 
    	}
 
 
 
    	public void cleartxtBoxes()
    	{
        	txtId.Text = txtName.Text = txtAddress.Text = "";
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




        public Form1()
        {

            //    String[] myData = new String[100];
            InitializeComponent();

            populateListBox();

            //    mySqlConnection =
            //    new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\c3439421\Documents\Database1.mdf;Integrated Security=True;Connect Timeout=30");

            //    String selcmd = "SELECT names FROM Table ";


            //    SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);


            //    mySqlConnection.Open();


            //    SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            //    int i = 0;
            //    while (mySqlDataReader.Read())
            //    {
            //        Console.WriteLine(mySqlDataReader["names"]); //reads a line of the query result at a time
            //        myData[i++] = (String)mySqlDataReader["names"]; //store in an array too for use later

            //    }

            //    for (int j = 0; j < i; j++) //now iterate through our good old, bog standard array
            //    {
            //        Console.WriteLine("***" + myData[j] + "***");
            //    }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {

                String commandString = "INSERT INTO students(studentID, studentName, studentaddress) VALUES (@ID, @name, @address)";

                insertRecord(txtId.Text, txtName.Text, txtAddress.Text, commandString);
                populateListBox();
                cleartxtBoxes();
            }
        }
    }
}
