using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.View
{
    public partial class BaseForm : Form
    {
        protected List<TextBox> txBoxes;
        protected Type TableModel ;
        
        public BaseForm()
        {
            InitializeComponent();
            this.dataGridView1.AllowUserToAddRows = false;
        }
        public object objectFromBoxes()
        {
            var obj = Activator.CreateInstance(TableModel);
            for (int i = 0; i < txBoxes.Count; i++)
            {
                var property = TableModel.GetProperties()[i];
                Type fieldType =property.PropertyType ;
                string content = txBoxes[i].Text.Split(' ')[0];
                if (content=="")
                {
                    content = "0";

                }
                var foo = Convert.ChangeType(content, fieldType);
                TableModel.GetProperties()[i].SetValue(obj, foo);//convert data to match field type

            }
            return obj;
        }
        public void enableCRUD()
        {
            this.panel1.Visible = true;
            this.flowLayoutPanel1.Visible = true;
        }
        public void disableCRUD()
        {
            this.panel1.Visible = false;
            this.flowLayoutPanel1.Visible = false;
        }


        public void setTxBoxes(List<TextBox> txBoxes, Type t)
        {
            this.flowLayoutPanel1.Controls.Clear();
            this.TableModel = t;
            foreach (var f in txBoxes)
            {
                this.flowLayoutPanel1.Controls.Add(f);

            }
            this.txBoxes = txBoxes;

        }
       protected void populateBoxes(object obj)
        {

            Type r = obj.GetType();

            for (int i = 0; i < r.GetProperties().Length; i++)
            {
                this.txBoxes.ElementAt(i).Text = r.GetProperties()[i].GetValue(obj).ToString();

            }

        }

     
        public int getGridId()
        {
            int id = -1;
            try
            {

                int row = this.dataGridView1.SelectedCells[0].RowIndex;
                var test = dataGridView1.Rows[row].Cells["id"].Value.ToString();
                id = Int32.Parse(test);

            }
            catch
            {
                MessageBox.Show("Cannot retrieve id");

            }
            finally
            {
                Console.WriteLine("The selected id is " + id.ToString());
            }
            return id;
        }
    

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        protected  void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txBoxes!=null)
            {
                int row = this.dataGridView1.SelectedCells[0].RowIndex;
                var selected = Activator.CreateInstance(this.TableModel);
                int collumn = 0;
                foreach (var f in this.TableModel.GetProperties())
                {

                    string value = this.dataGridView1.Rows[row].Cells[collumn].Value.ToString();
                    dynamic changedValue = Convert.ChangeType(value, f.PropertyType);
                    f.SetValue(selected, changedValue);
                    collumn++;

                }

                populateBoxes(selected);
                var t = selected;

            }
        }

      

       

       
    }
}
