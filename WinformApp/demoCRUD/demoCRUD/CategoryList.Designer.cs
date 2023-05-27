using System.ComponentModel;

namespace demoCRUD
{
    partial class CategoryList
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
            this.dgvCategoryList = new System.Windows.Forms.DataGridView();
            this.lbNameCat = new System.Windows.Forms.Label();
            this.tbCatName = new System.Windows.Forms.TextBox();
            this.btnAddNewCat = new System.Windows.Forms.Button();
            this.btnSaveCat = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbCatId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategoryList
            // 
            this.dgvCategoryList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoryList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCategoryList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoryList.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvCategoryList.Location = new System.Drawing.Point(32, 27);
            this.dgvCategoryList.Name = "dgvCategoryList";
            this.dgvCategoryList.ReadOnly = true;
            this.dgvCategoryList.RowTemplate.Height = 40;
            this.dgvCategoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoryList.Size = new System.Drawing.Size(1053, 318);
            this.dgvCategoryList.TabIndex = 0;
            this.dgvCategoryList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoryList_CellClick);
            // 
            // lbNameCat
            // 
            this.lbNameCat.Location = new System.Drawing.Point(41, 396);
            this.lbNameCat.Name = "lbNameCat";
            this.lbNameCat.Size = new System.Drawing.Size(240, 42);
            this.lbNameCat.TabIndex = 1;
            this.lbNameCat.Text = "Category Name";
            // 
            // tbCatName
            // 
            this.tbCatName.Enabled = false;
            this.tbCatName.Location = new System.Drawing.Point(287, 393);
            this.tbCatName.Name = "tbCatName";
            this.tbCatName.Size = new System.Drawing.Size(243, 38);
            this.tbCatName.TabIndex = 2;
            // 
            // btnAddNewCat
            // 
            this.btnAddNewCat.Location = new System.Drawing.Point(57, 492);
            this.btnAddNewCat.Name = "btnAddNewCat";
            this.btnAddNewCat.Size = new System.Drawing.Size(152, 53);
            this.btnAddNewCat.TabIndex = 3;
            this.btnAddNewCat.Text = "Add new";
            this.btnAddNewCat.UseVisualStyleBackColor = true;
            this.btnAddNewCat.Click += new System.EventHandler(this.btnAddNewCat_Click);
            // 
            // btnSaveCat
            // 
            this.btnSaveCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveCat.Enabled = false;
            this.btnSaveCat.Location = new System.Drawing.Point(256, 492);
            this.btnSaveCat.Name = "btnSaveCat";
            this.btnSaveCat.Size = new System.Drawing.Size(152, 53);
            this.btnSaveCat.TabIndex = 4;
            this.btnSaveCat.Text = "Save";
            this.btnSaveCat.UseVisualStyleBackColor = true;
            this.btnSaveCat.Click += new System.EventHandler(this.btnSaveCat_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(460, 492);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 53);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbCatId
            // 
            this.tbCatId.Location = new System.Drawing.Point(556, 393);
            this.tbCatId.Name = "tbCatId";
            this.tbCatId.Size = new System.Drawing.Size(184, 38);
            this.tbCatId.TabIndex = 6;
            this.tbCatId.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(662, 492);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 53);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReset.Location = new System.Drawing.Point(876, 492);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 53);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // CategoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 747);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbCatId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSaveCat);
            this.Controls.Add(this.btnAddNewCat);
            this.Controls.Add(this.tbCatName);
            this.Controls.Add(this.lbNameCat);
            this.Controls.Add(this.dgvCategoryList);
            this.Name = "CategoryList";
            this.Text = "CategoryList";
            this.Load += new System.EventHandler(this.CategoryList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.TextBox tbCatId;

        private System.Windows.Forms.Button btnUpdate;

        private System.Windows.Forms.Label lbNameCat;
        private System.Windows.Forms.TextBox tbCatName;
        private System.Windows.Forms.Button btnAddNewCat;
        private System.Windows.Forms.Button btnSaveCat;

        private System.Windows.Forms.DataGridView dgvCategoryList;

        #endregion
    }
}