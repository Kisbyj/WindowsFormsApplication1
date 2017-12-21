using System;
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
    public partial class Developer : Form
    {
        SqlConnection mySqlConnection;

        /// <summary>
        /// SQL Connection Commands to locate the database and select the relevant fields.
        /// </summary>
        public void populateListBox()
        {
            mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\WindowsFormsApplication1\Database1.mdf;Integrated Security=True;Connect Timeout=30 ");
            String selcmd = "SELECT ApplicationName, BugDescription, BugOccurence, SourceFile, ProjectName, ClassName, MethodName, LineNumber, ErrorMessage FROM BugTable ORDER BY ID";
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
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                string.IsNullOrEmpty(bugOcc.Text) ||
                string.IsNullOrEmpty(sourceFile.Text) ||
                string.IsNullOrEmpty(projectName.Text) ||
                string.IsNullOrEmpty(className.Text) ||
                string.IsNullOrEmpty(methodName.Text) ||
                string.IsNullOrEmpty(lineNumber.Text) ||
                string.IsNullOrEmpty(errorMess.Text))

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
        /// <param name="sourceFile"></param>
        /// <param name="projectName"></param>
        /// <param name="className"></param>
        /// <param name="methodName"></param>
        /// <param name="lineNumber"></param>
        /// <param name="errorMess"></param>
        /// <param name="commandString"></param>
        public void insertRecord(String appName, String bugDesc, String bugOcc, String sourceFile, String projectName, String className, String methodName, String lineNumber, String errorMess, String commandString)
        {
            try
            {
                SqlCommand cmdInsert = new SqlCommand(commandString, mySqlConnection);

                cmdInsert.Parameters.AddWithValue("@appName", appName);
                cmdInsert.Parameters.AddWithValue("@bugDesc", bugDesc);
                cmdInsert.Parameters.AddWithValue("@bugOcc", bugOcc);
                cmdInsert.Parameters.AddWithValue("@sourceFile", sourceFile);
                cmdInsert.Parameters.AddWithValue("@projectName", projectName);
                cmdInsert.Parameters.AddWithValue("@className", className);
                cmdInsert.Parameters.AddWithValue("@methodName", methodName);
                cmdInsert.Parameters.AddWithValue("@lineNumber", lineNumber);
                cmdInsert.Parameters.AddWithValue("@errorMess", errorMess);
                cmdInsert.ExecuteNonQuery();
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
            appName.Text = bugDesc.Text = bugOcc.Text = sourceFile.Text = projectName.Text = className.Text = methodName.Text = lineNumber.Text = errorMess.Text = "";
        }

        /// <summary>
        /// Initial Initialisation.
        /// </summary>
        public Developer()
        {
            InitializeComponent();
            populateListBox();
        }

        /// <summary>
        /// This method adds the entire of ONE specific record (Based on ID Number) to the list box on the right hand side of the form.
        /// </summary>
        public void bugDetails()
        {
            mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\WindowsFormsApplication1\Database1.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true" );
            String commandString = "SELECT * FROM BugTable WHERE ID = '" + bugIDtxt.Text + "'";
            SqlCommand mySqlCommand = new SqlCommand(commandString, mySqlConnection);

            try
            {
                mySqlConnection.Open();
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                bugTableList.Items.Clear();

                while (mySqlDataReader.Read())
                {
                    bugTableList.Items.Add("Bug ID Number: " + mySqlDataReader["ID"]);
                    bugTableList.Items.Add("Application Name: " + mySqlDataReader["ApplicationName"]);
                    bugTableList.Items.Add("Bug Description: " + mySqlDataReader["BugDescription"]);
                    bugTableList.Items.Add("Bug Occurence: " + mySqlDataReader["BugOccurence"]);
                    bugTableList.Items.Add("Source File: " + mySqlDataReader["SourceFile"]);
                    bugTableList.Items.Add("Project Name: " + mySqlDataReader["ProjectName"]);
                    bugTableList.Items.Add("Class Name: " + mySqlDataReader["ClassName"]);
                    bugTableList.Items.Add("Method Name: " + mySqlDataReader["MethodName"]);
                    bugTableList.Items.Add("Line Number: " + mySqlDataReader["LineNumber"]);
                    bugTableList.Items.Add("Error Message/Source Code: " + mySqlDataReader["ErrorMessage"]);
                    bugTableList.Items.Add("Is the Bug fixed? " + mySqlDataReader["BugStatus"]);
                    bugTableList.Items.Add("Bug Fix Details: " + mySqlDataReader["BugFixDetails"]);
                    bugTableList.Items.Add("--------------------END----------------------");
                    bugFixDetailstxt.Text = mySqlDataReader["BugFixDetails"].ToString();
                }
            }
            
            catch (SqlException ex)
            {
                MessageBox.Show(appName + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// This method populates the central list box with the entire contents of the table.
        /// </summary>
        public void bugLister()
        {
            mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\WindowsFormsApplication1\Database1.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");
            String populateString= "SELECT ID, ApplicationName, BugDescription, BugOccurence, SourceFile, ProjectName, ClassName, MethodName, LineNumber, ErrorMessage, BugStatus, BugFixDetails FROM BugTable ORDER BY ID";
            SqlCommand mySqlpopulate = new SqlCommand(populateString, mySqlConnection);

            try
            {
                mySqlConnection.Open();
                SqlDataReader mySqlDataRead = mySqlpopulate.ExecuteReader();
                bugList.Items.Clear();

                while (mySqlDataRead.Read())
                {
                    bugList.Items.Add("Bug ID Number: " + mySqlDataRead["ID"]);
                    bugList.Items.Add("Application Name: " + mySqlDataRead["ApplicationName"]);
                    bugList.Items.Add("Bug Description: " + mySqlDataRead["BugDescription"]);
                    bugList.Items.Add("Bug Occurence: " + mySqlDataRead["BugOccurence"]);
                    bugList.Items.Add("Source File: " + mySqlDataRead["SourceFile"]);
                    bugList.Items.Add("Project Name: " + mySqlDataRead["ProjectName"]);
                    bugList.Items.Add("Class Name: " + mySqlDataRead["ClassName"]);
                    bugList.Items.Add("Method Name: " + mySqlDataRead["MethodName"]);
                    bugList.Items.Add("Line Number: " + mySqlDataRead["LineNumber"]);
                    bugList.Items.Add("Error Message/Source Code: " + mySqlDataRead["ErrorMessage"]);
                    bugList.Items.Add("Is the Bug fixed? " + mySqlDataRead["BugStatus"]);
                    bugList.Items.Add("Bug Fix Details: " + mySqlDataRead["BugFixDetails"]);
                    bugList.Items.Add("-----------------------------------------------------------------");
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(appName + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Button1_Click allows the developer to submit a bug from within the development form by using the submission boxes on the left hand side of the screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                String commandString = "INSERT INTO BugTable(ApplicationName, BugDescription, BugOccurence, SourceFile, ProjectName, ClassName, MethodName, LineNumber, ErrorMessage) VALUES (@appName, @bugDesc, @bugOcc, @sourceFile, @projectName, @className, @methodName, @lineNumber, @errorMess)";
                insertRecord(appName.Text, bugDesc.Text, bugOcc.Text, sourceFile.Text, projectName.Text, className.Text, methodName.Text, lineNumber.Text, errorMess.Text, commandString);
                cleartxtBoxes();
                bugLister();
            }
        }

    
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// button2_click is linked to the Yes button to set the bug as "Fixed", it also refreshes both list boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            String commandString = "UPDATE BugTable SET BugStatus = '" + "Yes" + "' WHERE ID = '" + bugIDtxt.Text + "'";
            SqlCommand updatePush = new SqlCommand(commandString, mySqlConnection);
            updatePush.ExecuteNonQuery();
            bugDetails();
            bugLister();
        }

        /// <summary>
        /// button3_click is linked to the No button to set the bug as "not fixed", it also refreshes both list boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            String commandString = "UPDATE BugTable SET BugStatus = '" + "No" + "' WHERE ID = '" + bugIDtxt.Text + "'";
            SqlCommand updatePush = new SqlCommand(commandString, mySqlConnection);
            updatePush.ExecuteNonQuery();
            bugDetails();
            bugLister();
        }

        /// <summary>
        /// Button 5 runs the "BugDetails" method, pulling data from the table of ONE single ID. (A Single Row).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            bugDetails();

        }

        /// <summary>
        /// button4_click is linked to the "Update" button allowing the developper to update the Bug Fix Details field. It also "Refreshes" both list boxes on submission
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            String commandString = "UPDATE BugTable SET BugFixDetails = '" + bugFixDetailstxt.Text + "' WHERE ID = '" + bugIDtxt.Text + "'";
            SqlCommand updateText = new SqlCommand(commandString, mySqlConnection);
            updateText.ExecuteNonQuery();
            bugDetails();
            bugLister();
        }

        /// <summary>
        /// The populate button initially populates the central list box and "refreshes" it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void populateButton_Click(object sender, EventArgs e)
        {
            bugLister();
        }

        /// <summary>
        /// Makes the application end the process on clicking the close button. Prevents the process staying open on close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
