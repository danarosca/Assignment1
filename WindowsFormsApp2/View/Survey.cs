using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Bussiness;

namespace WindowsFormsApp2.View
{
    public partial class Survey : Form
    {
        public Survey()
        {
            InitializeComponent();
        }

        private Complaint comp;
        private int userId;
        private ClientCore services;
        public Survey(Complaint comp1,int id,ClientCore services)
        {
            InitializeComponent();
            this.comp = comp1;
            this.userId = id;
            this.services = services;
            this.textBox2.Text = comp1.shortDescription;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string longDescription=this.textBox1.Text;
            Complaint current = this.comp;
            int serviceQ = this.trackBar1.Value;
            int quickQ = this.trackBar2.Value;
            int customerQ = this.trackBar3.Value;
            Complaint newC=new Complaint(current.id,"Filled",serviceQ,quickQ,customerQ,current.shortDescription,longDescription,this.userId);
            if (this.services.updateComplaint(newC))
            {
                MessageBox.Show("Success");
            }

        }
    }
}
