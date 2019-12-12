using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GhepHinh.Properties;

namespace GhepHinh
{
    public partial class FrmSetting : Form
    {
        public FrmSetting()
        {
            InitializeComponent();
            tbColumn.Text = Settings.Default.SoHangCot.ToString();
            tbRow.Text = Settings.Default.SoHangCot.ToString();
        }

        private void tbRow_TextChanged(object sender, EventArgs e)
        {
            tbColumn.Text = tbRow.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbRow.Text) < 2)
            {
                MessageBox.Show("Lỗi !", "Lỗi");
            }
            else
            {
                Settings.Default.SoHangCot = Convert.ToInt32(tbRow.Text);
                Settings.Default.Save();
                this.Close();
            }
        }

        private void tbColumn_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
