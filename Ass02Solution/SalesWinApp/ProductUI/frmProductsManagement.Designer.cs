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
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.grFilter = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lbTo = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lbFrom = new System.Windows.Forms.Label();
            this.rdUnitsInStock = new System.Windows.Forms.RadioButton();
            this.rdUnitPrice = new System.Windows.Forms.RadioButton();
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
            this.grFilter.SuspendLayout();
            this.grSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Enabled = false;
            this.txtUnitsInStock.Location = new System.Drawing.Point(466, 107);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(185, 23);
            this.txtUnitsInStock.TabIndex = 49;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(466, 66);
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
            // grFilter
            // 
            this.grFilter.Controls.Add(this.btnFilter);
            this.grFilter.Controls.Add(this.txtTo);
            this.grFilter.Controls.Add(this.lbTo);
            this.grFilter.Controls.Add(this.txtFrom);
            this.grFilter.Controls.Add(this.lbFrom);
            this.grFilter.Controls.Add(this.rdUnitsInStock);
            this.grFilter.Controls.Add(this.rdUnitPrice);
            this.grFilter.Enabled = false;
            this.grFilter.Location = new System.Drawing.Point(314, 203);
            this.grFilter.Name = "grFilter";
            this.grFilter.Size = new System.Drawing.Size(336, 89);
            this.grFilter.TabIndex = 60;
            this.grFilter.TabStop = false;
            this.grFilter.Text = "Filter";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(238, 53);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(80, 23);
            this.btnFilter.TabIndex = 18;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(218, 19);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(101, 23);
            this.txtTo.TabIndex = 15;
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(193, 23);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(19, 15);
            this.lbTo.TabIndex = 4;
            this.lbTo.Text = "To";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(55, 19);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(101, 23);
            this.txtFrom.TabIndex = 14;
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(14, 22);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(35, 15);
            this.lbFrom.TabIndex = 2;
            this.lbFrom.Text = "From";
            // 
            // rdUnitsInStock
            // 
            this.rdUnitsInStock.AutoSize = true;
            this.rdUnitsInStock.Location = new System.Drawing.Point(115, 55);
            this.rdUnitsInStock.Name = "rdUnitsInStock";
            this.rdUnitsInStock.Size = new System.Drawing.Size(97, 19);
            this.rdUnitsInStock.TabIndex = 17;
            this.rdUnitsInStock.Text = "Units In Stock";
            this.rdUnitsInStock.UseVisualStyleBackColor = true;
            // 
            // rdUnitPrice
            // 
            this.rdUnitPrice.AutoSize = true;
            this.rdUnitPrice.Checked = true;
            this.rdUnitPrice.Location = new System.Drawing.Point(14, 55);
            this.rdUnitPrice.Name = "rdUnitPrice";
            this.rdUnitPrice.Size = new System.Drawing.Size(76, 19);
            this.rdUnitPrice.TabIndex = 16;
            this.rdUnitPrice.TabStop = true;
            this.rdUnitPrice.Text = "Unit Price";
            this.rdUnitPrice.UseVisualStyleBackColor = true;
            // 
            // grSearch
            // 
            this.grSearch.Controls.Add(this.radioByName);
            this.grSearch.Controls.Add(this.radioByID);
            this.grSearch.Controls.Add(this.txtSearchValue);
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Controls.Add(this.lbSearch);
            this.grSearch.Enabled = false;
            this.grSearch.Location = new System.Drawing.Point(20, 203);
            this.grSearch.Name = "grSearch";
            this.grSearch.Size = new System.Drawing.Size(288, 89);
            this.grSearch.TabIndex = 59;
            this.grSearch.TabStop = false;
            this.grSearch.Text = "Search";
            // 
            // radioByName
            // 
            this.radioByName.AutoSize = true;
            this.radioByName.Checked = true;
            this.radioByName.Location = new System.Drawing.Point(216, 53);
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
            this.radioByID.Location = new System.Drawing.Point(216, 23);
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
            this.txtSearchValue.Size = new System.Drawing.Size(117, 23);
            this.txtSearchValue.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(77, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            this.btnDelete.Location = new System.Drawing.Point(454, 162);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 23);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(266, 162);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(109, 23);
            this.btnNew.TabIndex = 51;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(69, 162);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(109, 23);
            this.btnLoad.TabIndex = 50;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbUnitsInStock
            // 
            this.lbUnitsInStock.AutoSize = true;
            this.lbUnitsInStock.Location = new System.Drawing.Point(372, 110);
            this.lbUnitsInStock.Name = "lbUnitsInStock";
            this.lbUnitsInStock.Size = new System.Drawing.Size(79, 15);
            this.lbUnitsInStock.TabIndex = 58;
            this.lbUnitsInStock.Text = "Units In Stock";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(372, 69);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(58, 15);
            this.lbUnitPrice.TabIndex = 57;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(372, 28);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(45, 15);
            this.lbWeight.TabIndex = 56;
            this.lbWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Enabled = false;
            this.txtWeight.Location = new System.Drawing.Point(466, 25);
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
            this.dgvProductList.Location = new System.Drawing.Point(18, 302);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.RowTemplate.Height = 25;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(631, 257);
            this.dgvProductList.TabIndex = 61;
            this.dgvProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellDoubleClick);
            // 
            // frmProductsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 421);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.grFilter);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProductsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Management";
            this.Load += new System.EventHandler(this.frmProductsManagement_Load);
            this.grFilter.ResumeLayout(false);
            this.grFilter.PerformLayout();
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUnitsInStock;
        private TextBox txtUnitPrice;
        private TextBox txtCategory;
        private GroupBox grFilter;
        private Button btnFilter;
        private TextBox txtTo;
        private Label lbTo;
        private TextBox txtFrom;
        private Label lbFrom;
        private RadioButton rdUnitsInStock;
        private RadioButton rdUnitPrice;
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
    }
}