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
        Player[] player= new Player[5];
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
    }
}
