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
    public partial class Team_Detail : Form
    {
        Team tm = new Team();
        public int teamId=0;

        public Team_Detail()
        {
            InitializeComponent();
        }

        private void Team_Detail_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Teams_Main.teams.Length; i++)
                if (Teams_Main.teams[i].teamId == this.teamId)
                        this.tm = Teams_Main.teams[i];

            label2.Text = this.tm.name;

            for (int i = 0; i < Form1.players.Length; i++)
                if (Form1.players[i].teamId == this.teamId)
                    dataGridView1.Rows.Add(Form1.players[i].playerId, Form1.players[i].firstName, Form1.players[i].lastName, Form1.players[i].gender, Form1.players[i].height, Form1.players[i].weight, Form1.players[i].email);
        }
    }
    }

