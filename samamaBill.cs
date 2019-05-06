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
    public partial class samamaBill : MaterialForm
    {
        public string rateresult, totalresult, ratedgv;
        public double amounttotal, temp, ratefinal;

        public double sum = 0, sumrate = 0, sumweight = 0, sumbag = 0;
        public samamaBill()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 11;
            dataGridView1.Columns[6].Name = "ریٹ فی بیگ";
            dataGridView1.Columns[5].Name = "وزن فی بیگ";
            dataGridView1.Columns[10].Name = "تاریخ";
            dataGridView1.Columns[8].Name = "گاڑی";
            dataGridView1.Columns[9].Name = "آئٹم";
            dataGridView1.Columns[7].Name = "بیگ";
            dataGridView1.Columns[4].Name = "وزن";
            dataGridView1.Columns[3].Name = "ریٹ";
            dataGridView1.Columns[2].Name = "مزدوری";
            dataGridView1.Columns[1].Name = "کرایہ";
            dataGridView1.Columns[0].Name = "رقم";
        }
        private void addData2(string br, string bill, string date, string vehicle, string itemname, string bag, string weight, string rate, string add, string less, string amount)
        {
            String[] row = { amount, less, add, bag, rate, weight, itemname, vehicle, date, bill };
            dataGridView1.Rows.Add(row);
        }
        private void addData1(string bill, string date, string vehicle, string itemname, double bag, double weight, string rate, string add, string less, string amount)
        {
            String r1, w1, a1, b1;
            r1 = Convert.ToString(rate);
            w1 = Convert.ToString(weight);
            b1 = Convert.ToString(bag);
            String[] row = { totalamount.Text, less, add, rate, w1, itemname, vehicle, b1, date, bill };
            dataGridView1.Rows.Add(row);
        }

        private void addData(double bagrate, double bagweight, string date, string vehicle, string itemname, double bag, double weight, double add, double less, string amount)
        {
            ratefinal = bagrate / bagweight;
            temp = (ratefinal * weight) + add - less;
            String r1, w1, a1, b1, l1, ad1;
            r1 = Convert.ToString(ratefinal);
            w1 = Convert.ToString(weight);
            a1 = Convert.ToString(temp);
            b1 = Convert.ToString(bag);
            l1 = Convert.ToString(less);
            ad1 = Convert.ToString(add);
            String[] row = { a1, l1, ad1, r1, w1, Convert.ToString(bagweight), Convert.ToString(bagrate), b1, vehicle, itemname, date };

            dataGridView1.Rows.Add(row);

            sum += temp;
            sumbag += bag;
            sumrate += ratefinal;
            sumweight += weight;
            for (int x = 0; x < dataGridView1.Rows.Count; x++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[x].Cells["رقم"].Value);
                sumrate += Convert.ToDouble(dataGridView1.Rows[x].Cells["وزن"].Value);
                sumweight += Convert.ToDouble(dataGridView1.Rows[x].Cells["کرایہ"].Value);
                sumbag += Convert.ToDouble(dataGridView1.Rows[x].Cells["بیگ"].Value);
            }
            totalamount.Text = Convert.ToString(sum);
            totalrate.Text = Convert.ToString(sumrate);
            totalweight.Text = Convert.ToString(sumweight);
            totalbags.Text = Convert.ToString(sumbag);

        }

        private void samamaBill_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (materialSingleLineTextField14.Text != "" && materialSingleLineTextField9.Text != "" && materialSingleLineTextField8.Text != "" && materialSingleLineTextField7.Text != "" && materialSingleLineTextField6.Text != "" && materialSingleLineTextField5.Text != "" && materialSingleLineTextField4.Text != "" && materialSingleLineTextField2.Text != "" && materialSingleLineTextField1.Text != "")
            {
                addData(double.Parse(materialSingleLineTextField14.Text), double.Parse(materialSingleLineTextField9.Text), materialSingleLineTextField8.Text, materialSingleLineTextField7.Text, materialSingleLineTextField6.Text, double.Parse(materialSingleLineTextField5.Text), double.Parse(materialSingleLineTextField4.Text), double.Parse(materialSingleLineTextField2.Text), double.Parse(materialSingleLineTextField1.Text), "2000");
            }
            else
                MessageBox.Show("Fill all Feild");
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                if (!row.IsNewRow) dataGridView1.Rows.Remove(row);
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {



        }

        private void materialRaisedButton3_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Columns["بل"].DisplayIndex = 0;
            dataGridView1.Columns["تاریخ"].DisplayIndex = 1;
            dataGridView1.Columns[0].Name = "بل";
            dataGridView1.Columns[1].Name = "تاریخ";
            dataGridView1.Columns[2].Name = "گاڑی";
            dataGridView1.Columns[3].Name = "آئٹم کا نام";
            dataGridView1.Columns[4].Name = "بیگ";
            dataGridView1.Columns[5].Name = "وزن";
            dataGridView1.Columns[6].Name = "شرح";
            dataGridView1.Columns[7].Name = "شامل کریں";
            dataGridView1.Columns[8].Name = "کم";
            dataGridView1.Columns[9].Name = "رقم";
            addData2("", "", "", "", "", "", "", "", "", "", "");
            addData1("کل مقدار", "", "", "", double.Parse(totalbags.Text), double.Parse(totalweight.Text), "", "", "", totalamount.Text);
            CLsPrint _ClsPrint = new CLsPrint(dataGridView1, "Company", materialSingleLineTextField10.Text, materialSingleLineTextField11.Text, materialSingleLineTextField12.Text, materialSingleLineTextField13.Text);
            _ClsPrint.PrintForm();

            dataGridView1.Columns[9].Name = "بل";
            dataGridView1.Columns[8].Name = "تاریخ";
            dataGridView1.Columns[7].Name = "گاڑی";
            dataGridView1.Columns[6].Name = "آئٹم کا نام";
            dataGridView1.Columns[5].Name = "بیگ";
            dataGridView1.Columns[4].Name = "وزن";
            dataGridView1.Columns[3].Name = "شرح";
            dataGridView1.Columns[2].Name = "شامل کریں";
            dataGridView1.Columns[1].Name = "کم";
            dataGridView1.Columns[0].Name = "رقم";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void totalrate_Click(object sender, EventArgs e)
        {

        }

        private void totalweight_Click(object sender, EventArgs e)
        {

        }

        private void totalbags_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel13_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel12_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel11_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel10_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel9_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField4_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField6_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField7_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField8_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField9_Click(object sender, EventArgs e)
        {

        }

        private void totalamount_Click(object sender, EventArgs e)
        {

        }
    }
}
