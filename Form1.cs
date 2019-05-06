using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grandee_project
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Orange400,
                Primary.DeepOrange800, Accent.LightBlue200,
                TextShade.WHITE);
            materialLabel1.ForeColor = Color.White;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (materialSingleLineTextField2.Text == "samama" && materialSingleLineTextField1.Text == "123")
            {
                this.Hide();
                Form2 n = new Form2();
                n.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            samamaBill n = new samamaBill();
            n.Show();
        }
    }
}
