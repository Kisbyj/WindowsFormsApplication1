namespace WindowsFormsApplication1
{
    partial class BlackBoxTester
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.appName = new System.Windows.Forms.TextBox();
            this.bugDesc = new System.Windows.Forms.TextBox();
            this.bugOcc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appName
            // 
            this.appName.Location = new System.Drawing.Point(12, 65);
            this.appName.Multiline = true;
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(290, 129);
            this.appName.TabIndex = 1;
            // 
            // bugDesc
            // 
            this.bugDesc.Location = new System.Drawing.Point(15, 217);
            this.bugDesc.Multiline = true;
            this.bugDesc.Name = "bugDesc";
            this.bugDesc.Size = new System.Drawing.Size(287, 143);
            this.bugDesc.TabIndex = 2;
            // 
            // bugOcc
            // 
            this.bugOcc.Location = new System.Drawing.Point(15, 380);
            this.bugOcc.Multiline = true;
            this.bugOcc.Name = "bugOcc";
            this.bugOcc.Size = new System.Drawing.Size(287, 149);
            this.bugOcc.TabIndex = 3;
            this.bugOcc.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Application Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Describe the bug:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "What as you doing when the bug occured?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Black Box Tester";
            // 
            // BlackBoxTester
            // 
            this.ClientSize = new System.Drawing.Size(315, 619);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bugOcc);
            this.Controls.Add(this.bugDesc);
            this.Controls.Add(this.appName);
            this.Name = "BlackBoxTester";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox appName;
        private System.Windows.Forms.TextBox bugDesc;
        private System.Windows.Forms.TextBox bugOcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

