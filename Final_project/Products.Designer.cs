namespace Final_project
{
    partial class Products
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
            this.DataGrid1 = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prodictCategory = new System.Windows.Forms.TextBox();
            this.prodictPrice = new System.Windows.Forms.TextBox();
            this.CreateProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid1
            // 
            this.DataGrid1.AccessibleName = "datagrid1";
            this.DataGrid1.AllowUserToAddRows = false;
            this.DataGrid1.AllowUserToDeleteRows = false;
            this.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGrid1.Location = new System.Drawing.Point(12, 12);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.ReadOnly = true;
            this.DataGrid1.Size = new System.Drawing.Size(457, 239);
            this.DataGrid1.TabIndex = 3;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(6, 28);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(181, 20);
            this.productName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = ":نام محصول";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateProduct);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.prodictCategory);
            this.groupBox1.Controls.Add(this.prodictPrice);
            this.groupBox1.Controls.Add(this.productName);
            this.groupBox1.Location = new System.Drawing.Point(493, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(295, 144);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافه کردن محصول";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "نام گروه محصول";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = ":قیمت محصول";
            // 
            // prodictCategory
            // 
            this.prodictCategory.Location = new System.Drawing.Point(6, 80);
            this.prodictCategory.Name = "prodictCategory";
            this.prodictCategory.Size = new System.Drawing.Size(181, 20);
            this.prodictCategory.TabIndex = 4;
            // 
            // prodictPrice
            // 
            this.prodictPrice.Location = new System.Drawing.Point(6, 54);
            this.prodictPrice.Name = "prodictPrice";
            this.prodictPrice.Size = new System.Drawing.Size(181, 20);
            this.prodictPrice.TabIndex = 4;
            // 
            // CreateProduct
            // 
            this.CreateProduct.Location = new System.Drawing.Point(6, 115);
            this.CreateProduct.Name = "CreateProduct";
            this.CreateProduct.Size = new System.Drawing.Size(181, 23);
            this.CreateProduct.TabIndex = 7;
            this.CreateProduct.Text = "افزودن";
            this.CreateProduct.UseVisualStyleBackColor = true;
            this.CreateProduct.Click += new System.EventHandler(this.CreateProduct_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataGrid1);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DataGrid1;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prodictCategory;
        private System.Windows.Forms.TextBox prodictPrice;
        private System.Windows.Forms.Button CreateProduct;
    }
}