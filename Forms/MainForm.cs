using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using eAnbar.Library;

namespace eAnbar
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

            Methods.Import.Show();
            Methods.Import.BringToFront();
        }

        private void btnLists_Click(object sender, EventArgs e)
        {
            Methods.ItemsList.Show();
            Methods.ItemsList.BringToFront();
        }
    }
}
