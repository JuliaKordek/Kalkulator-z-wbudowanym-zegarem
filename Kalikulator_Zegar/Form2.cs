using projekt1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proba1
{
    public partial class Form2 : Form
    {
        Timer zegar = new Timer();
        public Form2()
        {
            InitializeComponent();

            zegar.Interval = 1000;

            zegar.Tick += new EventHandler(this.zegar_Tick);

            zegar.Start();
        }
        private void zegar_Tick(object sender, EventArgs e)
        {
           
            int g = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;

            string time = "";

            if (g < 10)
            {
                time += "0" + g;
            }
            else
            {
                time += g;
            }
            time += ":";

            if (m < 10)
            {
                time += "0" + m;
            }
            else
            {
                time += m;
            }
            time += ":";
            if (s < 10)
            {
                time += "0" + s;
            }
            else
            {
                time += s;
            }
            ZEGAR.Text = time;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ZEGAR.ForeColor = Color.LightPink;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZEGAR.ForeColor = Color.LightGreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ZEGAR.ForeColor= Color.LightBlue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                ZEGAR.Font = fontDialog.Font;
            }
        }
    }
}

