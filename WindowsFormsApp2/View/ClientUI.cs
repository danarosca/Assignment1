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
using Microsoft.VisualBasic;
namespace WindowsFormsApp2.View
{
    public partial class ClientUI : WindowsFormsApp2.View.BaseForm
    {
        private ClientCore services;

        public ClientUI(ClientCore services)
        {
            InitializeComponent();
            this.services = services;


           
        }

        public void checkComplaints()
        {
            List < Complaint > complaints= this.services.checkComplaints();
            if (complaints.Count > 0)
            {
                foreach (var f in complaints)
                {
                    new Survey(f,this.services.getUserId(),this.services).Show();

                }
            }
        }
        private void Client_Load(object sender, EventArgs e)
        {
            checkComplaints();

        }
        void updateBills(bool areTheyPaid)
        {
            List<Bill> bills = this.services.getBills(areTheyPaid);

            Factory<Bill> fact = new Factory<Bill>();
            DataTable billTable = fact.createTable(bills);
            this.dataGridView1.DataSource = billTable;
            this.button2.Visible = true;
            this.TableModel = Type.GetType("Bill");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            updateBills(false);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = getGridId();
            MessageBox.Show("The operation to pay bill no." + id.ToString() + "was:" + this.services.payBill(id));
            updateBills(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button2.Visible = false;
            updateBills(true);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Shortly describe your problem", "File a complaint", "", -1, -1);
            if (input != "")
            {
                if (this.services.addComplaint(input))
                {
                    MessageBox.Show("Filled Complaint");
                    return;
                }
            }

            MessageBox.Show("Error");

        }
    }
}
