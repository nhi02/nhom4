/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 01/12/2019
 * Time: 12:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GhepHinh
{
	/// <summary>
	/// Description of Win.
	/// </summary>
	public partial class Win : Form
	{
		public Win(string time, string step)
		{
			InitializeComponent();
			lbTime.Text = time;
            lbStep.Text = step;
	    }
		
		
		void BtnOKClick(object sender, EventArgs e)
		{
			 this.Close();
		}
		
}
}