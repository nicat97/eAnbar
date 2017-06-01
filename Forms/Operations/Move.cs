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
    public partial class Move : Form
    {
        private Database db = new Database();
        private int id;
        private string table;

        public Move()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Move_FormClosing);
            cmbCategory.SelectedIndex = 0;

        }

        private void Move_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void init(string tableName, int item_id)
        {
            id = item_id;
            table = tableName;

            SQLiteDataReader row = db.GetItem(tableName, item_id);
            lblItemName.Text = row["item_name"].ToString();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            string targetTableName = null;

            switch (cmbCategory.SelectedIndex)
            {
                case 0:
                    targetTableName = "in_stock";
                    break;
                case 1:
                    targetTableName = "sold";
                    break;
                case 2:
                    targetTableName = "returned";
                    break;
            }

            object status = db.MoveItem(table, targetTableName, id);

            if (status is bool)
            {
                bool convertedStatus = Convert.ToBoolean(status);

                if (convertedStatus) //əməliyyat uğurlu alındı
                {
                    MessageBox.Show("Məhsulun yeri dəyişdirildi. Dəyişikliyi görmək üçün siyahını yeniləyin.",
                                    "Bildiriş",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                    );

                    this.Close();
                }
                else //uğursuz
                {
                    MessageBox.Show("Bir xəta meydana gəldi. Məlumatlar bazaya yazıla bilmir.",
                                    "Xəta!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                    );

                    this.Close();
                }
            }
            else if (status is string)
            {
                MessageBox.Show("Seçdiyiniz məhsulun yeri dəyişdirildi, amma əvvəlki siyahıdan silinə bilmədi. Zəhmət olmasa, onu özünüz silin.",
                                "Bildiriş!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                                );
            }
            else
            {
                //WTF?!
            }
        }
    }
}
