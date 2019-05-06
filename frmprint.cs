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
    public partial class frmprint : Form
    {
        List<salesrep> _list;
        string date;
        int _b;
        public frmprint(int b,List<salesrep> list, string dateFrom, string dateTo)
        {
            InitializeComponent();
            _list = list;
            date = dateFrom + " --- " + dateTo;
            _b = b;
        }

        private void frmprint_Load(object sender, EventArgs e)
        {
            crystalReport11.SetDataSource(_list);
            crystalReport11.SetParameterValue("pdate", date);
            crystalReport11.SetParameterValue("previousbalance", _b);
            crystalReportViewer1.ReportSource = crystalReport11;
            crystalReportViewer1.Refresh();
        }
    }
}
