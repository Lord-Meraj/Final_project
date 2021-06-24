
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
            this.اضافهکردنکالاجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتکالاهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کابرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modiriat,
            this.لیستToolStripMenuItem,
            this.کابرانToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modiriat
            // 
            this.modiriat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافهکردنکالاجدیدToolStripMenuItem,
            this.مدیریتکالاهاToolStripMenuItem});
            this.modiriat.Name = "modiriat";
            this.modiriat.Size = new System.Drawing.Size(57, 20);
            this.modiriat.Text = "مدیریت";
            // 
            // اضافهکردنکالاجدیدToolStripMenuItem
            // 
            this.اضافهکردنکالاجدیدToolStripMenuItem.Name = "اضافهکردنکالاجدیدToolStripMenuItem";
            this.اضافهکردنکالاجدیدToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.اضافهکردنکالاجدیدToolStripMenuItem.Text = "اضافه کردن کالا جدید";
            // 
            // مدیریتکالاهاToolStripMenuItem
            // 
            this.مدیریتکالاهاToolStripMenuItem.Name = "مدیریتکالاهاToolStripMenuItem";
            this.مدیریتکالاهاToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.مدیریتکالاهاToolStripMenuItem.Text = "مدیریت کالا ها";
            // 
            // لیستToolStripMenuItem
            // 
            this.لیستToolStripMenuItem.Name = "لیستToolStripMenuItem";
            this.لیستToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.لیستToolStripMenuItem.Text = "محصولات";
            // 
            // کابرانToolStripMenuItem
            // 
            this.کابرانToolStripMenuItem.Name = "کابرانToolStripMenuItem";
            this.کابرانToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.کابرانToolStripMenuItem.Text = "کابران";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 24);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(39, 13);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Lable1";
            this.lblUserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Location = new System.Drawing.Point(12, 48);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(39, 13);
            this.lblRoleName.TabIndex = 1;
            this.lblRoleName.Text = "Lable1";
            this.lblRoleName.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NewForm";
            this.Text = "NewForm";
            this.Load += new System.EventHandler(this.NewForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modiriat;
        private System.Windows.Forms.ToolStripMenuItem اضافهکردنکالاجدیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتکالاهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem کابرانToolStripMenuItem;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblRoleName;
    }
}