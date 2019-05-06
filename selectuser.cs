using System;
using System.Collections.Generic;
using MaterialSkin.Controls;
using MaterialSkin;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grandee_project
{
    public partial class selectuser : MaterialForm
    {
        public selectuser()
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

        private void selectuser_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Form3 k = new Form3();
            k.Show();
            this.Hide();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            manageusers l = new manageusers();
            l.Show();
            this.Hide();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            vendormanage o = new vendormanage();
                o.Show();
            this.Hide();
        }
    }
}
