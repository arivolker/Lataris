using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lataris
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void tombolkonek_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnect.konekdb();
                labelstatus.Text = DBConnect.status;

                tombolexecute1.Enabled = true;
                tombolexecute2.Enabled = true;
                tombolexecute3.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void tombolexecute1_Click(object sender, EventArgs e)
        {
            DBConnect.Insertdb(edit_query1.Text);
            MessageBox.Show("Insert data berhasil");
        }


        private void tombolexecute2_Click(object sender, EventArgs e)
        {
            DataTable tampildata = new DataTable();
            tampildata = DBConnect.Selectdb(edit_query2.Text);

            //tampil data ke grid
            dataGrid1.DataSource = tampildata;

            //tampil data ke rich edit
            richTextBox1.Clear();
            for (var a = 0; a < tampildata.Rows.Count; a++)
            {
                richTextBox1.AppendText( (a+1).ToString() + 
                                            ". Username : " + tampildata.Rows[a]["username"].ToString() + 
                                            " , Level : " + tampildata.Rows[a]["level"].ToString() + 
                                            '\n');
            }

        }


        private void tombolexecute3_Click(object sender, EventArgs e)
        {
            DBConnect.Deletedb(edit_query3.Text);
            MessageBox.Show("Delete data berhasil");
        }
    }
}
