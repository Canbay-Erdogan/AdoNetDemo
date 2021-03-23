namespace AdoNetDemo
{
    partial class Form1
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.tbxNameUp = new System.Windows.Forms.TextBox();
            this.tbxStockUp = new System.Windows.Forms.TextBox();
            this.lblNameUp = new System.Windows.Forms.Label();
            this.lblStockUp = new System.Windows.Forms.Label();
            this.lblPriceUp = new System.Windows.Forms.Label();
            this.tbxPriceUp = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 67);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(453, 163);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(85, 53);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(26, 60);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Unit Price";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(85, 89);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 6;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(12, 92);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(74, 13);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Stock Amount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblStock);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Location = new System.Drawing.Point(12, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 151);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AddAProduct";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(110, 115);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.tbxId);
            this.gbxUpdate.Controls.Add(this.btnUp);
            this.gbxUpdate.Controls.Add(this.tbxNameUp);
            this.gbxUpdate.Controls.Add(this.tbxStockUp);
            this.gbxUpdate.Controls.Add(this.lblNameUp);
            this.gbxUpdate.Controls.Add(this.lblStockUp);
            this.gbxUpdate.Controls.Add(this.lblPriceUp);
            this.gbxUpdate.Controls.Add(this.tbxPriceUp);
            this.gbxUpdate.Location = new System.Drawing.Point(304, 236);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(260, 151);
            this.gbxUpdate.TabIndex = 8;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update A Product";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(191, 16);
            this.tbxId.Name = "tbxId";
            this.tbxId.ReadOnly = true;
            this.tbxId.Size = new System.Drawing.Size(63, 20);
            this.tbxId.TabIndex = 8;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(110, 115);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 7;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // tbxNameUp
            // 
            this.tbxNameUp.Location = new System.Drawing.Point(85, 16);
            this.tbxNameUp.Name = "tbxNameUp";
            this.tbxNameUp.Size = new System.Drawing.Size(100, 20);
            this.tbxNameUp.TabIndex = 2;
            // 
            // tbxStockUp
            // 
            this.tbxStockUp.Location = new System.Drawing.Point(85, 89);
            this.tbxStockUp.Name = "tbxStockUp";
            this.tbxStockUp.Size = new System.Drawing.Size(100, 20);
            this.tbxStockUp.TabIndex = 6;
            // 
            // lblNameUp
            // 
            this.lblNameUp.AutoSize = true;
            this.lblNameUp.Location = new System.Drawing.Point(43, 24);
            this.lblNameUp.Name = "lblNameUp";
            this.lblNameUp.Size = new System.Drawing.Size(35, 13);
            this.lblNameUp.TabIndex = 1;
            this.lblNameUp.Text = "Name";
            // 
            // lblStockUp
            // 
            this.lblStockUp.AutoSize = true;
            this.lblStockUp.Location = new System.Drawing.Point(12, 92);
            this.lblStockUp.Name = "lblStockUp";
            this.lblStockUp.Size = new System.Drawing.Size(74, 13);
            this.lblStockUp.TabIndex = 5;
            this.lblStockUp.Text = "Stock Amount";
            // 
            // lblPriceUp
            // 
            this.lblPriceUp.AutoSize = true;
            this.lblPriceUp.Location = new System.Drawing.Point(26, 60);
            this.lblPriceUp.Name = "lblPriceUp";
            this.lblPriceUp.Size = new System.Drawing.Size(53, 13);
            this.lblPriceUp.TabIndex = 3;
            this.lblPriceUp.Text = "Unit Price";
            // 
            // tbxPriceUp
            // 
            this.tbxPriceUp.Location = new System.Drawing.Point(85, 53);
            this.tbxPriceUp.Name = "tbxPriceUp";
            this.tbxPriceUp.Size = new System.Drawing.Size(100, 20);
            this.tbxPriceUp.TabIndex = 4;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(389, 34);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 443);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.TextBox tbxNameUp;
        private System.Windows.Forms.TextBox tbxStockUp;
        private System.Windows.Forms.Label lblNameUp;
        private System.Windows.Forms.Label lblStockUp;
        private System.Windows.Forms.Label lblPriceUp;
        private System.Windows.Forms.TextBox tbxPriceUp;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Button btnRemove;
    }
}

