// Dharmin Patel
using System;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        private InvItemList invItems = new InvItemList();

        public frmInvMaint()
        {
            InitializeComponent();
            invItems.Fill();  // Load the inventory items from the XML file
            FillItemListBox();
        }

        // Fill the ListBox with inventory items
        private void FillItemListBox()
        {
            lstItems.Items.Clear();
            foreach (InvItem item in invItems)
            {
                lstItems.Items.Add(item.GetDisplayText());
            }
        }

        // Event handler for adding a new item
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmNewItem newItemForm = new frmNewItem();
            InvItem newItem = newItemForm.GetNewItem();

            if (newItem != null)
            {
                invItems.Add(newItem);
                invItems.Save();  // Save the updated list to the XML file
                FillItemListBox();
            }
        }

        // Event handler for deleting an item
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)  // If an item is selected
            {
                InvItem item = invItems[i];
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {item.Description}?",
                    "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    invItems.Remove(item);
                    invItems.Save();  // Save the updated list to the XML file
                    FillItemListBox();
                }
            }
        }

        // Event handler for exiting the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInvMaint_Load(object sender, EventArgs e)
        {

        }
    }
}
