
namespace StudentsPerfomaceUI
{
    partial class LessonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonForm));
            this.lessonDataGridView = new System.Windows.Forms.DataGridView();
            this.saveLessonBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lessonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lessonDataGridView
            // 
            this.lessonDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lessonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lessonDataGridView.Location = new System.Drawing.Point(-1, 121);
            this.lessonDataGridView.Name = "lessonDataGridView";
            this.lessonDataGridView.Size = new System.Drawing.Size(800, 329);
            this.lessonDataGridView.TabIndex = 0;
            // 
            // saveLessonBtn
            // 
            this.saveLessonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveLessonBtn.Location = new System.Drawing.Point(12, 52);
            this.saveLessonBtn.Name = "saveLessonBtn";
            this.saveLessonBtn.Size = new System.Drawing.Size(181, 34);
            this.saveLessonBtn.TabIndex = 1;
            this.saveLessonBtn.Text = "Сохранить";
            this.saveLessonBtn.UseVisualStyleBackColor = true;
            // 
            // LessonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveLessonBtn);
            this.Controls.Add(this.lessonDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LessonForm";
            this.Text = "LessonForm";
            ((System.ComponentModel.ISupportInitialize)(this.lessonDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lessonDataGridView;
        private System.Windows.Forms.Button saveLessonBtn;
    }
}