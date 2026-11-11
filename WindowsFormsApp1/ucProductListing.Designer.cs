namespace WindowsFormsApp1
{
    partial class ucProductListing
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
            this.grpBox_ItemDetails = new System.Windows.Forms.GroupBox();
            this.cmb_unit = new System.Windows.Forms.ComboBox();
            this.txtBox_amount = new System.Windows.Forms.TextBox();
            this.txtBox_description = new System.Windows.Forms.TextBox();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lstBox_items = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_prompt = new System.Windows.Forms.Label();
            this.grpBox_ItemDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_ItemDetails
            // 
            this.grpBox_ItemDetails.Controls.Add(this.cmb_unit);
            this.grpBox_ItemDetails.Controls.Add(this.txtBox_amount);
            this.grpBox_ItemDetails.Controls.Add(this.txtBox_description);
            this.grpBox_ItemDetails.Controls.Add(this.lbl_amount);
            this.grpBox_ItemDetails.Controls.Add(this.lbl_description);
            this.grpBox_ItemDetails.Location = new System.Drawing.Point(35, 31);
            this.grpBox_ItemDetails.Name = "grpBox_ItemDetails";
            this.grpBox_ItemDetails.Size = new System.Drawing.Size(530, 90);
            this.grpBox_ItemDetails.TabIndex = 0;
            this.grpBox_ItemDetails.TabStop = false;
            this.grpBox_ItemDetails.Text = "Item Details";
            // 
            // cmb_unit
            // 
            this.cmb_unit.FormattingEnabled = true;
            this.cmb_unit.Location = new System.Drawing.Point(282, 49);
            this.cmb_unit.Name = "cmb_unit";
            this.cmb_unit.Size = new System.Drawing.Size(107, 21);
            this.cmb_unit.TabIndex = 4;
            this.cmb_unit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtBox_amount
            // 
            this.txtBox_amount.Location = new System.Drawing.Point(110, 49);
            this.txtBox_amount.Name = "txtBox_amount";
            this.txtBox_amount.Size = new System.Drawing.Size(166, 20);
            this.txtBox_amount.TabIndex = 3;
            // 
            // txtBox_description
            // 
            this.txtBox_description.Location = new System.Drawing.Point(110, 17);
            this.txtBox_description.Name = "txtBox_description";
            this.txtBox_description.Size = new System.Drawing.Size(395, 20);
            this.txtBox_description.TabIndex = 2;
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(29, 49);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(43, 13);
            this.lbl_amount.TabIndex = 1;
            this.lbl_amount.Text = "Amount";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(26, 20);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(60, 13);
            this.lbl_description.TabIndex = 0;
            this.lbl_description.Text = "Description";
            // 
            // lstBox_items
            // 
            this.lstBox_items.FormattingEnabled = true;
            this.lstBox_items.Location = new System.Drawing.Point(35, 127);
            this.lstBox_items.Name = "lstBox_items";
            this.lstBox_items.Size = new System.Drawing.Size(625, 238);
            this.lstBox_items.TabIndex = 0;
            this.lstBox_items.SelectedIndexChanged += new System.EventHandler(this.ucProductListing_Load);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(571, 48);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(571, 80);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // lbl_prompt
            // 
            this.lbl_prompt.BackColor = System.Drawing.Color.Brown;
            this.lbl_prompt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_prompt.Location = new System.Drawing.Point(35, 389);
            this.lbl_prompt.Name = "lbl_prompt";
            this.lbl_prompt.Size = new System.Drawing.Size(625, 23);
            this.lbl_prompt.TabIndex = 4;
            this.lbl_prompt.Text = "Prompt";
            this.lbl_prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucProductListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_prompt);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lstBox_items);
            this.Controls.Add(this.grpBox_ItemDetails);
            this.Name = "ucProductListing";
            this.Size = new System.Drawing.Size(704, 451);
            this.Load += new System.EventHandler(this.ucProductListing_Load);
            this.grpBox_ItemDetails.ResumeLayout(false);
            this.grpBox_ItemDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_ItemDetails;
        private System.Windows.Forms.ComboBox cmb_unit;
        private System.Windows.Forms.TextBox txtBox_amount;
        private System.Windows.Forms.TextBox txtBox_description;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.ListBox lstBox_items;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_prompt;
    }
}
