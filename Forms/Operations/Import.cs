using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Data.SQLite;
using eAnbar.Library;

namespace eAnbar.Forms.Operations
{
    public partial class Import : Form
    {
        private Database db = new Database();
        private Methods M = new Methods();

        public Import()
        {

            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Import_FormClosing);

            //setting default index
            cmbItemUnit.SelectedIndex = 0;
            cmbItemCostCurrency.SelectedIndex = 0;
            cmbItemPriceCurrency.SelectedIndex = 0;

            //autocomplete settings start
            AutoCompleteStringCollection ItemCollections = new AutoCompleteStringCollection();
            String[] tbls = new string[3] { "in_stock", "sold", "returned" };

            foreach (string tbl in tbls)
            {
                SQLiteDataReader rows = db.GetItems(tbl);

                while (rows.Read())
                {
                    ItemCollections.Add(rows["item_name"].ToString());
                }
            }

            txtItemName.AutoCompleteCustomSource = ItemCollections;
            //autocomplete settings end
        }

        private void Import_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            string NameText = txtItemName.Text;

            if (!String.IsNullOrWhiteSpace(NameText)) //boş deyilsə
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {

            bool status;
            Object[] Values = new object[9];

            Values[0] = txtItemName.Text;
            Values[1] = !String.IsNullOrEmpty(txtItemCount.Text) ?
                double.Parse(txtItemCount.Text, System.Globalization.CultureInfo.InvariantCulture) : (double?)null;
            Values[2] = cmbItemUnit.Text;
            Values[3] = !String.IsNullOrEmpty(txtItemCost.Text) ?
                double.Parse(txtItemCost.Text, System.Globalization.CultureInfo.InvariantCulture) : (double?)null;
            Values[4] = cmbItemCostCurrency.Text;
            Values[5] = !String.IsNullOrEmpty(txtItemPrice.Text) ?
                double.Parse(txtItemPrice.Text, System.Globalization.CultureInfo.InvariantCulture) : (double?)null;
            Values[6] = cmbItemPriceCurrency.Text;
            Values[7] = dtpArrivalDate.Text;
            Values[8] = richItemComment.Text;

            status = db.AddItems(Values); //returns true or false

            if (status)
            {
                MessageBox.Show("Məhsul bazaya əlavə olundu. Dəyişikliyi görmək üçün siyahını yeniləyin.",
                                "Bildiriş",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                                );

                this.Close();
            }
            else
            {
                MessageBox.Show("Bir xəta meydana gəldi. Məlumatlar bazaya yazıla bilmir.",
                                "Xəta!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );

                this.Close();
            }
        }

        private void AllowOnlyDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            M.AllowOnlyDigits(sender, e);
        }

    }
}
