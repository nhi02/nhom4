/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 01/12/2019
 * Time: 1:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GhepHinh
{
	/// <summary>
	/// Description of Guide.
	/// </summary>
	public partial class Guide : Form
	{
		public Guide()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		
		void BtnGuideClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
