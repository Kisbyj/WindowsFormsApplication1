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
    public partial class BlackBoxTester : Form
    {
        SqlConnection mySqlConnection;

        	public void populateListBox()
    	{
       	mySqlConnection =
            	new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\WindowsFormsApplication1\Database1.mdf;Integrated Security=True;Connect Timeout=30 ");
 
       	String selcmd = "SELECT ApplicationName, BugDescription, BugOccurence FROM BugTable ORDER BY ID";
 
       	SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);
 
       	try
       	{
           	mySqlConnection.Open();
 
           	SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
 
          // 	lbxstudents.Items.Clear();
 
          // 	while (mySqlDataReader.Read())
          // 	{
 
          //         lbxstudents.Items.Add(mySqlDataReader["studentID"] + " " +
          //            	mySqlDataReader["studentName"] + mySqlDataReader["studentAddress"]);
 
 
          // 	}
                mySqlDataReader.Close();
         	}




       	catch (SqlException ex)
       	{
 
         	  MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
       	}
 
    	}
 
 
 
    	public void cleartxtBoxes()
    	{
        	appName.Text = bugDesc.Text = bugOcc.Text = "";
    	}
 
   public bool checkInputs()
    	{
        	bool rtnvalue = true;
        	
       	if (string.IsNullOrEmpty(appName.Text) ||
           	string.IsNullOrEmpty(bugDesc.Text) ||
           	string.IsNullOrEmpty(bugOcc.Text))
        	{
            	MessageBox.Show("Error: Please check your inputs");
            	rtnvalue = false;
        	}
 
        	return (rtnvalue);
 
    	}
 
 
   public void insertRecord(String appName, String bugDesc, String bugOcc, String commandString)
    	{

            try
            {
                SqlCommand cmdInsert = new SqlCommand(commandString, mySqlConnection);

                cmdInsert.Parameters.AddWithValue("@appName", appName);
                cmdInsert.Parameters.AddWithValue("@bugDesc", bugDesc);
                cmdInsert.Parameters.AddWithValue("@bugOcc", bugOcc);
                cmdInsert.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(appName + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

    	}


        public BlackBoxTester()
        {
            InitializeComponent();
            populateListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {             
                String commandString = "INSERT INTO BugTable(ApplicationName, BugDescription, BugOccurence) VALUES (@appName, @bugDesc, @bugOcc)";
                insertRecord(appName.Text, bugDesc.Text, bugOcc.Text, commandString);
                cleartxtBoxes();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
