namespace SalesWinApp.ProductUI
{
    partial class frmProductsManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductsManagement));
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.radioByName = new System.Windows.Forms.RadioButton();
            this.radioByID = new System.Windows.Forms.RadioButton();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbUnitsInStock = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lbProductID = new System.Windows.Forms.Label();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Enabled = false;
            this.txtUnitsInStock.Location = new System.Drawing.Point(123, 235);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(185, 23);
            this.txtUnitsInStock.TabIndex = 49;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(123, 194);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(185, 23);
            this.txtUnitPrice.TabIndex = 48;
            // 
            // txtCategory
            // 
            this.txtCategory.Enabled = false;
            this.txtCategory.Location = new System.Drawing.Point(123, 107);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(185, 23);
            this.txtCategory.TabIndex = 46;
            // 
            // grSearch
            // 
            this.grSearch.Controls.Add(this.radioByName);
            this.grSearch.Controls.Add(this.radioByID);
            this.grSearch.Controls.Add(this.txtSearchValue);
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Controls.Add(this.lbSearch);
            this.grSearch.Enabled = false;
            this.grSearch.Location = new System.Drawing.Point(330, 349);
            this.grSearch.Name = "grSearch";
            this.grSearch.Size = new System.Drawing.Size(673, 89);
            this.grSearch.TabIndex = 59;
            this.grSearch.TabStop = false;
            this.grSearch.Text = "Search";
            // 
            // radioByName
            // 
            this.radioByName.AutoSize = true;
            this.radioByName.Checked = true;
            this.radioByName.Location = new System.Drawing.Point(496, 53);
            this.radioByName.Name = "radioByName";
            this.radioByName.Size = new System.Drawing.Size(73, 19);
            this.radioByName.TabIndex = 12;
            this.radioByName.TabStop = true;
            this.radioByName.Text = "By Name";
            this.radioByName.UseVisualStyleBackColor = true;
            // 
            // radioByID
            // 
            this.radioByID.AutoSize = true;
            this.radioByID.Location = new System.Drawing.Point(496, 23);
            this.radioByID.Name = "radioByID";
            this.radioByID.Size = new System.Drawing.Size(52, 19);
            this.radioByID.TabIndex = 11;
            this.radioByID.TabStop = true;
            this.radioByID.Text = "By ID";
            this.radioByID.UseVisualStyleBackColor = true;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(77, 19);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(381, 23);
            this.txtSearchValue.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(158, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(226, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(29, 22);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(42, 15);
            this.lbSearch.TabIndex = 16;
            this.lbSearch.Text = "Search";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(826, 287);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(177, 23);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(586, 287);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(192, 23);
            this.btnNew.TabIndex = 51;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(330, 287);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(194, 23);
            this.btnLoad.TabIndex = 50;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbUnitsInStock
            // 
            this.lbUnitsInStock.AutoSize = true;
            this.lbUnitsInStock.Location = new System.Drawing.Point(29, 238);
            this.lbUnitsInStock.Name = "lbUnitsInStock";
            this.lbUnitsInStock.Size = new System.Drawing.Size(79, 15);
            this.lbUnitsInStock.TabIndex = 58;
            this.lbUnitsInStock.Text = "Units In Stock";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(29, 197);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(58, 15);
            this.lbUnitPrice.TabIndex = 57;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(29, 156);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(45, 15);
            this.lbWeight.TabIndex = 56;
            this.lbWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Enabled = false;
            this.txtWeight.Location = new System.Drawing.Point(123, 153);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(185, 23);
            this.txtWeight.TabIndex = 47;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(20, 110);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(55, 15);
            this.lbCategory.TabIndex = 55;
            this.lbCategory.Text = "Category";
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(123, 66);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(185, 23);
            this.txtProductName.TabIndex = 45;
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Location = new System.Drawing.Point(20, 69);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(84, 15);
            this.lbMemberName.TabIndex = 54;
            this.lbMemberName.Text = "Product Name";
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(123, 25);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(185, 23);
            this.txtProductID.TabIndex = 44;
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(20, 28);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(63, 15);
            this.lbProductID.TabIndex = 53;
            this.lbProductID.Text = "Product ID";
            // 
            // dgvProductList
            // 
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(330, 12);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.RowTemplate.Height = 25;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(673, 257);
            this.dgvProductList.TabIndex = 61;
            this.dgvProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SalesWinApp.Properties.Resources.logo_fpt_shop;
            this.pictureBox1.Location = new System.Drawing.Point(7, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // frmProductsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1025, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbUnitsInStock);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lbProductID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProductsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Management";
            this.Load += new System.EventHandler(this.frmProductsManagement_Load);
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUnitsInStock;
        private TextBox txtUnitPrice;
        private TextBox txtCategory;
        private GroupBox grSearch;
        private RadioButton radioByName;
        private RadioButton radioByID;
        private TextBox txtSearchValue;
        private Button btnSearch;
        private Label lbSearch;
        private Button btnDelete;
        private Button btnNew;
        private Button btnLoad;
        private Label lbUnitsInStock;
        private Label lbUnitPrice;
        private Label lbWeight;
        private TextBox txtWeight;
        private Label lbCategory;
        private TextBox txtProductName;
        private Label lbMemberName;
        private TextBox txtProductID;
        private Label lbProductID;
        private DataGridView dgvProductList;
        private PictureBox pictureBox1;
    }
}