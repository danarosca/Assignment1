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
using WindowsFormsApp2.DataB;

namespace WindowsFormsApp2.View
{
    public partial class Employee : BaseForm
    {
        protected EmployeeCore services;
        public Employee()
        {
            InitializeComponent();
        }

        public Employee(EmployeeCore services)
        {
            InitializeComponent();
            Console.WriteLine("Running as employee");
            this.services = services;
        }

        protected void button1_Click(object sender, EventArgs e)
        {

            object selected = objectFromBoxes();
            this.services.insert(selected);
        }

        protected void button2_Click(object sender, EventArgs e)
        {
            object updated = objectFromBoxes();
            this.services.update(updated);

        }

        protected void button3_Click(object sender, EventArgs e)
        {
            object updated = objectFromBoxes();
            this.services.delete(updated);

        }

        protected virtual void button4_Click(object sender, EventArgs e)
        {
            enableCRUD();
            List<Client> clients = this.services.getClients();
            this.dataGridView1.DataSource = clients;
            Factory<Client> fact = new Factory<Client>();
            List<TextBox> txBoxes = fact.createTextboxes();
            Type t = Type.GetType("WindowsFormsApp2.Client");
            this.TableModel = t;
            enableCRUD();
            setTxBoxes(txBoxes, t);
            Console.WriteLine("Here");


        }

        protected virtual void Complaints_Click(object sender, EventArgs e)
        {
            disableCRUD();
            List<Complaint> clients = this.services.getComplaints();
            this.dataGridView1.DataSource = clients;
            this.TableModel = Type.GetType("WindowsFormsApp2.Complaint");
        }

        protected virtual  void button5_Click(object sender, EventArgs e)
        {
            disableCRUD();

            List<Complaint> clients = this.services.getComplaintsPending();
            this.dataGridView1.DataSource = clients;
            this.TableModel = Type.GetType("WindowsFormsApp2.Complaint");
            Console.WriteLine("here");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int row = this.dataGridView1.SelectedCells[0].RowIndex;
            int id = Int32.Parse(this.dataGridView1.Rows[row].Cells["id"].Value.ToString());//dami idul randului selectat
            if (this.services.approveRequest(id))
            {
                MessageBox.Show("Approved!");
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
    }
}
