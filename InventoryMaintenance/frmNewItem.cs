// Dharmin Patel
using System;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmNewItem : Form
    {
        private InvItem invItem;

        public frmNewItem()
        {
            InitializeComponent();
        }

        public InvItem GetNewItem()
        {
            LoadComboBox();
            this.ShowDialog();
            return invItem;
        }

        private void LoadComboBox()
        {
            cboSizeOrManufacturer.Items.Clear();
            if (rdoPlant.Checked)
            {
                cboSizeOrManufacturer.Items.AddRange(new string[] {
                    "1 gallon", "5 gallon", "15 gallon", "24-inch box", "36-inch box"
                });
            }
            else
            {
                cboSizeOrManufacturer.Items.AddRange(new string[] {
                    "Bayer", "Jobe's", "Ortho", "Roundup", "Scotts"
                });
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (rdoPlant.Checked)
                {
                    invItem = new Plant(
                        Convert.ToInt32(txtItemNo.Text),
                        txtDescription.Text,
                        Convert.ToDecimal(txtPrice.Text),
                        cboSizeOrManufacturer.SelectedItem.ToString()
                    );
                }
                else
                {
                    invItem = new Supply(
                        Convert.ToInt32(txtItemNo.Text),
                        txtDescription.Text,
                        Convert.ToDecimal(txtPrice.Text),
                        cboSizeOrManufacturer.SelectedItem.ToString()
                    );
                }

                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtItemNo) &&
                   Validator.IsInt32(txtItemNo) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsPresent(txtPrice) &&
                   Validator.IsDecimal(txtPrice);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoPlant_CheckedChanged(object sender, EventArgs e)
        {
            lblSizeOrManufacturer.Text = rdoPlant.Checked ? "Size:" : "Manufacturer:";
            LoadComboBox();
        }
    }
}
