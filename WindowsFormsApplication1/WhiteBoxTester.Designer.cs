namespace WindowsFormsApplication1
{
    partial class WhiteBoxTester
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bugOcc = new System.Windows.Forms.TextBox();
            this.bugDesc = new System.Windows.Forms.TextBox();
            this.appName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.projectName = new System.Windows.Forms.TextBox();
            this.sourceFile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.className = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.methodName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lineNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.errorMess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "White  Box Tester";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "What as you doing when the bug occured?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Describe the bug:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Application Name:";
            // 
            // bugOcc
            // 
            this.bugOcc.Location = new System.Drawing.Point(15, 338);
            this.bugOcc.Multiline = true;
            this.bugOcc.Name = "bugOcc";
            this.bugOcc.Size = new System.Drawing.Size(287, 149);
            this.bugOcc.TabIndex = 10;
            // 
            // bugDesc
            // 
            this.bugDesc.Location = new System.Drawing.Point(12, 151);
            this.bugDesc.Multiline = true;
            this.bugDesc.Name = "bugDesc";
            this.bugDesc.Size = new System.Drawing.Size(290, 160);
            this.bugDesc.TabIndex = 9;
            // 
            // appName
            // 
            this.appName.Location = new System.Drawing.Point(12, 103);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(290, 20);
            this.appName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bug Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Application Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Project Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Source File Location:";
            // 
            // projectName
            // 
            this.projectName.Location = new System.Drawing.Point(382, 151);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(287, 20);
            this.projectName.TabIndex = 18;
            // 
            // sourceFile
            // 
            this.sourceFile.Location = new System.Drawing.Point(382, 103);
            this.sourceFile.Name = "sourceFile";
            this.sourceFile.Size = new System.Drawing.Size(290, 20);
            this.sourceFile.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(379, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Class Name:";
            // 
            // className
            // 
            this.className.Location = new System.Drawing.Point(382, 200);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(287, 20);
            this.className.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(379, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Method Name:";
            // 
            // methodName
            // 
            this.methodName.Location = new System.Drawing.Point(382, 245);
            this.methodName.Name = "methodName";
            this.methodName.Size = new System.Drawing.Size(287, 20);
            this.methodName.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Line Number:";
            // 
            // lineNumber
            // 
            this.lineNumber.Location = new System.Drawing.Point(382, 291);
            this.lineNumber.Name = "lineNumber";
            this.lineNumber.Size = new System.Drawing.Size(287, 20);
            this.lineNumber.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(379, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Error Message and/or Source Code:";
            // 
            // errorMess
            // 
            this.errorMess.Location = new System.Drawing.Point(382, 338);
            this.errorMess.Multiline = true;
            this.errorMess.Name = "errorMess";
            this.errorMess.Size = new System.Drawing.Size(287, 149);
            this.errorMess.TabIndex = 29;
            // 
            // WhiteBoxTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 580);
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
            this.Controls.Add(this.label1);
            this.Name = "WhiteBoxTester";
            this.Text = "White Box Tester";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bugOcc;
        private System.Windows.Forms.TextBox bugDesc;
        private System.Windows.Forms.TextBox appName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox projectName;
        private System.Windows.Forms.TextBox sourceFile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox className;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox methodName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lineNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox errorMess;
    }
}