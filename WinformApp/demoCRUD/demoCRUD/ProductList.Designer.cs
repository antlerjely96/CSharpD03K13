using System.ComponentModel;

namespace demoCRUD
{
    partial class ProductList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProductQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategoryName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.tbProductId = new System.Windows.Forms.TextBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnResetPro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductList
            // 
            this.dgvProductList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.GridColor = System.Drawing.Color.Red;
            this.dgvProductList.Location = new System.Drawing.Point(61, 66);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowTemplate.Height = 40;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(1490, 331);
            this.dgvProductList.TabIndex = 0;
            this.dgvProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(70, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // tbProductName
            // 
            this.tbProductName.Enabled = false;
            this.tbProductName.Location = new System.Drawing.Point(365, 464);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(327, 38);
            this.tbProductName.TabIndex = 2;
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Enabled = false;
            this.tbProductPrice.Location = new System.Drawing.Point(365, 561);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(327, 38);
            this.tbProductPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(70, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product price";
            // 
            // tbProductQuantity
            // 
            this.tbProductQuantity.Enabled = false;
            this.tbProductQuantity.Location = new System.Drawing.Point(1048, 458);
            this.tbProductQuantity.Name = "tbProductQuantity";
            this.tbProductQuantity.Size = new System.Drawing.Size(327, 38);
            this.tbProductQuantity.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(791, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product quantity";
            // 
            // cbCategoryName
            // 
            this.cbCategoryName.Enabled = false;
            this.cbCategoryName.FormattingEnabled = true;
            this.cbCategoryName.Location = new System.Drawing.Point(1050, 553);
            this.cbCategoryName.Name = "cbCategoryName";
            this.cbCategoryName.Size = new System.Drawing.Size(324, 39);
            this.cbCategoryName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(793, 556);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Category name";
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(70, 674);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(217, 70);
            this.btnAddNewProduct.TabIndex = 9;
            this.btnAddNewProduct.Text = "Add new";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Enabled = false;
            this.btnSaveProduct.Location = new System.Drawing.Point(350, 674);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(217, 70);
            this.btnSaveProduct.TabIndex = 10;
            this.btnSaveProduct.Text = "Save";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Enabled = false;
            this.btnUpdateProduct.Location = new System.Drawing.Point(640, 674);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(217, 70);
            this.btnUpdateProduct.TabIndex = 11;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // tbProductId
            // 
            this.tbProductId.Location = new System.Drawing.Point(1413, 458);
            this.tbProductId.Name = "tbProductId";
            this.tbProductId.Size = new System.Drawing.Size(102, 38);
            this.tbProductId.TabIndex = 12;
            this.tbProductId.Visible = false;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Enabled = false;
            this.btnDeleteProduct.Location = new System.Drawing.Point(925, 674);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(217, 70);
            this.btnDeleteProduct.TabIndex = 13;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnResetPro
            // 
            this.btnResetPro.Location = new System.Drawing.Point(1202, 674);
            this.btnResetPro.Name = "btnResetPro";
            this.btnResetPro.Size = new System.Drawing.Size(217, 70);
            this.btnResetPro.TabIndex = 14;
            this.btnResetPro.Text = "Reset";
            this.btnResetPro.UseVisualStyleBackColor = true;
            this.btnResetPro.Click += new System.EventHandler(this.btnResetPro_Click);
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 918);
            this.Controls.Add(this.btnResetPro);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.tbProductId);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.btnAddNewProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCategoryName);
            this.Controls.Add(this.tbProductQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbProductPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductList);
            this.Name = "ProductList";
            this.Text = "ProductList";
            this.Load += new System.EventHandler(this.ProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnResetPro;

        private System.Windows.Forms.Button btnDeleteProduct;

        private System.Windows.Forms.TextBox tbProductId;

        private System.Windows.Forms.Button btnUpdateProduct;

        private System.Windows.Forms.ComboBox cbCategoryName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Button btnSaveProduct;

        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProductQuantity;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProductName;

        private System.Windows.Forms.DataGridView dgvProductList;

        #endregion
    }
}