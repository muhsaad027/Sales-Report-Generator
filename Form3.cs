using System;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Configuration;

namespace grandee_project
{
    public partial class Form3 : MaterialForm
    {
        static string cono = ConfigurationManager.ConnectionStrings["grandee_project.Properties.Settings.samamaConnectionString"].ToString();
        

        public Form3()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Orange400,
                Primary.DeepOrange800, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {
           
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
         
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        { 
            Form5 n = new Form5();
            n.Show();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            //insert
            SqlConnection con = new SqlConnection(cono);
            con.Open();
            SqlCommand sc = new SqlCommand("INSERT INTO VENDOR VALUES('" + materialSingleLineTextField1.Text + "','" + materialSingleLineTextField3.Text + "','" + materialSingleLineTextField5.Text + "');", con);
            int o = sc.ExecuteNonQuery();
            MessageBox.Show(o + "inserted");


            materialSingleLineTextField1.Clear();
            materialSingleLineTextField3.Clear();
            materialSingleLineTextField5.Clear();
            con.Close();

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            //string cono = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Samama\\grandee project\\samama.mdf\";Integrated Security=True";
            SqlConnection con = new SqlConnection(cono);
            con.Open();
            SqlCommand sc = new SqlCommand("INSERT INTO CUSTOMER VALUES('" + materialSingleLineTextField8.Text + "','" + materialSingleLineTextField10.Text + "','" + materialSingleLineTextField12.Text + "');", con);
            int o = sc.ExecuteNonQuery();
            MessageBox.Show(o + "inserted");


            materialSingleLineTextField8.Clear();
            materialSingleLineTextField10.Clear();
            materialSingleLineTextField12.Clear();
            con.Close();
        }
    }
}
