using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.View;
using WindowsFormsApp2.Bussiness;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login(new LoginCore());
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientRegistration newRegister = new ClientRegistration(new RegistrationCore());
            newRegister.Show();
                    
        }
    }
}
