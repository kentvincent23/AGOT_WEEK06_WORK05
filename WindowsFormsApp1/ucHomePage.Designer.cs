namespace WindowsFormsApp1
{
    partial class ucHomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ucTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ucTitle
            // 
            this.lbl_ucTitle.BackColor = System.Drawing.Color.Silver;
            this.lbl_ucTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_ucTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ucTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ucTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_ucTitle.Location = new System.Drawing.Point(0, 0);
            this.lbl_ucTitle.Name = "lbl_ucTitle";
            this.lbl_ucTitle.Size = new System.Drawing.Size(808, 45);
            this.lbl_ucTitle.TabIndex = 0;
            this.lbl_ucTitle.Text = "Home";
            this.lbl_ucTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_ucTitle);
            this.Name = "ucHomePage";
            this.Size = new System.Drawing.Size(808, 485);
            this.Load += new System.EventHandler(this.ucHomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_ucTitle;
    }
}
