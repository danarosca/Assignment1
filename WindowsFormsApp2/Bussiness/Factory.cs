using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Factory<T>
    {

        //generic class
        //cand instantiez clasa T devine CLient sau Bill.....
        //properties inseamna de ex. id pentru Client
        public Factory()
        {

        }

        public List<TextBox> createTextboxes()
        {

            List<TextBox> txBoxes = new List<TextBox>();
            for (int i = 0; i < typeof(T).GetProperties().Length; i++)
            {
                TextBox aux = new TextBox();
                aux.Location = new System.Drawing.Point(100 * i, 400);
                aux.Text ="";
                txBoxes.Add(aux);
                aux.Visible = true;
            }
            return txBoxes;
        }


        DataTable populateTable(DataTable dt, List<T> items)
        {
            foreach (var f in items)
            {
                DataRow dr = dt.NewRow();
                //populate table
                var fields = typeof(T).GetProperties();
                foreach (var t in fields)
                {
                    dr[t.Name] = typeof(T).GetProperty(t.Name).GetValue(f);
                }
                dt.Rows.Add(dr);


            }
            return dt;

        }
        
        public DataTable createTable(List<T> items)
        {
            DataTable tab = new DataTable();
           foreach (var f in typeof(T).GetProperties())
            {
                tab.Columns.Add(new DataColumn(f.Name, Nullable.GetUnderlyingType(
            f.PropertyType) ?? f.PropertyType));

            }
           

            return populateTable(tab,items);
        }
    }
}
