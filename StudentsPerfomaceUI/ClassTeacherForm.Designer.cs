
namespace StudentsPerfomaceUI
{
    partial class ClassTeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassTeacherForm));
            this.classWorkForClassTeacheBtn = new System.Windows.Forms.Button();
            this.lessonForClassTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classWorkForClassTeacheBtn
            // 
            this.classWorkForClassTeacheBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classWorkForClassTeacheBtn.Location = new System.Drawing.Point(47, 131);
            this.classWorkForClassTeacheBtn.Name = "classWorkForClassTeacheBtn";
            this.classWorkForClassTeacheBtn.Size = new System.Drawing.Size(231, 47);
            this.classWorkForClassTeacheBtn.TabIndex = 0;
            this.classWorkForClassTeacheBtn.Text = "Работа с классом";
            this.classWorkForClassTeacheBtn.UseVisualStyleBackColor = true;
            // 
            // lessonForClassTeacher
            // 
            this.lessonForClassTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lessonForClassTeacher.Location = new System.Drawing.Point(47, 225);
            this.lessonForClassTeacher.Name = "lessonForClassTeacher";
            this.lessonForClassTeacher.Size = new System.Drawing.Size(231, 47);
            this.lessonForClassTeacher.TabIndex = 1;
            this.lessonForClassTeacher.Text = "Урок";
            this.lessonForClassTeacher.UseVisualStyleBackColor = true;
            // 
            // ClassTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 406);
            this.Controls.Add(this.lessonForClassTeacher);
            this.Controls.Add(this.classWorkForClassTeacheBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClassTeacherForm";
            this.Text = "ClassTeacherForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button classWorkForClassTeacheBtn;
        private System.Windows.Forms.Button lessonForClassTeacher;
    }
}