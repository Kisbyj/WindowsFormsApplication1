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
    public partial class WhiteBoxTester : Form
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

        public void cleartxtBoxes()
        {
            appName.Text = bugDesc.Text = bugOcc.Text = sourceFile.Text = projectName.Text = className.Text = methodName.Text = lineNumber.Text = errorMess.Text = "";
        }

        public WhiteBoxTester()
        {
            InitializeComponent();
            populateListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                String commandString = "INSERT INTO BugTable(ApplicationName, BugDescription, BugOccurence, SourceFile, ProjectName, ClassName, MethodName, LineNumber, ErrorMessage) VALUES (@appName, @bugDesc, @bugOcc, @sourceFile, @projectName, @className, @methodName, @lineNumber, @errorMess)";
                insertRecord(appName.Text, bugDesc.Text, bugOcc.Text, sourceFile.Text, projectName.Text, className.Text, methodName.Text, lineNumber.Text, errorMess.Text, commandString);
                cleartxtBoxes();
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

        private void WhiteBoxTester_Load(object sender, EventArgs e)
        {

        }
    }
}
