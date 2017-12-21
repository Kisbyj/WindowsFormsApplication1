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

        /// <summary>
        /// SQL Connection Commands to locate the database and select the relevant fields.
        /// </summary>
        public void insertBlackBoxData()
    	{

       	mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\WindowsFormsApplication1\Database1.mdf;Integrated Security=True;Connect Timeout=30 ");
       	String selcmd = "SELECT ApplicationName, BugDescription, BugOccurence FROM BugTable ORDER BY ID";
       	SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);

            //SQL Reader Try/Catch
            try
            {
                mySqlConnection.Open();
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                mySqlDataReader.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(appName + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Clear Text box Method
        /// </summary>
        public void cleartxtBoxes()
    	{
        	appName.Text = bugDesc.Text = bugOcc.Text = "";
    	}

        /// <summary>
        /// Performs a check to ensure that the text boxes are not null when submitting data to the database.
        /// </summary>
        /// <returns></returns>
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
 
        /// <summary>
        /// Insert Record Command to push the text box fields into the table.
        /// </summary>
        /// <param name="appName"></param>
        /// <param name="bugDesc"></param>
        /// <param name="bugOcc"></param>
        /// <param name="commandString"></param>
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

        /// <summary>
        /// Initial initialisation.
        /// </summary>
        public BlackBoxTester()
        {
            InitializeComponent();
            insertBlackBoxData();
        }

        /// <summary>
        /// Button1_CLick is the "Add" Command to add to the table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {             
                String commandString = "INSERT INTO BugTable(ApplicationName, BugDescription, BugOccurence) VALUES (@appName, @bugDesc, @bugOcc)";
                insertRecord(appName.Text, bugDesc.Text, bugOcc.Text, commandString);
                cleartxtBoxes();
            }
        }

        /// <summary>
        /// Makes the application end the process on clicking the close button. Prevents the process staying open on close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
