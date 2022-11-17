namespace SalesWinApp.ProductUI
{
    partial class frmProductDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductDetail));
            this.numUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.numUnitsInStock = new System.Windows.Forms.NumericUpDown();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.lbUnitsInStock = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbProductID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitsInStock)).BeginInit();
            this.SuspendLayout();
            // 
            // numUnitPrice
            // 
            this.numUnitPrice.DecimalPlaces = 2;
            this.numUnitPrice.Location = new System.Drawing.Point(137, 189);
            this.numUnitPrice.Name = "numUnitPrice";
            this.numUnitPrice.Size = new System.Drawing.Size(183, 23);
            this.numUnitPrice.TabIndex = 27;
            // 
            // numUnitsInStock
            // 
            this.numUnitsInStock.Location = new System.Drawing.Point(136, 235);
            this.numUnitsInStock.Name = "numUnitsInStock";
            this.numUnitsInStock.Size = new System.Drawing.Size(184, 23);
            this.numUnitsInStock.TabIndex = 28;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(137, 142);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(183, 23);
            this.txtWeight.TabIndex = 26;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(137, 97);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(183, 23);
            this.cboCategory.TabIndex = 25;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(137, 54);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(183, 23);
            this.txtProductName.TabIndex = 24;
            // 
            // txtProductId
            // 
            this.txtProductId.Enabled = false;
            this.txtProductId.Location = new System.Drawing.Point(137, 14);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(183, 23);
            this.txtProductId.TabIndex = 23;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(187, 297);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAction
            // 
            this.btnAction.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAction.Location = new System.Drawing.Point(36, 297);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(97, 23);
            this.btnAction.TabIndex = 29;
            this.btnAction.Text = "&Add";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // lbUnitsInStock
            // 
            this.lbUnitsInStock.AutoSize = true;
            this.lbUnitsInStock.Location = new System.Drawing.Point(12, 237);
            this.lbUnitsInStock.Name = "lbUnitsInStock";
            this.lbUnitsInStock.Size = new System.Drawing.Size(79, 15);
            this.lbUnitsInStock.TabIndex = 22;
            this.lbUnitsInStock.Text = "Units In Stock";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(12, 191);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(58, 15);
            this.lbUnitPrice.TabIndex = 21;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(12, 145);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(45, 15);
            this.lbWeight.TabIndex = 20;
            this.lbWeight.Text = "Weight";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(12, 100);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(55, 15);
            this.lbCategory.TabIndex = 19;
            this.lbCategory.Text = "Category";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(12, 57);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(84, 15);
            this.lbProductName.TabIndex = 18;
            this.lbProductName.Text = "Product Name";
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(12, 17);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(63, 15);
            this.lbProductID.TabIndex = 17;
            this.lbProductID.Text = "Product ID";
            // 
            // frmProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(332, 334);
            this.Controls.Add(this.numUnitPrice);
            this.Controls.Add(this.numUnitsInStock);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lbUnitsInStock);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbProductID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Details";
            this.Load += new System.EventHandler(this.frmProductDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitsInStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NumericUpDown numUnitPrice;
        private NumericUpDown numUnitsInStock;
        private TextBox txtWeight;
        private ComboBox cboCategory;
        private TextBox txtProductName;
        private TextBox txtProductId;
        private Button btnCancel;
        private Button btnAction;
        private Label lbUnitsInStock;
        private Label lbUnitPrice;
        private Label lbWeight;
        private Label lbCategory;
        private Label lbProductName;
        private Label lbProductID;
    }
}