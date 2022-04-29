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
    public partial class Form1 : Form
    {
        //imgList
        country[] countries = new country[5];
       public static Player[] players= new Player[5];
        Team[] team= new Team[5];
        String[] imgList = new String[]
           {"0.jpg","1.jpg","2.jpg","3.jpg","4.jpg","5.jpg","6.jpg","7.jpg","8.jpg","9.jpg"};
        int index = 0;
        public Form1()
        {
            InitializeComponent();

            country country = new country();
            country.setCountryCode("ARG");
            country.setCountryName("Argentina");
            countries[0] = country;


            country.setCountryCode("AT");
            country.setCountryName("Austria");
            countries[1] = country;

            country.setCountryCode("AUS");
            country.setCountryName("Australia");
            countries[2] = country;

            country.setCountryCode("BI");
            country.setCountryName("Bosnia");
            countries[3] = country;

            country.setCountryCode("BIH");
            country.setCountryName("Bosnia Herzegovina");
            countries[4] = country;

            players[0]=new Player();
            players[0].setAll(1, "Williams", "Mo", "male", 1.85f, 89.8f, "1", "williams@gmail.com", "Us", 1);
            players[1] = new Player();
            players[1].setAll(2, "Edward Gee", "Alonzo", "male", 1.98f, 99f, "2", "edward@gmail.com", "Us", 2);
            players[2] = new Player();
            players[2].setAll(3, "O'Bryant", "Johnny", "male", 2.05f, 116f, "3", "brayn@gmail.com", "Us", 3);
            players[3] = new Player();
            players[3].setAll(4, "Gallinari", "Danilo", "male", 2.08f, 102f, "4", "gallenari@gmail.com", "Us", 4);
            players[4] = new Player();
            players[4].setAll(5, "Arthur", "Danilo", "male", 2.06f, 107f, "5", "arthur@gmail.com", "Us", 5);


            Team team = new Team();
            team.setAll(1, "Miami Heat", "MIA","1.jpg");
            team.setAll(2, "Orlando Magic", "ORL", "2.jpg");
            team.setAll(3, "Atlanta Hanks", "ATL", "3.jpg");
            team.setAll(4, "Washington Wizards", "WSH", "4.jpg");
            team.setAll(5, "Charlotte hornest", "CHA", "5.jpg");

            PositionName positionName = new PositionName();
            positionName.setAll(1, "SmallForward");
            positionName.setAll(2, "PowerForward");
            positionName.setAll(3, "Center");
            positionName.setAll(4, "ShootingGuard");
            positionName.setAll(5, "PointGuard");

            PositionOfPlayer positionOfPlayer = new PositionOfPlayer();
            positionOfPlayer.setAll(1, 1);
            positionOfPlayer.setAll(2, 2);
            positionOfPlayer.setAll(3, 3);
            positionOfPlayer.setAll(4, 4);
            positionOfPlayer.setAll(5, 5);

            pictureBox1.Load("../../../picture/" + imgList[0]);
            pictureBox2.Load("../../../picture/" + imgList[1]);
            pictureBox3.Load("../../../picture/" + imgList[2]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form VisitorForm = new Visitor_Menu();
            VisitorForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = index - 1;
            if (index - 3 < 0) index = imgList.Length - 3;
            pictureBox1.Load("../../../picture/" + imgList[index + 0]);
            pictureBox2.Load("../../../picture/" + imgList[index + 1]);
            pictureBox3.Load("../../../picture/" + imgList[index + 2]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index + 3 > imgList.Length) index = 0;
            pictureBox1.Load("../../../picture/" + imgList[index + 0]);
            pictureBox2.Load("../../../picture/" + imgList[index + 1]);
            pictureBox3.Load("../../../picture/" + imgList[index + 2]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
