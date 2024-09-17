namespace InventoryMaintenance
{
    partial class frmInvMaint
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lstItems = new System.Windows.Forms.ListBox();
            btnAddItem = new System.Windows.Forms.Button();
            btnDeleteItem = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 15;
            lstItems.Location = new System.Drawing.Point(12, 12);
            lstItems.Name = "lstItems";
            lstItems.Size = new System.Drawing.Size(360, 199);
            lstItems.TabIndex = 0;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new System.Drawing.Point(378, 12);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new System.Drawing.Size(90, 30);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new System.Drawing.Point(378, 48);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new System.Drawing.Size(90, 30);
            btnDeleteItem.TabIndex = 2;
            btnDeleteItem.Text = "Delete Item";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(378, 81);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(90, 30);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmInvMaint
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(480, 230);
            Controls.Add(btnExit);
            Controls.Add(btnDeleteItem);
            Controls.Add(btnAddItem);
            Controls.Add(lstItems);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInvMaint";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Dharmin Patel's Inventory Maintenance Application";
            Load += frmInvMaint_Load;
            ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnExit;
    }
}
