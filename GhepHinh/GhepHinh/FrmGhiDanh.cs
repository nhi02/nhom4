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
    public partial class FrmGhiDanh : Form
    {
        public FrmGhiDanh(string time, string step)
        {
            InitializeComponent();
            lbTime.Text = time;
            lbStep.Text = step;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Winner winner = new GhepHinh.Winner();
            winner.WinnerName = tbName.Text;
            winner.WinnerTime = lbTime.Text;
            winner.WinnerStep = lbStep.Text;
            Record.WriteRecord(winner.ToString());
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        	this.Close();
        }
    }
}
