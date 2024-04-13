namespace ADO_attached_mode
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpenDB = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCloseBD = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNomenclature = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemProviders = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemReports = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMaxNum = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMinNum = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMinCost = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMaxCost = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOldest = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNumByCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCostByCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNumByProviders = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCostByProviders = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_providers = new System.Windows.Forms.ComboBox();
            this.comboBox_categories = new System.Windows.Forms.ComboBox();
            this.label_provider = new System.Windows.Forms.Label();
            this.label_categories = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.goodsToolStripMenuItem,
            this.ToolStripMenuItemReports});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOpenDB,
            this.ToolStripMenuItemCloseBD});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // ToolStripMenuItemOpenDB
            // 
            this.ToolStripMenuItemOpenDB.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.ToolStripMenuItemOpenDB.Name = "ToolStripMenuItemOpenDB";
            this.ToolStripMenuItemOpenDB.Size = new System.Drawing.Size(233, 22);
            this.ToolStripMenuItemOpenDB.Text = "Підключитися до БД \"Склад\"";
            this.ToolStripMenuItemOpenDB.Click += new System.EventHandler(this.ToolStripMenuItemOpenDB_Click);
            // 
            // ToolStripMenuItemCloseBD
            // 
            this.ToolStripMenuItemCloseBD.Name = "ToolStripMenuItemCloseBD";
            this.ToolStripMenuItemCloseBD.Size = new System.Drawing.Size(233, 22);
            this.ToolStripMenuItemCloseBD.Text = "Закрити БД \"Склад\"";
            this.ToolStripMenuItemCloseBD.Click += new System.EventHandler(this.ToolStripMenuItemCloseBD_Click);
            // 
            // goodsToolStripMenuItem
            // 
            this.goodsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNomenclature,
            this.ToolStripMenuItemCategories,
            this.ToolStripMenuItemProviders,
            this.ToolStripMenuItemAll});
            this.goodsToolStripMenuItem.Name = "goodsToolStripMenuItem";
            this.goodsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.goodsToolStripMenuItem.Text = "Товари";
            // 
            // ToolStripMenuItemNomenclature
            // 
            this.ToolStripMenuItemNomenclature.Name = "ToolStripMenuItemNomenclature";
            this.ToolStripMenuItemNomenclature.Size = new System.Drawing.Size(198, 22);
            this.ToolStripMenuItemNomenclature.Text = "Номенклатура товарів";
            this.ToolStripMenuItemNomenclature.Click += new System.EventHandler(this.ToolStripMenuItemNomenclature_Click);
            // 
            // ToolStripMenuItemCategories
            // 
            this.ToolStripMenuItemCategories.Name = "ToolStripMenuItemCategories";
            this.ToolStripMenuItemCategories.Size = new System.Drawing.Size(198, 22);
            this.ToolStripMenuItemCategories.Text = "Категорії товарів";
            this.ToolStripMenuItemCategories.Click += new System.EventHandler(this.ToolStripMenuItemCategories_Click);
            // 
            // ToolStripMenuItemProviders
            // 
            this.ToolStripMenuItemProviders.Name = "ToolStripMenuItemProviders";
            this.ToolStripMenuItemProviders.Size = new System.Drawing.Size(198, 22);
            this.ToolStripMenuItemProviders.Text = "Постачальники";
            this.ToolStripMenuItemProviders.Click += new System.EventHandler(this.ToolStripMenuItemProviders_Click);
            // 
            // ToolStripMenuItemAll
            // 
            this.ToolStripMenuItemAll.Name = "ToolStripMenuItemAll";
            this.ToolStripMenuItemAll.Size = new System.Drawing.Size(198, 22);
            this.ToolStripMenuItemAll.Text = "Всі товари на складі";
            this.ToolStripMenuItemAll.Click += new System.EventHandler(this.ToolStripMenuItemAll_Click);
            // 
            // ToolStripMenuItemReports
            // 
            this.ToolStripMenuItemReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemMaxNum,
            this.ToolStripMenuItemMinNum,
            this.ToolStripMenuItemMinCost,
            this.ToolStripMenuItemMaxCost,
            this.ToolStripMenuItemOldest,
            this.ToolStripMenuItemNumByCategories,
            this.ToolStripMenuItemCostByCategories,
            this.ToolStripMenuItemNumByProviders,
            this.ToolStripMenuItemCostByProviders});
            this.ToolStripMenuItemReports.Name = "ToolStripMenuItemReports";
            this.ToolStripMenuItemReports.Size = new System.Drawing.Size(47, 20);
            this.ToolStripMenuItemReports.Text = "Звіти";
            // 
            // ToolStripMenuItemMaxNum
            // 
            this.ToolStripMenuItemMaxNum.Name = "ToolStripMenuItemMaxNum";
            this.ToolStripMenuItemMaxNum.Size = new System.Drawing.Size(282, 22);
            this.ToolStripMenuItemMaxNum.Text = "Товар з максимальною кількістю";
            this.ToolStripMenuItemMaxNum.Click += new System.EventHandler(this.ToolStripMenuItemMaxNum_Click);
            // 
            // ToolStripMenuItemMinNum
            // 
            this.ToolStripMenuItemMinNum.Name = "ToolStripMenuItemMinNum";
            this.ToolStripMenuItemMinNum.Size = new System.Drawing.Size(282, 22);
            this.ToolStripMenuItemMinNum.Text = "Товар з мінімальною кількістю";
            this.ToolStripMenuItemMinNum.Click += new System.EventHandler(this.ToolStripMenuItemMinNum_Click);
            // 
            // ToolStripMenuItemMinCost
            // 
            this.ToolStripMenuItemMinCost.Name = "ToolStripMenuItemMinCost";
            this.ToolStripMenuItemMinCost.Size = new System.Drawing.Size(282, 22);
            this.ToolStripMenuItemMinCost.Text = "Товар з мінімальною собівартістю";
            this.ToolStripMenuItemMinCost.Click += new System.EventHandler(this.ToolStripMenuItemMinCost_Click);
            // 
            // ToolStripMenuItemMaxCost
            // 
            this.ToolStripMenuItemMaxCost.Name = "ToolStripMenuItemMaxCost";
            this.ToolStripMenuItemMaxCost.Size = new System.Drawing.Size(282, 22);
            this.ToolStripMenuItemMaxCost.Text = "Товар з максимальною собівартістю";
            this.ToolStripMenuItemMaxCost.Click += new System.EventHandler(this.ToolStripMenuItemMaxCost_Click);
            // 
            // ToolStripMenuItemOldest
            // 
            this.ToolStripMenuItemOldest.Name = "ToolStripMenuItemOldest";
            this.ToolStripMenuItemOldest.Size = new System.Drawing.Size(282, 22);
            this.ToolStripMenuItemOldest.Text = "Товар найдовше на складі";
            this.ToolStripMenuItemOldest.Click += new System.EventHandler(this.ToolStripMenuItemOldest_Click);
            // 
            // ToolStripMenuItemNumByCategories
            // 
            this.ToolStripMenuItemNumByCategories.Name = "ToolStripMenuItemNumByCategories";
            this.ToolStripMenuItemNumByCategories.Size = new System.Drawing.Size(282, 22);
            this.ToolStripMenuItemNumByCategories.Text = "Кількість товарів за категоріями";
            this.ToolStripMenuItemNumByCategories.Click += new System.EventHandler(this.ToolStripMenuItemNumByCategories_Click);
            // 
            // ToolStripMenuItemCostByCategories
            // 
            this.ToolStripMenuItemCostByCategories.Name = "ToolStripMenuItemCostByCategories";
            this.ToolStripMenuItemCostByCategories.Size = new System.Drawing.Size(282, 22);
            this.ToolStripMenuItemCostByCategories.Text = "Вартість товарів за категоріями";
            this.ToolStripMenuItemCostByCategories.Click += new System.EventHandler(this.ToolStripMenuItemCostByCategories_Click);
            // 
            // ToolStripMenuItemNumByProviders
            // 
            this.ToolStripMenuItemNumByProviders.Name = "ToolStripMenuItemNumByProviders";
            this.ToolStripMenuItemNumByProviders.Size = new System.Drawing.Size(282, 22);
            this.ToolStripMenuItemNumByProviders.Text = "Кількість товарів за постачальниками";
            this.ToolStripMenuItemNumByProviders.Click += new System.EventHandler(this.ToolStripMenuItemNumByProviders_Click);
            // 
            // ToolStripMenuItemCostByProviders
            // 
            this.ToolStripMenuItemCostByProviders.Name = "ToolStripMenuItemCostByProviders";
            this.ToolStripMenuItemCostByProviders.Size = new System.Drawing.Size(282, 22);
            this.ToolStripMenuItemCostByProviders.Text = "Вартість товарів за постачальниками";
            this.ToolStripMenuItemCostByProviders.Click += new System.EventHandler(this.ToolStripMenuItemCostByProviders_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_providers);
            this.panel1.Controls.Add(this.comboBox_categories);
            this.panel1.Controls.Add(this.label_provider);
            this.panel1.Controls.Add(this.label_categories);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 38);
            this.panel1.TabIndex = 1;
            // 
            // comboBox_providers
            // 
            this.comboBox_providers.FormattingEnabled = true;
            this.comboBox_providers.Location = new System.Drawing.Point(401, 3);
            this.comboBox_providers.Name = "comboBox_providers";
            this.comboBox_providers.Size = new System.Drawing.Size(280, 21);
            this.comboBox_providers.TabIndex = 3;
            this.comboBox_providers.SelectedIndexChanged += new System.EventHandler(this.comboBox_providers_SelectedIndexChanged);
            // 
            // comboBox_categories
            // 
            this.comboBox_categories.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_categories.FormattingEnabled = true;
            this.comboBox_categories.Location = new System.Drawing.Point(56, 0);
            this.comboBox_categories.Name = "comboBox_categories";
            this.comboBox_categories.Size = new System.Drawing.Size(254, 21);
            this.comboBox_categories.TabIndex = 1;
            this.comboBox_categories.SelectedIndexChanged += new System.EventHandler(this.comboBox_categories_SelectedIndexChanged);
            // 
            // label_provider
            // 
            this.label_provider.AutoSize = true;
            this.label_provider.Location = new System.Drawing.Point(316, 3);
            this.label_provider.Name = "label_provider";
            this.label_provider.Size = new System.Drawing.Size(79, 13);
            this.label_provider.TabIndex = 2;
            this.label_provider.Text = "Постачальник";
            // 
            // label_categories
            // 
            this.label_categories.AutoSize = true;
            this.label_categories.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_categories.Location = new System.Drawing.Point(0, 0);
            this.label_categories.Name = "label_categories";
            this.label_categories.Size = new System.Drawing.Size(56, 13);
            this.label_categories.TabIndex = 0;
            this.label_categories.Text = "Категорія";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 588);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(703, 436);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад товарів";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpenDB;
        private System.Windows.Forms.ToolStripMenuItem goodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNomenclature;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCategories;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemProviders;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemReports;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMaxNum;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMinNum;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMinCost;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMaxCost;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOldest;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAll;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNumByCategories;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCostByCategories;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNumByProviders;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCostByProviders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_providers;
        private System.Windows.Forms.ComboBox comboBox_categories;
        private System.Windows.Forms.Label label_provider;
        private System.Windows.Forms.Label label_categories;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCloseBD;
    }
}

