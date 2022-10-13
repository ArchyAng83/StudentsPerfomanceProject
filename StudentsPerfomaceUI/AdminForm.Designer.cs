
namespace StudentsPerfomaceUI
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.adminStaffBtn = new System.Windows.Forms.Button();
            this.adminStudentsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminStaffBtn
            // 
            this.adminStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminStaffBtn.Location = new System.Drawing.Point(30, 85);
            this.adminStaffBtn.Name = "adminStaffBtn";
            this.adminStaffBtn.Size = new System.Drawing.Size(204, 59);
            this.adminStaffBtn.TabIndex = 0;
            this.adminStaffBtn.Text = "Работа с персоналом";
            this.adminStaffBtn.UseVisualStyleBackColor = true;
            // 
            // adminStudentsBtn
            // 
            this.adminStudentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminStudentsBtn.Location = new System.Drawing.Point(30, 167);
            this.adminStudentsBtn.Name = "adminStudentsBtn";
            this.adminStudentsBtn.Size = new System.Drawing.Size(204, 59);
            this.adminStudentsBtn.TabIndex = 1;
            this.adminStudentsBtn.Text = "Работа с учениками";
            this.adminStudentsBtn.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 363);
            this.Controls.Add(this.adminStudentsBtn);
            this.Controls.Add(this.adminStaffBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminStaffBtn;
        private System.Windows.Forms.Button adminStudentsBtn;
    }
}