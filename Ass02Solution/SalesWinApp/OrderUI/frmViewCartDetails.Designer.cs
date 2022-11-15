namespace SalesWinApp.OrderUI
{
    partial class frmViewCartDetails
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.numUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(169, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(17, 216);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "&Update Item";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(124, 161);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(158, 23);
            this.txtTotal.TabIndex = 17;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTotal.Location = new System.Drawing.Point(17, 164);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(33, 15);
            this.lbTotal.TabIndex = 16;
            this.lbTotal.Text = "Total";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(124, 112);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(158, 23);
            this.numQuantity.TabIndex = 15;
            // 
            // numUnitPrice
            // 
            this.numUnitPrice.Enabled = false;
            this.numUnitPrice.Location = new System.Drawing.Point(124, 64);
            this.numUnitPrice.Name = "numUnitPrice";
            this.numUnitPrice.Size = new System.Drawing.Size(158, 23);
            this.numUnitPrice.TabIndex = 14;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbUnitPrice.Location = new System.Drawing.Point(17, 66);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(58, 15);
            this.lbUnitPrice.TabIndex = 13;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbQuantity.Location = new System.Drawing.Point(17, 114);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(53, 15);
            this.lbQuantity.TabIndex = 12;
            this.lbQuantity.Text = "Quantity";
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(124, 17);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(158, 23);
            this.txtProductName.TabIndex = 11;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbProductName.Location = new System.Drawing.Point(17, 20);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(84, 15);
            this.lbProductName.TabIndex = 10;
            this.lbProductName.Text = "Product Name";
            // 
            // frmViewCartDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 257);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.numUnitPrice);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lbProductName);
            this.Name = "frmViewCartDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Cart Item";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnUpdate;
        private TextBox txtTotal;
        private Label lbTotal;
        private NumericUpDown numQuantity;
        private NumericUpDown numUnitPrice;
        private Label lbUnitPrice;
        private Label lbQuantity;
        private TextBox txtProductName;
        private Label lbProductName;
    }
}