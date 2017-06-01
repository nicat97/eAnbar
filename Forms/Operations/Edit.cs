using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;
using eAnbar.Library;

namespace eAnbar.Forms.Operations
{
    public partial class Edit : Form
    {

        private Database db = new Database();
        private Methods M = new Methods();

        private int id;
        private string table;

        public Edit()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Export_FormClosing);

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

        private void Export_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void init(string tableName, int item_id)
        {
            id = item_id;
            table = tableName;

            SQLiteDataReader row = db.GetItem(table, item_id);

            txtItemName.Text     = row["item_name"].ToString();
            txtItemCount.Text    = row["item_count"].ToString();
            cmbItemUnit.Text     = row["item_unit"].ToString();
            txtItemCost.Text     = row["item_cost"].ToString();
            cmbItemCostCurrency
            .Text                = row["item_cost_currency"].ToString();
            txtItemPrice.Text    = row["item_price"].ToString();
            cmbItemPriceCurrency
            .Text                = row["item_price_currency"].ToString();
            dtpArrivalDate.Text  = row["item_date"].ToString();
            richItemComment.Text = row["item_comment"].ToString();
        }

        private void AllowOnlyDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            M.AllowOnlyDigits(sender, e);
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            string NameText = txtItemName.Text;

            if (!String.IsNullOrWhiteSpace(NameText)) //boş deyilsə
            {
                btnModify.Enabled = true;
            }
            else
            {
                btnModify.Enabled = false;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            bool status;
            Object[] Values = new object[10];

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
            Values[9] = id;

            status = db.ModifyItem(Values, table);

            if (status)
            {
                MessageBox.Show("Məhsula düzəliş edildi. Dəyişikliyi görmək üçün siyahını yeniləyin.",
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
    }
}
