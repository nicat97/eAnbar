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
using System.IO;
using eAnbar.Library;
using Excel = Microsoft.Office.Interop.Excel;


namespace eAnbar.Forms
{
    public partial class ItemsList : Form
    {

        private Database db = new Database();
        private string id;

        public ItemsList()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(ItemsList_FormClosing);

            cmbSort.SelectedIndex = 0;
            FillListView();

            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        }

        private void ItemsList_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private string GetTab()
        {
            string table = null;

            switch (tabCurrentItems.SelectedIndex)
            {
                case 0:
                    table = "in_stock";
                    break;
                case 1:
                    table = "sold";
                    break;
                case 2:
                    table = "returned";
                    break;
            }

            return table;
        }

        private void FillListView()
        {
            ListView[] tabs = new ListView[3] { lstviewInStock, lstviewSold, lstviewReturned };
            String[] tables = new string[3] {"in_stock", "sold", "returned"};
            int i = 0;


            foreach (ListView tab in tabs)
            {
                var row = db.GetItems(tables[i]);
                tab.Items.Clear();

                while (row.Read())
                {
                    ListViewItem item = new ListViewItem(row["item_id"].ToString());
                    item.SubItems.Add(row["item_name"].ToString());
                    item.SubItems.Add((row["item_count"] + " " + row["item_unit"]).ToString());
                    item.SubItems.Add((row["item_cost"] + " " + row["item_cost_currency"]).ToString());
                    item.SubItems.Add((row["item_price"] + " " + row["item_price_currency"]).ToString());
                    item.SubItems.Add(row["item_date"].ToString());
                    item.SubItems.Add(row["item_comment"].ToString());

                    tab.Items.Add(item);
                }

                i += 1;
            }            
        }

        //TOOLSTRIP START
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void refleshToolStripButton_Click(object sender, EventArgs e)
        {
            FillListView();
        }

        private void moveToolStripButton_Click(object sender, EventArgs e)
        {
            int item_id = Int32.Parse(id);
            string table = GetTab();

            Methods.Move.Show();
            Methods.Move.init(table, item_id);
            Methods.Move.BringToFront();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// switch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void excelToolStripButton_Click(object sender, EventArgs e)
        {
            string tableName = "",
                   tableNameText = "";

            switch (tabCurrentItems.SelectedIndex)
            {
                case 0:
                    tableName = "in_stock";
                    tableNameText = "Cari mallar";
                    break;
                case 1:
                    tableName = "sold";
                    tableNameText = "Satılan mallar";
                    break;
                case 2:
                    tableName = "returned";
                    tableNameText = "Geri qayıdan mallar";
                    break;
            }

            saveFileDialog.Filter = "Excel faylı (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = tableNameText + " - " + DateTime.Now.ToString("dd.MM.yyy");

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.Enabled = false;


                string fileName = @saveFileDialog.FileName;
                Excel.Application oApp;
                Excel.Worksheet oSheet;
                Excel.Workbook oBook;

                oApp = new Excel.Application();
                oBook = oApp.Workbooks.Add();
                oSheet = (Excel.Worksheet)oBook.Worksheets.get_Item(1);
                //BURA DÖVR QOYUB PROGRESSBARDA İŞLƏT
                oSheet.Cells[1, 1] = "some value";
                MessageBox.Show(fileName);
                oBook.SaveAs(fileName);
                oBook.Close();
                oApp.Quit();
            }
        }
        /// <summary>
        /// switch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tableName = "",
                   tableNameText = "";

            switch (tabCurrentItems.SelectedIndex)
            {
                case 0:
                    tableName = "in_stock";
                    tableNameText = "Cari mallar:";
                    break;
                case 1:
                    tableName = "sold";
                    tableNameText = "Satılan mallar:";
                    break;
                case 2:
                    tableName = "returned";
                    tableNameText = "Geri qayıdan mallar:";
                    break;
            }

            try
            {

                saveFileDialog.Filter = "Mətn faylı (*.txt)|*.txt";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = "Cari mallar - " + DateTime.Now.ToString("dd.MM.yyy");

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                }



                db.GetItems(tableName);

                string TitleText = "Bu fayl " + DateTime.Now.ToString() + " tarixində, eAnbar tərəfindən yaradılmışdır.";
                string SecondText = "Ardıcıllıq: Məhsulun nömrəsi, adı, miqdarı, maya dəyəri, qiyməti, gəliş tarixi, əlavə qeydlər.";

                System.IO.File.WriteAllText(@"D:\WriteLines.txt", TitleText + Environment.NewLine + Environment.NewLine);
                System.IO.File.AppendAllText(@"D:\WriteLines.txt", SecondText + Environment.NewLine + Environment.NewLine);
                System.IO.File.AppendAllText(@"D:\WriteLines.txt", tableNameText + Environment.NewLine);
            }
            catch (Exception ex)
            {

            }

        //try catch, remove, həmən fayldan olub olmamasını yoxla
        }
        //TOOLSTRIP END

        private void lstviewInStock_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            moveToolStripButton.Enabled = true;
            editToolStripButton.Enabled = true;
            cutToolStripButton.Enabled = true;
            btnEdit.Enabled = true;
            btnExport.Enabled = true;
            btnDelete.Enabled = true;

            id = e.Item.Text;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Methods.Import.Show();
            Methods.Import.BringToFront();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int item_id = Int32.Parse(id);
            string table = GetTab();

            Methods.Edit.Show();
            Methods.Edit.init(table, item_id);
            Methods.Edit.BringToFront();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int item_id = Int32.Parse(id);
            string table = GetTab();

            SQLiteDataReader row = db.GetItem(table, item_id);

            DialogResult dialogResult = MessageBox.Show("\"" + row["item_name"] + "\" adlı məhsulu silmək istədiyinizdən əminsiniz?",
                                                        "Silinmə əməliyyatı",
                                                        MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (db.DeleteItem(table, item_id))
                {
                    FillListView();
                }
                else
                {
                    MessageBox.Show("Seçdiyiniz məhsul silinə bilmir.",
                                    "Xəta",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                    );
                }

            }
        }
    }
}
