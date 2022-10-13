
namespace StudentsPerfomaceUI
{
    partial class ClassJournalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassJournalForm));
            this.classTeacherDataGridView = new System.Windows.Forms.DataGridView();
            this.AddToClassJournalBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.classTeacherDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // classTeacherDataGridView
            // 
            this.classTeacherDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classTeacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classTeacherDataGridView.Location = new System.Drawing.Point(1, 138);
            this.classTeacherDataGridView.Name = "classTeacherDataGridView";
            this.classTeacherDataGridView.Size = new System.Drawing.Size(801, 311);
            this.classTeacherDataGridView.TabIndex = 0;
            // 
            // AddToClassJournalBtn
            // 
            this.AddToClassJournalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddToClassJournalBtn.Location = new System.Drawing.Point(26, 60);
            this.AddToClassJournalBtn.Name = "AddToClassJournalBtn";
            this.AddToClassJournalBtn.Size = new System.Drawing.Size(196, 36);
            this.AddToClassJournalBtn.TabIndex = 1;
            this.AddToClassJournalBtn.Text = "Добавить ученика";
            this.AddToClassJournalBtn.UseVisualStyleBackColor = true;
            // 
            // ClassJournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddToClassJournalBtn);
            this.Controls.Add(this.classTeacherDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClassJournalForm";
            this.Text = "Классный журнал";
            ((System.ComponentModel.ISupportInitialize)(this.classTeacherDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView classTeacherDataGridView;
        private System.Windows.Forms.Button AddToClassJournalBtn;
    }
}