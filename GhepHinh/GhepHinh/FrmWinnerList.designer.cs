namespace GhepHinh
{
    partial class FrmWinnerList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lvWinnerList = new System.Windows.Forms.ListView();
            this.winnerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.winnerTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.winnerStep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Người Chiến Thắng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvWinnerList
            // 
            this.lvWinnerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.winnerName,
            this.winnerTime,
            this.winnerStep});
            this.lvWinnerList.FullRowSelect = true;
            this.lvWinnerList.GridLines = true;
            this.lvWinnerList.Location = new System.Drawing.Point(12, 34);
            this.lvWinnerList.Name = "lvWinnerList";
            this.lvWinnerList.Size = new System.Drawing.Size(279, 219);
            this.lvWinnerList.TabIndex = 1;
            this.lvWinnerList.UseCompatibleStateImageBehavior = false;
            this.lvWinnerList.View = System.Windows.Forms.View.Details;
            // 
            // winnerName
            // 
            this.winnerName.Text = "Tên";
            this.winnerName.Width = 120;
            // 
            // winnerTime
            // 
            this.winnerTime.Text = "Thời Gian";
            this.winnerTime.Width = 100;
            // 
            // winnerStep
            // 
            this.winnerStep.Text = "Số Bước";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(121, 259);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmWinnerList
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(316, 290);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lvWinnerList);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWinnerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FrmWinnerList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvWinnerList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader winnerName;
        private System.Windows.Forms.ColumnHeader winnerTime;
        private System.Windows.Forms.ColumnHeader winnerStep;
    }
}