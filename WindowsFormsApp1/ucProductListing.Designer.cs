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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_prompt = new System.Windows.Forms.Label();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menustrip_inv = new System.Windows.Forms.ToolStripMenuItem();
            this.shopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menustrip_about = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_items = new System.Windows.Forms.ListBox();
            this.grpBox_ItemDetails.SuspendLayout();
            this.pnl_content.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_ItemDetails
            // 
            this.grpBox_ItemDetails.AutoSize = true;
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
            this.grpBox_ItemDetails.Enter += new System.EventHandler(this.grpBox_ItemDetails_Enter);
            // 
            // cmb_unit
            // 
            this.cmb_unit.FormattingEnabled = true;
            this.cmb_unit.Location = new System.Drawing.Point(282, 49);
            this.cmb_unit.Name = "cmb_unit";
            this.cmb_unit.Size = new System.Drawing.Size(107, 21);
            this.cmb_unit.TabIndex = 4;
            this.cmb_unit.SelectedIndexChanged += new System.EventHandler(this.lstBox_items_SelectedIndexChanged);
            // 
            // txtBox_amount
            // 
            this.txtBox_amount.Location = new System.Drawing.Point(110, 49);
            this.txtBox_amount.Name = "txtBox_amount";
            this.txtBox_amount.Size = new System.Drawing.Size(166, 20);
            this.txtBox_amount.TabIndex = 3;
            this.txtBox_amount.TextChanged += new System.EventHandler(this.txtBox_amount_TextChanged);
            // 
            // txtBox_description
            // 
            this.txtBox_description.Location = new System.Drawing.Point(110, 17);
            this.txtBox_description.Name = "txtBox_description";
            this.txtBox_description.Size = new System.Drawing.Size(395, 20);
            this.txtBox_description.TabIndex = 2;
            this.txtBox_description.TextChanged += new System.EventHandler(this.txtBox_description_TextChanged);
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
            // btn_add
            // 
            this.btn_add.AutoSize = true;
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
            this.btn_delete.AutoSize = true;
            this.btn_delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(571, 80);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_prompt
            // 
            this.lbl_prompt.BackColor = System.Drawing.Color.Brown;
            this.lbl_prompt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_prompt.Location = new System.Drawing.Point(35, 378);
            this.lbl_prompt.Name = "lbl_prompt";
            this.lbl_prompt.Size = new System.Drawing.Size(625, 23);
            this.lbl_prompt.TabIndex = 4;
            this.lbl_prompt.Text = "Prompt";
            this.lbl_prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_content
            // 
            this.pnl_content.AutoScroll = true;
            this.pnl_content.Controls.Add(this.listBox_items);
            this.pnl_content.Controls.Add(this.lbl_prompt);
            this.pnl_content.Controls.Add(this.btn_logout);
            this.pnl_content.Controls.Add(this.menuStrip1);
            this.pnl_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_content.Location = new System.Drawing.Point(0, 0);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(704, 451);
            this.pnl_content.TabIndex = 5;
            this.pnl_content.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_content_Paint);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(35, 404);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustrip_inv,
            this.menustrip_about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menustrip_inv
            // 
            this.menustrip_inv.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shopToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menustrip_inv.Name = "menustrip_inv";
            this.menustrip_inv.Size = new System.Drawing.Size(69, 20);
            this.menustrip_inv.Text = "Inventory";
            // 
            // shopToolStripMenuItem
            // 
            this.shopToolStripMenuItem.Name = "shopToolStripMenuItem";
            this.shopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shopToolStripMenuItem.Text = "Shop";
            this.shopToolStripMenuItem.Click += new System.EventHandler(this.shopToolStripMenuItem_Click_1);
            // 
            // menustrip_about
            // 
            this.menustrip_about.Name = "menustrip_about";
            this.menustrip_about.Size = new System.Drawing.Size(68, 20);
            this.menustrip_about.Text = "About Us";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // listBox_items
            // 
            this.listBox_items.FormattingEnabled = true;
            this.listBox_items.Location = new System.Drawing.Point(35, 128);
            this.listBox_items.Name = "listBox_items";
            this.listBox_items.Size = new System.Drawing.Size(611, 238);
            this.listBox_items.TabIndex = 5;
            this.listBox_items.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ucProductListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.grpBox_ItemDetails);
            this.Controls.Add(this.pnl_content);
            this.Name = "ucProductListing";
            this.Size = new System.Drawing.Size(704, 451);
            this.Load += new System.EventHandler(this.ucProductListing_Load);
            this.grpBox_ItemDetails.ResumeLayout(false);
            this.grpBox_ItemDetails.PerformLayout();
            this.pnl_content.ResumeLayout(false);
            this.pnl_content.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_ItemDetails;
        private System.Windows.Forms.ComboBox cmb_unit;
        private System.Windows.Forms.TextBox txtBox_amount;
        private System.Windows.Forms.TextBox txtBox_description;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_prompt;
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menustrip_inv;
        private System.Windows.Forms.ToolStripMenuItem shopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menustrip_about;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox_items;
    }
}
