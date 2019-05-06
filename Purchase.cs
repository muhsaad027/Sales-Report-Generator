using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;

namespace grandee_project
{
    public partial class Purchase : MaterialForm
    {
        static string cono = ConfigurationManager.ConnectionStrings["grandee_project.Properties.Settings.samamaConnectionString"].ToString();
        SqlConnection con1 = new SqlConnection(cono);
        public int id;
        double temp, total, balance;
        private readonly object o;
        int a = 0;
        public Purchase()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Orange400,
                Primary.DeepOrange800, Accent.LightBlue200,
                TextShade.WHITE);

            SqlConnection con = new SqlConnection(cono);
            con.Open();
            SqlCommand sc = new SqlCommand("select id_vendor,v_name from Vendor;", con);
            SqlDataReader myReader;
            try
            {
                myReader = sc.ExecuteReader();
                while (myReader.Read())
                {
                    string pa_forename = myReader["id_vendor"] + "--------------------------" + myReader["v_name"];
                    comboBox1.Items.Add(pa_forename);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Purchase_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string id_purchase, temp_id = "";

            id_purchase = comboBox1.Text;
            char[] arr = id_purchase.ToCharArray();
            for (int i = 0; i < id_purchase.Length; i++)
            {
                if (arr[i] == '-')
                {
                    break;
                }
                else
                {
                    temp_id += Convert.ToString(arr[i]);
                }
            }
            id = Int32.Parse(temp_id);
            MessageBox.Show("" + id);
             temp = (double.Parse(materialSingleLineTextField6.Text))/( double.Parse(materialSingleLineTextField5.Text));
            // (int.Parse(materialSingleLineTextField3.Text) * 50);
            total = (temp * double.Parse(materialSingleLineTextField4.Text))-(int.Parse(materialSingleLineTextField8.Text)) + (int.Parse(materialSingleLineTextField7.Text));

            balance = total - double.Parse(materialSingleLineTextField9.Text);
           // double paid = total - int.Parse(materialSingleLineTextField9.Text);
            //string cono = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Samama\\grandee project\\samama.mdf\";Integrated Security=True";

            SqlConnection con = new SqlConnection(cono);
            con.Open();
            SqlCommand sc = new SqlCommand("insert into Purchase(" +
                "id_ven," +
                "item," +
                "date," +
                "vehicle_no," +
                "bags," +
                "rpb," +
                "wpb," +
                "rate," +
                "weight," +
                "total_amount," +
                "add_amount," +
                "less_amount," +
                "paid," +
                "balance_amount) " +
                "values" +
                "('" + id + "'," +
                "'" + materialSingleLineTextField1.Text + "'," +
                "'" +(dateTimePicker1.Text) + "'" + 
                ",'"+materialSingleLineTextField2.Text+"'," +
                "'"+materialSingleLineTextField3.Text+"'," +
                "'" + Convert.ToDecimal(materialSingleLineTextField6.Text) + "'," +
                "'" + Convert.ToDouble(materialSingleLineTextField5.Text) + "'" +
                ",'" + temp + "'" +
                ",'" +Convert.ToDouble(materialSingleLineTextField4.Text) + "'" +
                ",'" + total + "','"
                + Convert.ToDouble(materialSingleLineTextField7.Text) + "'" +
                ",'"+ Convert.ToDouble(materialSingleLineTextField8.Text) + "'" +
                ",'"+ Convert.ToDouble(materialSingleLineTextField9.Text) + "'" +
                ",'" + balance + "');", con);
            int o = sc.ExecuteNonQuery();
            MessageBox.Show(o + "inserted");
            materialSingleLineTextField1.Clear();
            materialSingleLineTextField3.Clear();
            materialSingleLineTextField2.Clear();
            materialSingleLineTextField6.Clear();
            materialSingleLineTextField9.Clear();
            con.Close();
            using (IDbConnection db = new SqlConnection(cono))
            {
                if (db.State == ConnectionState.Closed)
                {

                    db.Open();
                    string querry = "select * from Purchase";
                   purchaserepBindingSource1.DataSource = db.Query<Purchaserep>(querry, commandType: CommandType.Text);
                    db.Close();
                }

            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using (IDbConnection db = new SqlConnection(cono))
            //{
            //    if (db.State == ConnectionState.Closed)
            //    {

            //        db.Open();
            //        string querry = "select * from Purchase where id_purcahse='"+ id +"' ";
            //        purchaserepBindingSource1.DataSource = db.Query<Purchaserep>(querry, commandType: CommandType.Text);
            //        db.Close();
            //    }

            //}
            // MessageBox.Show(o + "inserted");
            string id_purchase, temp_id = "";

            id_purchase = comboBox1.Text;
            char[] arr = id_purchase.ToCharArray();
            for (int i = 0; i < id_purchase.Length; i++)
            {
                if (arr[i] == '-')
                {
                    break;
                }
                else
                {
                    temp_id += Convert.ToString(arr[i]);
                }
            }
            id = Int32.Parse(temp_id);
            if (con1.State == ConnectionState.Closed)
            {

                con1.Open();
                SqlCommand cm1 = con1.CreateCommand();
                cm1.CommandType = CommandType.Text;
                cm1.CommandText = "select * from Purchase where id_ven='" + id + "' ";
                cm1.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sdr = new SqlDataAdapter(cm1);
                sdr.Fill(dt);

                dataGridView1.DataSource = dt;
                //string querry = "select * from Customer";
                // addcustomerBindingSource.DataSource = con1.Query<addcustomer>(querry, commandType: CommandType.Text);
                purchaserepBindingSource1.DataSource = dt;
                con1.Close();
            }
        }

        private void materialSingleLineTextField6_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField3_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
        
            using (IDbConnection db = new SqlConnection(cono))
            {

                if (db.State == ConnectionState.Closed)
                {

                    db.Open();


                    string querry = "select * from Purchase,Vendor where Purchase.id_ven = Vendor.id_vendor AND Vendor.id_vendor = '" + materialSingleLineTextField10.Text + "' AND date between'" + dateTimePicker2.Value + "'and'" + dateTimePicker3.Value + "' ";
                    // salesrepBindingSource1.DataSource = db.Query<salesrep>(querry, commandType: CommandType.Text);
                    List<Purchaserep> list1 = db.Query<Purchaserep>(querry, commandType: CommandType.Text).ToList();

              
                    
                   

                    db.Close();
                   


                    using (frmprint2 n = new frmprint2(list1, dateTimePicker2.Value.ToShortDateString(), dateTimePicker3.Value.ToShortDateString()))
                       
                   
                    n.ShowDialog();

                }
                

            }

        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            if (con1.State == ConnectionState.Closed)
            {

                con1.Open();
                SqlCommand cm1 = con1.CreateCommand();
                cm1.CommandType = CommandType.Text;
                cm1.CommandText = "Select * from Purchase";
                cm1.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sdr = new SqlDataAdapter(cm1);
                sdr.Fill(dt);

                dataGridView1.DataSource = dt;
                //string querry = "select * from Customer";
                // addcustomerBindingSource.DataSource = con1.Query<addcustomer>(querry, commandType: CommandType.Text);
                purchaserepBindingSource1.DataSource = dt;
                con1.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            SqlCommand sc = new SqlCommand("Delete from Purchase WHERE id_purcahse='" + materialSingleLineTextField11.Text + "';", con1);
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

        private void materialSingleLineTextField4_Click(object sender, EventArgs e)
        {
           
        }

        private void materialSingleLineTextField7_Click(object sender, EventArgs e)
        {

        }
    }
}
