namespace GhepHinh
{
    partial class Time
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
            this.sophut = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // sophut
            // 
            this.sophut.FormattingEnabled = true;
            this.sophut.Location = new System.Drawing.Point(54, 92);
            this.sophut.Name = "sophut";
            this.sophut.Size = new System.Drawing.Size(140, 21);
            this.sophut.TabIndex = 18;
            // 
            // Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.sophut);
            this.Name = "Time";
            this.Text = "Time";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox sophut;
    }
}