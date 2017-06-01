namespace eAnbar.Forms.Operations
{
    partial class Edit
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbItemUnit = new System.Windows.Forms.ComboBox();
            this.txtItemCount = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richItemComment = new System.Windows.Forms.RichTextBox();
            this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.cmbItemPriceCurrency = new System.Windows.Forms.ComboBox();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.cmbItemCostCurrency = new System.Windows.Forms.ComboBox();
            this.txtItemCost = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.cmbItemUnit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtItemCount, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(86, 31);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(348, 31);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // cmbItemUnit
            // 
            this.cmbItemUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbItemUnit.FormattingEnabled = true;
            this.cmbItemUnit.Items.AddRange(new object[] {
            "ədəd",
            "ton",
            "kq",
            "metr",
            "m²",
            "m³",
            "litr",
            "barel",
            "Digər..."});
            this.cmbItemUnit.Location = new System.Drawing.Point(246, 5);
            this.cmbItemUnit.Name = "cmbItemUnit";
            this.cmbItemUnit.Size = new System.Drawing.Size(99, 21);
            this.cmbItemUnit.TabIndex = 23;
            // 
            // txtItemCount
            // 
            this.txtItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemCount.Location = new System.Drawing.Point(3, 5);
            this.txtItemCount.Name = "txtItemCount";
            this.txtItemCount.Size = new System.Drawing.Size(237, 20);
            this.txtItemCount.TabIndex = 22;
            this.txtItemCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyDigits_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.richItemComment, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.dtpArrivalDate, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbItemPriceCurrency, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtItemPrice, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbItemCostCurrency, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtItemCost, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtItemName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnModify, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 312);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // richItemComment
            // 
            this.richItemComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richItemComment.Location = new System.Drawing.Point(89, 220);
            this.richItemComment.Name = "richItemComment";
            this.richItemComment.Size = new System.Drawing.Size(342, 56);
            this.richItemComment.TabIndex = 43;
            this.richItemComment.Text = "";
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpArrivalDate.Location = new System.Drawing.Point(89, 191);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(342, 20);
            this.dtpArrivalDate.TabIndex = 42;
            // 
            // cmbItemPriceCurrency
            // 
            this.cmbItemPriceCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbItemPriceCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemPriceCurrency.FormattingEnabled = true;
            this.cmbItemPriceCurrency.Items.AddRange(new object[] {
            "Naməlum",
            "AZN - Azərbaycan manatı",
            "USD - ABŞ dolları",
            "EUR - Avro",
            "TRY - Türk lirəsi",
            "RUB - Rusiya rublu",
            "CZK - Çexiya kronu",
            "IRR - İran rialı",
            "KRW - Cənubi Korea vonu",
            "TMT - Yeni türkmən manatı",
            "GEL - Gürcü larisi",
            "NZD - Yeni Zelandiya dolları",
            "KZT - Qazaxıstan tengəsi",
            "NOK - Norveç kronu",
            "GBP - İngilis funt sterlinqi",
            "BYN - Belarus rublu",
            "EGP - Misir funtu",
            "LBP - Livan funtu",
            "KWD - Küveyt dinarı",
            "UZS - Özbək somu",
            "SEK - İsveç kronu",
            "CNY - Çin yuanı",
            "TWD - Tayvan dolları",
            "CLP - Çili pesosu",
            "IDR - İndoneziya rupiası",
            "INR - Hindistan rupisi",
            "KGS - Qırğız somu",
            "CAD - Kanada dolları",
            "MYR - Malayziya rinqqiti",
            "TJS - Tacik somonisi",
            "MDL - Moldova leyi",
            "ILS - İsrail şekeli",
            "SGD - Sinqapur dolları",
            "SDR - SDR (BVF-nun xüsusi borcalma hüquqları)",
            "JPY - Yapon yeni",
            "PLN - Polşa zlotası",
            "AUD - Avstraliya dolları",
            "SAR - Səudiyyə Ərəbistanı rialı",
            "BRL - Braziliya rialı",
            "ARS - Argentina pesosu",
            "UAH - Ukrayna qrivnası",
            "DKK - Danimarka kronu",
            "MXN - Meksika pesosu",
            "ZAR - Cənubi Afrika randı",
            "CHF - İsveçrə frankı",
            "HKD - Honq Konq dolları",
            "AED - BƏƏ dirhəmi"});
            this.cmbItemPriceCurrency.Location = new System.Drawing.Point(89, 160);
            this.cmbItemPriceCurrency.Name = "cmbItemPriceCurrency";
            this.cmbItemPriceCurrency.Size = new System.Drawing.Size(342, 21);
            this.cmbItemPriceCurrency.TabIndex = 41;
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemPrice.Location = new System.Drawing.Point(89, 129);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(342, 20);
            this.txtItemPrice.TabIndex = 40;
            this.txtItemPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyDigits_KeyPress);
            // 
            // cmbItemCostCurrency
            // 
            this.cmbItemCostCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbItemCostCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemCostCurrency.FormattingEnabled = true;
            this.cmbItemCostCurrency.Items.AddRange(new object[] {
            "Naməlum",
            "AZN - Azərbaycan manatı",
            "USD - ABŞ dolları",
            "EUR - Avro",
            "TRY - Türk lirəsi",
            "RUB - Rusiya rublu",
            "CZK - Çexiya kronu",
            "IRR - İran rialı",
            "KRW - Cənubi Korea vonu",
            "TMT - Yeni türkmən manatı",
            "GEL - Gürcü larisi",
            "NZD - Yeni Zelandiya dolları",
            "KZT - Qazaxıstan tengəsi",
            "NOK - Norveç kronu",
            "GBP - İngilis funt sterlinqi",
            "BYN - Belarus rublu",
            "EGP - Misir funtu",
            "LBP - Livan funtu",
            "KWD - Küveyt dinarı",
            "UZS - Özbək somu",
            "SEK - İsveç kronu",
            "CNY - Çin yuanı",
            "TWD - Tayvan dolları",
            "CLP - Çili pesosu",
            "IDR - İndoneziya rupiası",
            "INR - Hindistan rupisi",
            "KGS - Qırğız somu",
            "CAD - Kanada dolları",
            "MYR - Malayziya rinqqiti",
            "TJS - Tacik somonisi",
            "MDL - Moldova leyi",
            "ILS - İsrail şekeli",
            "SGD - Sinqapur dolları",
            "SDR - SDR (BVF-nun xüsusi borcalma hüquqları)",
            "JPY - Yapon yeni",
            "PLN - Polşa zlotası",
            "AUD - Avstraliya dolları",
            "SAR - Səudiyyə Ərəbistanı rialı",
            "BRL - Braziliya rialı",
            "ARS - Argentina pesosu",
            "UAH - Ukrayna qrivnası",
            "DKK - Danimarka kronu",
            "MXN - Meksika pesosu",
            "ZAR - Cənubi Afrika randı",
            "CHF - İsveçrə frankı",
            "HKD - Honq Konq dolları",
            "AED - BƏƏ dirhəmi"});
            this.cmbItemCostCurrency.Location = new System.Drawing.Point(89, 98);
            this.cmbItemCostCurrency.Name = "cmbItemCostCurrency";
            this.cmbItemCostCurrency.Size = new System.Drawing.Size(342, 21);
            this.cmbItemCostCurrency.TabIndex = 39;
            // 
            // txtItemCost
            // 
            this.txtItemCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemCost.Location = new System.Drawing.Point(89, 67);
            this.txtItemCost.Name = "txtItemCost";
            this.txtItemCost.Size = new System.Drawing.Size(342, 20);
            this.txtItemCost.TabIndex = 38;
            this.txtItemCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyDigits_KeyPress);
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtItemName.Location = new System.Drawing.Point(89, 5);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(342, 20);
            this.txtItemName.TabIndex = 34;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mal adı:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Maya dəyəri:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Miqdarı:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Məzənnə:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Əlavə qeydlər:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gəliş tarixi:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Satış dəyəri:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Məzənnə:";
            // 
            // btnModify
            // 
            this.btnModify.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModify.Enabled = false;
            this.btnModify.Location = new System.Drawing.Point(356, 284);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 44;
            this.btnModify.Text = "Dəyiş";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 312);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mala düzəliş et";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemCount;
        private System.Windows.Forms.ComboBox cmbItemUnit;
        private System.Windows.Forms.TextBox txtItemCost;
        private System.Windows.Forms.ComboBox cmbItemCostCurrency;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.ComboBox cmbItemPriceCurrency;
        private System.Windows.Forms.DateTimePicker dtpArrivalDate;
        private System.Windows.Forms.RichTextBox richItemComment;
        private System.Windows.Forms.Button btnModify;
    }
}