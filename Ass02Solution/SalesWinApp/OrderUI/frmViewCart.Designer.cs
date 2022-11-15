namespace SalesWinApp.OrderUI
{
    partial class frmViewCart
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
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lbOrderTotal = new System.Windows.Forms.Label();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.txtVCTotal = new System.Windows.Forms.TextBox();
            this.txtVCPrice = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbVCPrice = new System.Windows.Forms.Label();
            this.txtVCQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txtVCProductName = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(407, 132);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(108, 23);
            this.btnCheckOut.TabIndex = 23;
            this.btnCheckOut.Text = "&Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // lbOrderTotal
            // 
            this.lbOrderTotal.AutoSize = true;
            this.lbOrderTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOrderTotal.Location = new System.Drawing.Point(13, 136);
            this.lbOrderTotal.Name = "lbOrderTotal";
            this.lbOrderTotal.Size = new System.Drawing.Size(76, 15);
            this.lbOrderTotal.TabIndex = 22;
            this.lbOrderTotal.Text = "Order Total: ";
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(266, 132);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(118, 23);
            this.btnRemoveFromCart.TabIndex = 21;
            this.btnRemoveFromCart.Text = "&Remove From Cart";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            // 
            // txtVCTotal
            // 
            this.txtVCTotal.Enabled = false;
            this.txtVCTotal.Location = new System.Drawing.Point(354, 72);
            this.txtVCTotal.Name = "txtVCTotal";
            this.txtVCTotal.Size = new System.Drawing.Size(161, 23);
            this.txtVCTotal.TabIndex = 20;
            // 
            // txtVCPrice
            // 
            this.txtVCPrice.Enabled = false;
            this.txtVCPrice.Location = new System.Drawing.Point(354, 26);
            this.txtVCPrice.Name = "txtVCPrice";
            this.txtVCPrice.Size = new System.Drawing.Size(161, 23);
            this.txtVCPrice.TabIndex = 19;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(302, 75);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(33, 15);
            this.lbTotal.TabIndex = 18;
            this.lbTotal.Text = "Total";
            // 
            // lbVCPrice
            // 
            this.lbVCPrice.AutoSize = true;
            this.lbVCPrice.Location = new System.Drawing.Point(301, 29);
            this.lbVCPrice.Name = "lbVCPrice";
            this.lbVCPrice.Size = new System.Drawing.Size(33, 15);
            this.lbVCPrice.TabIndex = 17;
            this.lbVCPrice.Text = "Price";
            // 
            // txtVCQuantity
            // 
            this.txtVCQuantity.Enabled = false;
            this.txtVCQuantity.Location = new System.Drawing.Point(106, 72);
            this.txtVCQuantity.Name = "txtVCQuantity";
            this.txtVCQuantity.Size = new System.Drawing.Size(161, 23);
            this.txtVCQuantity.TabIndex = 16;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(13, 75);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(53, 15);
            this.lbQuantity.TabIndex = 15;
            this.lbQuantity.Text = "Quantity";
            // 
            // txtVCProductName
            // 
            this.txtVCProductName.Enabled = false;
            this.txtVCProductName.Location = new System.Drawing.Point(106, 29);
            this.txtVCProductName.Name = "txtVCProductName";
            this.txtVCProductName.Size = new System.Drawing.Size(161, 23);
            this.txtVCProductName.TabIndex = 14;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(13, 32);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(84, 15);
            this.lbProductName.TabIndex = 13;
            this.lbProductName.Text = "Product Name";
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(13, 171);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowTemplate.Height = 25;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(502, 228);
            this.dgvCart.TabIndex = 12;
            // 
            // frmViewCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 424);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.lbOrderTotal);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.txtVCTotal);
            this.Controls.Add(this.txtVCPrice);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbVCPrice);
            this.Controls.Add(this.txtVCQuantity);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.txtVCProductName);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.dgvCart);
            this.Name = "frmViewCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Cart";
            this.Load += new System.EventHandler(this.frmViewCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCheckOut;
        private Label lbOrderTotal;
        private Button btnRemoveFromCart;
        private TextBox txtVCTotal;
        private TextBox txtVCPrice;
        private Label lbTotal;
        private Label lbVCPrice;
        private TextBox txtVCQuantity;
        private Label lbQuantity;
        private TextBox txtVCProductName;
        private Label lbProductName;
        private DataGridView dgvCart;
    }
}