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


        private void button1_Click(object sender, EventArgs e)
        {
            
        }


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
                DataTable datasubmenu = DBConnect.Selectdb("select * from setup_menu where induk='" + datamenu.Rows[a]["menu"].ToString() + "' order by urut");
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



        ///Event for Closing Window  
        protected void btnClose_Click(object sender, EventArgs e)
        {
            String s = sender.ToString();
            MessageBox.Show("You Clicked " +  s.Substring(28) + " , " + e.ToString() , "RunTime Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Application.Exit();
        }


    }
}
