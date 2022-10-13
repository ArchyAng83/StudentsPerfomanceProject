
namespace StudentsPerfomaceUI
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.addStaffBtn = new System.Windows.Forms.Button();
            this.updateStaffBtn = new System.Windows.Forms.Button();
            this.deleteStaffBtn = new System.Windows.Forms.Button();
            this.adminStaffDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.adminStaffDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addStaffBtn
            // 
            this.addStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStaffBtn.Location = new System.Drawing.Point(64, 42);
            this.addStaffBtn.Name = "addStaffBtn";
            this.addStaffBtn.Size = new System.Drawing.Size(140, 43);
            this.addStaffBtn.TabIndex = 0;
            this.addStaffBtn.Text = "Добавить";
            this.addStaffBtn.UseVisualStyleBackColor = true;
            // 
            // updateStaffBtn
            // 
            this.updateStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateStaffBtn.Location = new System.Drawing.Point(311, 41);
            this.updateStaffBtn.Name = "updateStaffBtn";
            this.updateStaffBtn.Size = new System.Drawing.Size(140, 43);
            this.updateStaffBtn.TabIndex = 1;
            this.updateStaffBtn.Text = "Изменить";
            this.updateStaffBtn.UseVisualStyleBackColor = true;
            // 
            // deleteStaffBtn
            // 
            this.deleteStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteStaffBtn.Location = new System.Drawing.Point(572, 41);
            this.deleteStaffBtn.Name = "deleteStaffBtn";
            this.deleteStaffBtn.Size = new System.Drawing.Size(140, 43);
            this.deleteStaffBtn.TabIndex = 2;
            this.deleteStaffBtn.Text = "Удалить";
            this.deleteStaffBtn.UseVisualStyleBackColor = true;
            // 
            // adminStaffDataGridView
            // 
            this.adminStaffDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminStaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminStaffDataGridView.Location = new System.Drawing.Point(0, 147);
            this.adminStaffDataGridView.Name = "adminStaffDataGridView";
            this.adminStaffDataGridView.Size = new System.Drawing.Size(803, 312);
            this.adminStaffDataGridView.TabIndex = 3;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 461);
            this.Controls.Add(this.adminStaffDataGridView);
            this.Controls.Add(this.deleteStaffBtn);
            this.Controls.Add(this.updateStaffBtn);
            this.Controls.Add(this.addStaffBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffForm";
            this.Text = "Персонал";
            ((System.ComponentModel.ISupportInitialize)(this.adminStaffDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addStaffBtn;
        private System.Windows.Forms.Button updateStaffBtn;
        private System.Windows.Forms.Button deleteStaffBtn;
        private System.Windows.Forms.DataGridView adminStaffDataGridView;
    }
}