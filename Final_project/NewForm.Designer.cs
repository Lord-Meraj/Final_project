
namespace Final_project
{
    partial class NewForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modiriat = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتکاربرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتکالاهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Clint = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستکاربرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.افزودنکاربرجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductManagment = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستکالاهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.DataGrid1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modiriat,
            this.Clint,
            this.ProductManagment});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modiriat
            // 
            this.modiriat.AccessibleName = "";
            this.modiriat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریتکاربرانToolStripMenuItem,
            this.مدیریتکالاهاToolStripMenuItem});
            this.modiriat.Name = "modiriat";
            this.modiriat.Size = new System.Drawing.Size(60, 20);
            this.modiriat.Text = "مدیریت ";
            // 
            // مدیریتکاربرانToolStripMenuItem
            // 
            this.مدیریتکاربرانToolStripMenuItem.Name = "مدیریتکاربرانToolStripMenuItem";
            this.مدیریتکاربرانToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.مدیریتکاربرانToolStripMenuItem.Text = "مدیریت کاربران";
            // 
            // مدیریتکالاهاToolStripMenuItem
            // 
            this.مدیریتکالاهاToolStripMenuItem.Name = "مدیریتکالاهاToolStripMenuItem";
            this.مدیریتکالاهاToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.مدیریتکالاهاToolStripMenuItem.Text = "مدیریت کالا ها";
            // 
            // Clint
            // 
            this.Clint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.لیستکاربرانToolStripMenuItem,
            this.افزودنکاربرجدیدToolStripMenuItem});
            this.Clint.Name = "Clint";
            this.Clint.Size = new System.Drawing.Size(52, 20);
            this.Clint.Text = "کاربران";
            // 
            // لیستکاربرانToolStripMenuItem
            // 
            this.لیستکاربرانToolStripMenuItem.Name = "لیستکاربرانToolStripMenuItem";
            this.لیستکاربرانToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.لیستکاربرانToolStripMenuItem.Text = "لیست کاربران";
            // 
            // افزودنکاربرجدیدToolStripMenuItem
            // 
            this.افزودنکاربرجدیدToolStripMenuItem.Name = "افزودنکاربرجدیدToolStripMenuItem";
            this.افزودنکاربرجدیدToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.افزودنکاربرجدیدToolStripMenuItem.Text = "افزودن کاربر جدید";
            // 
            // ProductManagment
            // 
            this.ProductManagment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.لیستکالاهاToolStripMenuItem});
            this.ProductManagment.Name = "ProductManagment";
            this.ProductManagment.Size = new System.Drawing.Size(49, 20);
            this.ProductManagment.Text = "کالا ها";
            // 
            // لیستکالاهاToolStripMenuItem
            // 
            this.لیستکالاهاToolStripMenuItem.Name = "لیستکالاهاToolStripMenuItem";
            this.لیستکالاهاToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.لیستکالاهاToolStripMenuItem.Text = "لیست کالا ها";
            this.لیستکالاهاToolStripMenuItem.Click += new System.EventHandler(this.لیستکالاهاToolStripMenuItem_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 24);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(39, 13);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Lable1";
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Location = new System.Drawing.Point(12, 48);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(39, 13);
            this.lblRoleName.TabIndex = 1;
            this.lblRoleName.Text = "Lable1";
            // 
            // DataGrid1
            // 
            this.DataGrid1.AccessibleName = "datagrid";
            this.DataGrid1.AllowUserToAddRows = false;
            this.DataGrid1.AllowUserToDeleteRows = false;
            this.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGrid1.Location = new System.Drawing.Point(154, 48);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.ReadOnly = true;
            this.DataGrid1.Size = new System.Drawing.Size(420, 320);
            this.DataGrid1.TabIndex = 2;
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGrid1);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NewForm";
            this.Text = "NewForm";
            this.Load += new System.EventHandler(this.NewForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.ToolStripMenuItem modiriat;
        private System.Windows.Forms.ToolStripMenuItem مدیریتکاربرانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتکالاهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Clint;
        private System.Windows.Forms.ToolStripMenuItem لیستکاربرانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem افزودنکاربرجدیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductManagment;
        private System.Windows.Forms.ToolStripMenuItem لیستکالاهاToolStripMenuItem;
        public System.Windows.Forms.DataGridView DataGrid1;
    }
}