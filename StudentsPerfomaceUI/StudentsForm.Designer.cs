
namespace StudentsPerfomaceUI
{
    partial class StudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            this.adminStudentDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteStudentBtn = new System.Windows.Forms.Button();
            this.updateStudentBtn = new System.Windows.Forms.Button();
            this.addStudentBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminStudentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // adminStudentDataGridView
            // 
            this.adminStudentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminStudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminStudentDataGridView.Location = new System.Drawing.Point(-3, 138);
            this.adminStudentDataGridView.Name = "adminStudentDataGridView";
            this.adminStudentDataGridView.Size = new System.Drawing.Size(803, 312);
            this.adminStudentDataGridView.TabIndex = 7;
            // 
            // deleteStudentBtn
            // 
            this.deleteStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteStudentBtn.Location = new System.Drawing.Point(569, 32);
            this.deleteStudentBtn.Name = "deleteStudentBtn";
            this.deleteStudentBtn.Size = new System.Drawing.Size(140, 43);
            this.deleteStudentBtn.TabIndex = 6;
            this.deleteStudentBtn.Text = "Удалить";
            this.deleteStudentBtn.UseVisualStyleBackColor = true;
            // 
            // updateStudentBtn
            // 
            this.updateStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateStudentBtn.Location = new System.Drawing.Point(308, 32);
            this.updateStudentBtn.Name = "updateStudentBtn";
            this.updateStudentBtn.Size = new System.Drawing.Size(140, 43);
            this.updateStudentBtn.TabIndex = 5;
            this.updateStudentBtn.Text = "Изменить";
            this.updateStudentBtn.UseVisualStyleBackColor = true;
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStudentBtn.Location = new System.Drawing.Point(61, 33);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(140, 43);
            this.addStudentBtn.TabIndex = 4;
            this.addStudentBtn.Text = "Добавить";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminStudentDataGridView);
            this.Controls.Add(this.deleteStudentBtn);
            this.Controls.Add(this.updateStudentBtn);
            this.Controls.Add(this.addStudentBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentsForm";
            this.Text = "Студенты";
            ((System.ComponentModel.ISupportInitialize)(this.adminStudentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView adminStudentDataGridView;
        private System.Windows.Forms.Button deleteStudentBtn;
        private System.Windows.Forms.Button updateStudentBtn;
        private System.Windows.Forms.Button addStudentBtn;
    }
}