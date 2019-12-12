using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhepHinh
{
    public partial class FrmWinnerList : Form
    {
        public FrmWinnerList()
        {
            InitializeComponent();
            LoadListView();
        }

        private void LoadListView()
        {
            foreach (Winner winner in Record.ReadRecordList())
            {
                ListViewItem lvItem = new ListViewItem(winner.WinnerName);
                lvItem.SubItems.Add(winner.WinnerTime);
                lvItem.SubItems.Add(winner.WinnerStep);
                lvWinnerList.Items.Add(lvItem);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
