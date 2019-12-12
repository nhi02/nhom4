/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 01/12/2019
 * Time: 12:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GhepHinh
{
	partial class Win
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Win));
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbTime = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbStep = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label1.Location = new System.Drawing.Point(21, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(189, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bạn đã chiến thắng!!!";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Purple;
			this.label3.Location = new System.Drawing.Point(12, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Thời Gian:";
			// 
			// lbTime
			// 
			this.lbTime.AutoSize = true;
			this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTime.ForeColor = System.Drawing.Color.Purple;
			this.lbTime.Location = new System.Drawing.Point(84, 63);
			this.lbTime.Name = "lbTime";
			this.lbTime.Size = new System.Drawing.Size(57, 13);
			this.lbTime.TabIndex = 6;
			this.lbTime.Text = "00:00:00";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Purple;
			this.label4.Location = new System.Drawing.Point(19, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Số Bước:";
			// 
			// lbStep
			// 
			this.lbStep.AutoSize = true;
			this.lbStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbStep.ForeColor = System.Drawing.Color.Purple;
			this.lbStep.Location = new System.Drawing.Point(95, 88);
			this.lbStep.Name = "lbStep";
			this.lbStep.Size = new System.Drawing.Size(14, 13);
			this.lbStep.TabIndex = 8;
			this.lbStep.Text = "0";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(84, 113);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(57, 23);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
			// 
			// Win
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(230, 148);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lbStep);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lbTime);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Win";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Win";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label lbStep;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbTime;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
	}
}
