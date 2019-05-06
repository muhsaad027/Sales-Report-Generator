using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;


namespace grandee_project
{
    public partial class Sales : MaterialForm
    {
        public int temp;
        public double total;
        public double balance;
        public int a ;
        static string cono = ConfigurationManager.ConnectionStrings["grandee_project.Properties.Settings.samamaConnectionString"].ToString();
        public int id;
        public int c = 0;
        public Sales()
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

        private void Sales_Load(object sender, EventArgs e)
        {
           // string cono = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Samama\\grandee project\\samama.mdf\";Integrated Security=True";
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
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string id_customer,temp_id="";
            
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
            MessageBox.Show(""+id);
             temp = (int.Parse(materialSingleLineTextField3.Text) * 1);
            total = temp * double.Parse(materialSingleLineTextField6.Text);
             balance = total - int.Parse(materialSingleLineTextField9.Text);
            //string cono = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Samama\\grandee project\\samama.mdf\";Integrated Security=True";

            SqlConnection con = new SqlConnection(cono);
            con.Open();
            SqlCommand sc = new SqlCommand("insert into Sales(id_cus,item,date,bags,rate,vehicle_no,total_ammount,paid_amount,balance_amount) " +
                "values('" + id + "','" + materialSingleLineTextField1.Text + "','" + (dateTimePicker1.Text)+ "'" +
                ",'" + Convert.ToInt32(materialSingleLineTextField3.Text) + "','" + Convert.ToDouble(materialSingleLineTextField6.Text) +"'" +
                ",'" + materialSingleLineTextField2.Text + "','" + Convert.ToInt32(total) + "','" + materialSingleLineTextField9.Text + "','"
                + Convert.ToInt32(balance) + "');", con);


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

            //string cono = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Samama\\grandee project\\samama.mdf\";Integrated Security=True";
            using (IDbConnection db = new SqlConnection(cono))
            {
                if (db.State == ConnectionState.Closed)
                {
                
                    db.Open();
                    string querry = "select * from Sales";
                    salesrepBindingSource3.DataSource = db.Query<salesrep>(querry, commandType: CommandType.Text);
                    db.Close();
                }
                
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            //string cono = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Samama\\grandee project\\samama.mdf\";Integrated Security=True";

            using (IDbConnection db = new SqlConnection(cono))
            {
                
                if (db.State == ConnectionState.Closed)
                {

                    db.Open();
                    
                    
                    string querry = "select s.id_sale, c.id_cus,c.cus_name,c.cus_phone,c.cus_account, s.date,s.item,s.vehicle_no,s.bags,s.rate,s.total_ammount,s.paid_amount,s.balance_amount " +
                        "from Sales s, Customer c "+
                        "where s.id_cus = c.id_cus AND c.id_cus = '"+materialSingleLineTextField4.Text+"' AND date between'"+dateTimePicker2.Value+"'and'"+dateTimePicker3.Value+"' ";
                    // salesrepBindingSource1.DataSource = db.Query<salesrep>(querry, commandType: CommandType.Text);
                    List<salesrep> list = db.Query<salesrep>(querry, commandType: CommandType.Text).ToList();
                    

                    db.Close();
                    using (frmprint n = new frmprint(c,list, dateTimePicker2.Value.ToShortDateString(), dateTimePicker3.Value.ToShortDateString()))
                        n.ShowDialog();
                    //SqlConnection sql = new SqlConnection(cono);
                    //sql.Open();
                    //string qury = "select SUM(balance_amount) from Sales s,Customer c where s.id_cus = c.id_cus AND s.id_cus = '" + materialSingleLineTextField4.Text + "' AND date between'" + dateTimePicker2.Value + "'and'" + dateTimePicker3.Value + "' ";
                    //SqlCommand ss = new SqlCommand(qury, sql);
                    //SqlDataReader sqr;
                    //try
                    //{
                    //    sqr = ss.ExecuteReader();
                    //    while (sqr.Read())
                    //    {

                    //        a = sqr.GetInt32(0);


                    //    }
                        
                    //    MessageBox.Show(a.ToString());

                       
                    //}
                    
                    //catch
                    //{

                    //    ss.ExecuteNonQuery();
                    //}
                    //cono.Clone();


                }
              

            }
          
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
           // string cono = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Samama\\grandee project\\samama.mdf\";Integrated Security=True";
            SqlConnection con1 = new SqlConnection(cono);
            SqlCommand sc = new SqlCommand("Delete from Sales WHERE id_sale='" + materialSingleLineTextField5.Text + "';", con1);
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
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            //string cono = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Samama\\grandee project\\samama.mdf\";Integrated Security=True";
            SqlConnection con1 = new SqlConnection(cono);
            
            con1.Open();
            SqlCommand cm1 = con1.CreateCommand();
            cm1.CommandType = CommandType.Text;
            cm1.CommandText = "Select * from Sales";
            cm1.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sdr = new SqlDataAdapter(cm1);
            sdr.Fill(dt);
            con1.Close();
            dataGridView1.DataSource = dt;
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cono);

            SqlCommand sc = new SqlCommand("Update Sales set id_cus='" + id + "',item='" + materialSingleLineTextField1.Text + "',date='" + dateTimePicker1.Text + "',bags='" +materialSingleLineTextField3.Text + "',rate='" + materialSingleLineTextField6.Text + "',vehicle_no='" + materialSingleLineTextField2.Text + "',total_ammount='" + total + "',paid_amount='" + materialSingleLineTextField9.Text + "',balance_amount='" + balance + "' WHERE id_sale='" + materialSingleLineTextField5.Text + "'; ", con);
            SqlDataReader sdr;
            try
            {
                con.Open();
                sdr = sc.ExecuteReader();
                // int o = sc.ExecuteNonQuery();
                MessageBox.Show("update");
                while (sdr.Read())
                { }
                
            }
           
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            //using (IDbConnection db = new SqlConnection(cono))
            //{

            //    if (db.State == ConnectionState.Closed)
            //    {

            //        db.Open();


            //        string querry = "select s.id_sale, c.id_cus,c.cus_name,c.cus_phone,c.cus_account, s.date,s.item,s.vehicle_no,s.bags,s.rate,s.total_ammount,s.paid_amount,s.balance_amount " +
            //            "from Sales s, Customer c " +
            //            "where s.id_cus = c.id_cus AND c.id_cus = '" + materialSingleLineTextField4.Text + "' AND date between'" + dateTimePicker2.Value + "'and'" + dateTimePicker3.Value + "' ";
            //        // salesrepBindingSource1.DataSource = db.Query<salesrep>(querry, commandType: CommandType.Text);
            //        List<salesrep> list = db.Query<salesrep>(querry, commandType: CommandType.Text).ToList();


            //        db.Close();
            //        using (frmprint n = new frmprint(list, dateTimePicker2.Value.ToShortDateString(), dateTimePicker3.Value.ToShortDateString()))
            //            n.ShowDialog();
            //        SqlConnection sql = new SqlConnection(cono);
            //        sql.Open();
            //        string qury = "select SUM(balance_amount) from Sales s,Customer c where s.id_cus = c.id_cus AND s.id_cus = '" + materialSingleLineTextField4.Text + "' AND date between'" + dateTimePicker2.Value + "'and'" + dateTimePicker3.Value + "' ";
            //        SqlCommand sso = new SqlCommand(qury, sql);
            //        SqlDataReader sqr;
            //        try
            //        {
            //            sqr = sso.ExecuteReader();
            //            while (sqr.Read())
            //            {

            //                a = sqr.GetInt32(0);


            //            }



            //        }

            //        catch
            //        {

            //            sso.ExecuteNonQuery();
            //        }


            Form4 no = new Form4( dateTimePicker2.Value.ToShortDateString(), dateTimePicker3.Value.ToShortDateString());
             no.StartPosition = FormStartPosition.CenterScreen;
                    no.ShowDialog(this);
          

        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(a.ToString());
            SqlConnection con = new SqlConnection(cono);
            con.Open();
            //a = a + Convert.ToInt32(materialSingleLineTextField7.Text);
            SqlCommand sc = new SqlCommand("insert into Balances(b_cusId,date,BalanceAmount) " +
                "values('" + Convert.ToInt32(materialSingleLineTextField4.Text) + "','" + DateTime.Now + "'" +
                ",'" + materialSingleLineTextField7.Text + "');", con);

            int o = sc.ExecuteNonQuery();
            MessageBox.Show(o + "inserted");
            con.Close();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            SqlConnection con1 = new SqlConnection(cono);

            con1.Open();
            SqlCommand cm1 = con1.CreateCommand();
            cm1.CommandType = CommandType.Text;
            cm1.CommandText = "Select * from Sales where id_cus='" + id + "' ";
            cm1.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sdr = new SqlDataAdapter(cm1);
            sdr.Fill(dt);
            con1.Close();
            dataGridView1.DataSource = dt;
        }
    }
    }

