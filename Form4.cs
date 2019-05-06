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
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;

namespace grandee_project
{
    public partial class Form4 : MaterialForm
    {
        static string cono = ConfigurationManager.ConnectionStrings["grandee_project.Properties.Settings.samamaConnectionString"].ToString();

        public int textid;
        public string todate;
        public string fromdate;
      public   int id;
        int a=0;
        int b=0;
        public Form4(string _todate,string _fromdate)
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal300,
                Primary.Teal500, Accent.LightBlue200,
                TextShade.WHITE);
            
            this.todate = _todate;
            this.fromdate = _fromdate;
            
            //this._id = id;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cono);
            con.Open();
            SqlCommand sc = new SqlCommand("select id_cus,cus_name from Customer;", con);
            SqlDataReader myReader;
            try
            {
                myReader = sc.ExecuteReader();
                while (myReader.Read())
                {
                    string pa_forename = myReader["id_cus"] + "-.............................." + myReader["cus_name"];
                    comboBox1.Items.Add(pa_forename);
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        
            con.Close();



        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
           

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(cono);
            con.Open();
            //SqlCommand sc = new SqlCommand("Update Balances set b_cusId='" + id + "',date='" + DateTime.Now + "',PaidAmount='" + textBox1.Text + "',BalanceAmount=BalanceAmount -'" +textBox1.Text +"' +'"+_bal+ "';", con);
            SqlCommand sc = new SqlCommand("Update Balances set date='" + DateTime.Now + "',PaidAmount='" + textBox1.Text + "',BalanceAmount=BalanceAmount -'" + textBox1.Text + "'where b_cusId='" + id + "';", con);

            //MessageBox.Show("insert into Sales(id_cus,item,date,bags,rate,vehicle_no,total_ammount,paid_amount,balance_amount) " +
            //    "values('" + id + "','" + materialSingleLineTextField1.Text + "','" + dateTimePicker1.Text + "'" +
            //    ",'" + Convert.ToInt32(materialSingleLineTextField3.Text) + ",'" + Convert.ToInt32(materialSingleLineTextField6.Text) + "" +
            //    ",'" + materialSingleLineTextField2.Text + "','" + Convert.ToInt32(total) + "','" + materialSingleLineTextField9.Text + "','"
            //    + Convert.ToInt32(bakance) + "');"
            //    );
            //Debug.WriteLine(""+ "insert into Sales(id_cus,item,date,bags,rate,vehicle_no,total_ammount,paid_amount,balance_amount) " +
            //    "values('" + id + "','" + materialSingleLineTextField1.Text + "','" + dateTimePicker1.Text + "'" +
            //    ",'" + Convert.ToInt32(materialSingleLineTextField3.Text) + "','" + Convert.ToInt32(materialSingleLineTextField6.Text) + "" +
            //    ",'" + materialSingleLineTextField2.Text + "','" + Convert.ToInt32(total) + "','" + materialSingleLineTextField9.Text + "','"
            //    + Convert.ToInt32(bakance) + "');");



            int o = sc.ExecuteNonQuery();
            MessageBox.Show(o + "inserted");
            //materialSingleLineTextField1.Clear();
            //materialSingleLineTextField3.Clear();
            //materialSingleLineTextField2.Clear();
            //materialSingleLineTextField6.Clear();
            //materialSingleLineTextField9.Clear();
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string id_customer, temp_id = "";

            id_customer = comboBox1.Text;
            char[] arr = id_customer.ToCharArray();
            for (int i = 0; i < id_customer.Length; i++)
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(cono))
            {

                if (db.State == ConnectionState.Closed)
                {

                    db.Open();


                    string querry = "select s.id_sale, c.id_cus,c.cus_name,c.cus_phone,c.cus_account, s.date,s.item,s.vehicle_no,s.bags,s.rate,s.total_ammount,s.paid_amount,s.balance_amount " +
                        "from Sales s, Customer c " +
                        "where s.id_cus = c.id_cus AND c.id_cus = '" + id + "' AND date between'" + todate + "'and'" + fromdate + "' ";
                    // salesrepBindingSource1.DataSource = db.Query<salesrep>(querry, commandType: CommandType.Text);
                    List<salesrep> list = db.Query<salesrep>(querry, commandType: CommandType.Text).ToList();


                    db.Close();





                SqlConnection sql = new SqlConnection(cono);
                sql.Open();
                string qury = "SELECT BalanceAmount from Balances WHERE b_cusId='" + id + "'";
                SqlCommand ss = new SqlCommand(qury, sql);
                SqlDataReader sqr;
                try
                {
                    sqr = ss.ExecuteReader();
                    while (sqr.Read())
                    {

                        b = sqr.GetInt32(0);


                    }
                 sqr.Close();


                }
                catch
                {

                    ss.ExecuteNonQuery();
                }
                sql.Close();

















                SqlConnection sqls = new SqlConnection(cono);
                sqls.Open();
                string qurey = "select SUM(balance_amount) from Sales s,Customer c where s.id_cus = c.id_cus AND s.id_cus = '" + id + "' AND date between'" + todate + "'and'" + fromdate + "' ";
                SqlCommand sso = new SqlCommand(qurey, sqls);
                SqlDataReader sq;
                try
                {
                    sq = sso.ExecuteReader();
                    while (sq.Read())
                    {

                        a = sq.GetInt32(0);


                    }
                        

                        sq.Close();

                       

                    }
                catch
                {

                    sso.ExecuteNonQuery();
                }
                sqls.Close();


                    using (frmprint n = new frmprint(b, list, todate, fromdate))

                        n.ShowDialog();


                    
                }

                SqlConnection con = new SqlConnection(cono);
                con.Open();
                SqlCommand sc = new SqlCommand("Update Balances set BalanceAmount=BalanceAmount +'" + a + "' where b_cusId='"+id+"';", con);
                int o = sc.ExecuteNonQuery();
                MessageBox.Show(o + "iupdate");
                con.Close();
            }
        }

        private void materialRaisedButton2_Click_1(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(cono))
            {
                if (db.State == ConnectionState.Closed)
                {

                    db.Open();
                    string querry = "select * from Balances";
                    savBindingSource.DataSource = db.Query<sav>(querry, commandType: CommandType.Text);
                    db.Close();
                }

            }
        }

        private void savBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(cono);
            SqlCommand sc = new SqlCommand("Delete from Balances WHERE b_cusId='" + id + "';", con1);
            SqlDataReader sdr;
            try
            {


                con1.Open();
                sdr = sc.ExecuteReader();
                // int o = sc.ExecuteNonQuery();
                MessageBox.Show("deleted");
                while (sdr.Read())
                { }
                con1.Close();
                sdr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
