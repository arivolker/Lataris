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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private MainMenu Menuku;
        private MenuItem mainmenu, submenu;



        public void createmenu()
        {
            Menuku = new MainMenu();  // Install Menu

            // Ambil setting Menu data table menus
            DataTable datamenu = DBConnect.Selectdb("select * from setup_master_menu where induk='' order by urut");
            for (var a = 0; a < datamenu.Rows.Count; a++)
            {
                mainmenu = new MenuItem( datamenu.Rows[a]["desc"].ToString() );
                Menuku.MenuItems.Add(mainmenu); // Membuat Main Menu

                // Ambil setting SubMenu data table menus
                DataTable datasubmenu = DBConnect.Selectdb("select * from setup_master_menu where induk='" + datamenu.Rows[a]["menu"].ToString() + "' order by urut");
                for (var b = 0; b < datasubmenu.Rows.Count; b++)
                {
                    submenu = new MenuItem( datasubmenu.Rows[b]["desc"].ToString() , fungsimenu( datasubmenu.Rows[a]["aksi"].ToString() ));
                    mainmenu.MenuItems.Add(submenu); // Membuat Sub Menu
                }
            }

            this.Menu = Menuku;
        }


        private EventHandler fungsimenu(string kode)
        {
            EventHandler eventarg = new EventHandler(btnClose_Click); 

            if (kode == "file-open")
            {
                eventarg = new EventHandler(btnClose_Click);
            }

            return eventarg;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DBConnect.konekdb();
            //createmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView1.AutoGenerateColumns = false;
            Column1.DataPropertyName = "jnsgol";
            Column2.DataPropertyName = "nobb";
            Column3.DataPropertyName = "nosbb";
            Column4.DataPropertyName = "nmsbb";
            Column5.DataPropertyName = "";
            dataGridView1.DataSource = DBConnect.Selectdb("select * from m_gl");
            
            //dataGridView1.Rows.Add("A","B","C","D","E");
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Change the color of the row if the value on column1 is > 0
            if (dataGridView1.RowCount > 0) {
                if (e.ColumnIndex == 0 && e.Value.ToString() == "B")  // Column1
                {
                    //this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;  // Set font color red
                    this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.Font = new System.Drawing.Font(this.Font, FontStyle.Bold);   // Set Bold   
                }
            }
        }



        ///Event for Closing Window  
        protected void btnClose_Click(object sender, EventArgs e)
        {
            String s = sender.ToString();
            MessageBox.Show("You Clicked " +  s.Substring(28) + " , " + e.ToString() , "RunTime Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Application.Exit();
        }


    }
}
