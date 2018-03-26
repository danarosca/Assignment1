using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WindowsFormsApp2.Bussiness;

namespace WindowsFormsApp2.View
{
    public partial class Manager : Employee
    {

        public Manager()
        {
            InitializeComponent();
        }

        public Manager(ManagerCore services)
        {
            
            InitializeComponent();
            this.services = services;
            
        }
        protected void setupCrud<T>(List<object> list)
        {
           
            this.dataGridView1.DataSource = list;
            Factory<T> fact = new Factory<T>();
            List<TextBox> txBoxes = fact.createTextboxes();
            Type type = typeof(T);
            this.TableModel = type;
            enableCRUD();
            setTxBoxes(txBoxes, type);
            Console.WriteLine("Here");
        }

        protected override  void Complaints_Click(object sender, EventArgs e)
        {
            enableCRUD();
            List<Complaint> complaints = this.services.getComplaints();
            this.dataGridView1.DataSource = complaints;

           
            Factory<Complaint> fact = new Factory<Complaint>();
            List<TextBox> txBoxes = fact.createTextboxes();
            Type t = Type.GetType("WindowsFormsApp2.Complaint");
            this.TableModel = t;
            enableCRUD();
            setTxBoxes(txBoxes, t);
            Console.WriteLine("Here");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
            if (this.services.insertNr(number))
            {
                MessageBox.Show("Success");
            }
        }
    }
}
