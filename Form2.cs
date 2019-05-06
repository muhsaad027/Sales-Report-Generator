using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MaterialSkin;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grandee_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            //    this.WindowState = FormWindowState.Maximized;
             this.FormBorderStyle = FormBorderStyle.None;
            //    this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;
            //var skinmanager = MaterialSkinManager.Instance;
            //skinmanager.AddFormToManage(this);
            //skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            //SkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal300,
            //    Primary.Teal500, Accent.LightBlue200,
            //    TextShade.WHITE);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button2.Height;
            panelLeft.Top = button2.Top;
            Purchase oFrm = new Purchase();
            oFrm.StartPosition = FormStartPosition.CenterScreen;
            oFrm.ShowDialog(this);
            oFrm.Dispose();
            oFrm = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button5.Height;
            panelLeft.Top = button5.Top;
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button3.Height;
            panelLeft.Top = button3.Top;
            Sales no = new Sales();
            no.StartPosition = FormStartPosition.CenterScreen;
            no.ShowDialog(this);
            no.Dispose();
            no = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button4.Height;
            panelLeft.Top = button4.Top;
            selectuser na = new selectuser();
            na.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
