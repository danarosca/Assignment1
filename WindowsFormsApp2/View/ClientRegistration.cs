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
    public partial class ClientRegistration : Form
    {
        RegistrationCore  services;
        public ClientRegistration(RegistrationCore core)
        {
            InitializeComponent();
            this.services = core;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Password = textBox6.Text;
            string Name = textBox1.Text;
            string idNr = textBox2.Text;
            string PNC = textBox2.Text;
            string address = textBox4.Text;
            string registrationNr = textBox5.Text;
            bool registered=this.services.addClient(Name,idNr,PNC,address,registrationNr, Password);
            if (registered)
            {
                MessageBox.Show("Account created");
                this.Close();
            }
            else
            {
                {
                    MessageBox.Show("Wrong registration number");
                }
            }
        


        }

        private void ClientRegistration_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
