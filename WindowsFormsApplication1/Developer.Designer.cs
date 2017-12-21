namespace WindowsFormsApplication1
{
    partial class Developer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Bug = new System.Windows.Forms.Label();
            this.bugIDtxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.bugFixDetailstxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.errorMess = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lineNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.methodName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.className = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.projectName = new System.Windows.Forms.TextBox();
            this.sourceFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bugOcc = new System.Windows.Forms.TextBox();
            this.bugDesc = new System.Windows.Forms.TextBox();
            this.appName = new System.Windows.Forms.TextBox();
            this.bugTableList = new System.Windows.Forms.ListBox();
            this.bugList = new System.Windows.Forms.ListBox();
            this.populateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Developer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(781, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Bug Database";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1086, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Update Bug Databaes";
            // 
            // Bug
            // 
            this.Bug.AutoSize = true;
            this.Bug.Location = new System.Drawing.Point(1000, 81);
            this.Bug.Name = "Bug";
            this.Bug.Size = new System.Drawing.Size(40, 13);
            this.Bug.TabIndex = 57;
            this.Bug.Text = "Bug ID";
            // 
            // bugIDtxt
            // 
            this.bugIDtxt.Location = new System.Drawing.Point(1000, 97);
            this.bugIDtxt.Name = "bugIDtxt";
            this.bugIDtxt.Size = new System.Drawing.Size(290, 20);
            this.bugIDtxt.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(997, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(179, 13);
            this.label15.TabIndex = 60;
            this.label15.Text = "Current Bug Details and Fix Progress";
            // 
            // bugFixDetailstxt
            // 
            this.bugFixDetailstxt.Location = new System.Drawing.Point(1000, 194);
            this.bugFixDetailstxt.Multiline = true;
            this.bugFixDetailstxt.Name = "bugFixDetailstxt";
            this.bugFixDetailstxt.Size = new System.Drawing.Size(299, 239);
            this.bugFixDetailstxt.TabIndex = 61;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1103, 486);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 62;
            this.label16.Text = "Is the bug fixed?";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1003, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 42);
            this.button2.TabIndex = 63;
            this.button2.Text = "Yes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1186, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 42);
            this.button3.TabIndex = 64;
            this.button3.Text = "No";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(1095, 439);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(104, 42);
            this.updateButton.TabIndex = 65;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1095, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 42);
            this.button5.TabIndex = 66;
            this.button5.Text = "Find Bug";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1467, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 67;
            this.label17.Text = "Bug Details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(382, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 13);
            this.label12.TabIndex = 88;
            this.label12.Text = "Error or Error Message Displayed:";
            // 
            // errorMess
            // 
            this.errorMess.Location = new System.Drawing.Point(385, 322);
            this.errorMess.Multiline = true;
            this.errorMess.Name = "errorMess";
            this.errorMess.Size = new System.Drawing.Size(287, 149);
            this.errorMess.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "Line Number:";
            // 
            // lineNumber
            // 
            this.lineNumber.Location = new System.Drawing.Point(385, 275);
            this.lineNumber.Name = "lineNumber";
            this.lineNumber.Size = new System.Drawing.Size(287, 20);
            this.lineNumber.TabIndex = 85;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(382, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 84;
            this.label11.Text = "Method Name:";
            // 
            // methodName
            // 
            this.methodName.Location = new System.Drawing.Point(385, 229);
            this.methodName.Name = "methodName";
            this.methodName.Size = new System.Drawing.Size(287, 20);
            this.methodName.TabIndex = 83;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(382, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 82;
            this.label10.Text = "Class Name:";
            // 
            // className
            // 
            this.className.Location = new System.Drawing.Point(385, 184);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(287, 20);
            this.className.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "Project Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "Source File Location:";
            // 
            // projectName
            // 
            this.projectName.Location = new System.Drawing.Point(385, 135);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(287, 20);
            this.projectName.TabIndex = 78;
            // 
            // sourceFile
            // 
            this.sourceFile.Location = new System.Drawing.Point(385, 87);
            this.sourceFile.Name = "sourceFile";
            this.sourceFile.Size = new System.Drawing.Size(290, 20);
            this.sourceFile.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Application Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Bug Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 42);
            this.button1.TabIndex = 74;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "What as you doing when the bug occured?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Describe the bug:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Application Name:";
            // 
            // bugOcc
            // 
            this.bugOcc.Location = new System.Drawing.Point(18, 322);
            this.bugOcc.Multiline = true;
            this.bugOcc.Name = "bugOcc";
            this.bugOcc.Size = new System.Drawing.Size(287, 149);
            this.bugOcc.TabIndex = 70;
            // 
            // bugDesc
            // 
            this.bugDesc.Location = new System.Drawing.Point(15, 135);
            this.bugDesc.Multiline = true;
            this.bugDesc.Name = "bugDesc";
            this.bugDesc.Size = new System.Drawing.Size(290, 160);
            this.bugDesc.TabIndex = 69;
            // 
            // appName
            // 
            this.appName.Location = new System.Drawing.Point(15, 87);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(290, 20);
            this.appName.TabIndex = 68;
            // 
            // bugTableList
            // 
            this.bugTableList.FormattingEnabled = true;
            this.bugTableList.HorizontalScrollbar = true;
            this.bugTableList.Location = new System.Drawing.Point(1305, 84);
            this.bugTableList.Name = "bugTableList";
            this.bugTableList.Size = new System.Drawing.Size(393, 420);
            this.bugTableList.TabIndex = 89;
            // 
            // bugList
            // 
            this.bugList.FormattingEnabled = true;
            this.bugList.HorizontalScrollbar = true;
            this.bugList.Location = new System.Drawing.Point(681, 71);
            this.bugList.Name = "bugList";
            this.bugList.Size = new System.Drawing.Size(310, 433);
            this.bugList.TabIndex = 90;
            // 
            // populateButton
            // 
            this.populateButton.Location = new System.Drawing.Point(784, 506);
            this.populateButton.Name = "populateButton";
            this.populateButton.Size = new System.Drawing.Size(104, 42);
            this.populateButton.TabIndex = 91;
            this.populateButton.Text = "Populate List";
            this.populateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.populateButton.UseVisualStyleBackColor = true;
            this.populateButton.Click += new System.EventHandler(this.populateButton_Click);
            // 
            // Developer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1721, 571);
            this.Controls.Add(this.populateButton);
            this.Controls.Add(this.bugList);
            this.Controls.Add(this.bugTableList);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.errorMess);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lineNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.methodName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.className);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.sourceFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bugOcc);
            this.Controls.Add(this.bugDesc);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.bugFixDetailstxt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Bug);
            this.Controls.Add(this.bugIDtxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Name = "Developer";
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Bug;
        private System.Windows.Forms.TextBox bugIDtxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox bugFixDetailstxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox errorMess;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lineNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox methodName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox className;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox projectName;
        private System.Windows.Forms.TextBox sourceFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bugOcc;
        private System.Windows.Forms.TextBox bugDesc;
        private System.Windows.Forms.TextBox appName;
        private System.Windows.Forms.ListBox bugTableList;
        private System.Windows.Forms.ListBox bugList;
        private System.Windows.Forms.Button populateButton;
    }
}