namespace WindowsFormsApp2.View
{
    partial class Survey
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.QUality = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 70);
            this.textBox1.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(134, 210);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(320, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Service Quality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quick response";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(134, 279);
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(320, 45);
            this.trackBar2.TabIndex = 4;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Topic";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 27);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(320, 44);
            this.textBox2.TabIndex = 7;
            // 
            // QUality
            // 
            this.QUality.AutoSize = true;
            this.QUality.Location = new System.Drawing.Point(3, 351);
            this.QUality.Name = "QUality";
            this.QUality.Size = new System.Drawing.Size(125, 13);
            this.QUality.TabIndex = 9;
            this.QUality.Text = "Customer Service Quality";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(134, 351);
            this.trackBar3.Minimum = 1;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(320, 45);
            this.trackBar3.TabIndex = 8;
            this.trackBar3.Value = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Survey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QUality);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Survey";
            this.Text = "Survey";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label QUality;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Button button1;
    }
}