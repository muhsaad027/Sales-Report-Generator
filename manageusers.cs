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
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;
using System.Configuration;

namespace grandee_project
{
    public partial class manageusers : MaterialForm
    {
        //static string cono = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Samama\\grandee project\\samama.mdf\";Integrated Security=True";

        static string cono = ConfigurationManager.ConnectionStrings["grandee_project.Properties.Settings.samamaConnectionString"].ToString();

        SqlConnection con1 = new SqlConnection(cono);
        public manageusers()
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

        private void manageusers_Load(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {


           SqlCommand sc = new SqlCommand("Delete from Customer WHERE id_cus='" + materialSingleLineTextField2.Text + "';", con1);
            SqlDataReader sdr;
            if (con1.State == ConnectionState.Closed)
                try
                {
                    con1.Open();

                    
                    sdr = sc.ExecuteReader();
                    // int o = sc.ExecuteNonQuery();
                    MessageBox.Show("deleted");
                    while (sdr.Read())
                    { }
                    con1.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {

            if (con1.State == ConnectionState.Closed)



                con1.Open();
            SqlCommand cmd1 = con1.CreateCommand();



            cmd1.CommandText = "Select * from Customer where  id_cus= '" + materialSingleLineTextField1.Text + "'";
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sdr = new SqlDataAdapter(cmd1);

            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            con1.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
                if (con1.State == ConnectionState.Closed)
                {

                    con1.Open();
                SqlCommand cm1 = con1.CreateCommand();
                cm1.CommandType = CommandType.Text;
                cm1.CommandText = "Select * from Customer";
                cm1.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sdr = new SqlDataAdapter(cm1);
                sdr.Fill(dt);

                dataGridView1.DataSource = dt;
                //string querry = "select * from Customer";
                // addcustomerBindingSource.DataSource = con1.Query<addcustomer>(querry, commandType: CommandType.Text);
                addcustomerBindingSource.DataSource = dt;
                con1.Close();
                }
            
            
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
