namespace WindowsFormsApp2.View
{
    partial class Employee
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
        protected void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Complaints = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(429, 444);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 27);
            this.button4.TabIndex = 9;
            this.button4.Text = "Modify clients";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Complaints
            // 
            this.Complaints.Location = new System.Drawing.Point(549, 444);
            this.Complaints.Name = "Complaints";
            this.Complaints.Size = new System.Drawing.Size(101, 27);
            this.Complaints.TabIndex = 10;
            this.Complaints.Text = "Complaints";
            this.Complaints.UseVisualStyleBackColor = true;
            this.Complaints.Click += new System.EventHandler(this.Complaints_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(683, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 35);
            this.button5.TabIndex = 11;
            this.button5.Text = "Complaints requests";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(806, 442);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 35);
            this.button6.TabIndex = 12;
            this.button6.Text = "Approve";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 591);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Complaints);
            this.Controls.Add(this.button4);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.Complaints, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button Complaints;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button5;
        protected System.Windows.Forms.Button button6;
    }
}