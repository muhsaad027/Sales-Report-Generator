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
    public partial class frmprint2 : Form
    {
        List<Purchaserep> _list;
        string date;
        public frmprint2(List<Purchaserep> list1, string dateFrom, string dateTo)
        {
            InitializeComponent();
            _list = list1;
            date = dateFrom + " --- " + dateTo;
        }

        private void frmprint2_Load(object sender, EventArgs e)
        {

            crystalReport21.SetDataSource(_list);
            crystalReport21.SetParameterValue("pdate", date);
            crystalReportViewer1.ReportSource = crystalReport21;
            crystalReportViewer1.Refresh();
           
        

            
            
        }
    }
}
