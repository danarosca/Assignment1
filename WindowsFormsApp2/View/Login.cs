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
    public partial class Login : Form
    {
        private LoginCore services;
        public Login(LoginCore services)

        {
            InitializeComponent();
            this.services = services;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            User user=services.checkUser(username, password);
            try
            {
                switch (user.rights)
                {
                    case "employee":
                        new Employee(new EmployeeCore(user)).Show();
                        break;
                    case "client":
                        new ClientUI(new ClientCore(user)).Show();

                        break;
                    case "manager":
                        new Manager(new ManagerCore(user)).Show();
                        break;

                    default:
                        MessageBox.Show("System Error:");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Caught error when retrieveing user from db");
            }
            
        }
    }
}
