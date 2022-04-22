using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_raz
{
    public partial class Teams_Main : Form
    {
        Team[]teams=new Team[5];
        
        
        public Teams_Main()
        {
            teams[0] = new Team();
            teams[0].setAll(1, "Miami Heat", "MIA", "1.jpg");
            teams[1] = new Team();
            teams[1].setAll(2, "Orlando Magic", "ORL", "2.jpg");
            teams[2] = new Team();
            teams[2].setAll(3, "Atlanta Hanks", "ATL", "3.jpg");
            teams[3] = new Team();
            teams[3].setAll(4, "Washington Wizards", "WSH", "4.jpg");
            teams[4] = new Team();
            teams[4].setAll(5, "Charlotte hornest", "CHA", "5.jpg");
            InitializeComponent();
            for (int i = 0; i < 5; i++)
                tabPage1.Controls["tableLayoutPanel1"].Controls["pane" + (i + 1)].Controls["Team" + (i + 1)].Text = teams[i].name;  

        }

        private void Teams_Main_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form TeamsForm = new Team_Detail();
            TeamsForm.Show();
        }
    }
}
