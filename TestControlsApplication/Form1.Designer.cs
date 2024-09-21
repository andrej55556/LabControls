namespace TestControlsApplication
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.filePathSelect3 = new LabControls.FilePathSelect();
            this.filePathSelect2 = new LabControls.FilePathSelect();
            this.filePathSelect1 = new LabControls.FilePathSelect();
            this.numberBox1 = new LabControls.NumberBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // filePathSelect3
            // 
            this.filePathSelect3.FileName = "";
            this.filePathSelect3.Location = new System.Drawing.Point(12, 108);
            this.filePathSelect3.Name = "filePathSelect3";
            this.filePathSelect3.Size = new System.Drawing.Size(772, 74);
            this.filePathSelect3.TabIndex = 3;
            // 
            // filePathSelect2
            // 
            this.filePathSelect2.FileName = "";
            this.filePathSelect2.Location = new System.Drawing.Point(12, 188);
            this.filePathSelect2.Name = "filePathSelect2";
            this.filePathSelect2.Size = new System.Drawing.Size(772, 74);
            this.filePathSelect2.TabIndex = 2;
            // 
            // filePathSelect1
            // 
            this.filePathSelect1.FileName = "Test";
            this.filePathSelect1.Location = new System.Drawing.Point(12, 40);
            this.filePathSelect1.Name = "filePathSelect1";
            this.filePathSelect1.Size = new System.Drawing.Size(772, 74);
            this.filePathSelect1.TabIndex = 1;
            // 
            // numberBox1
            // 
            this.numberBox1.ForeColor = System.Drawing.Color.Red;
            this.numberBox1.Location = new System.Drawing.Point(12, 12);
            this.numberBox1.Name = "numberBox1";
            this.numberBox1.Size = new System.Drawing.Size(333, 22);
            this.numberBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filePathSelect3);
            this.Controls.Add(this.filePathSelect2);
            this.Controls.Add(this.filePathSelect1);
            this.Controls.Add(this.numberBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabControls.NumberBox numberBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private LabControls.FilePathSelect filePathSelect3;
        private LabControls.FilePathSelect filePathSelect2;
        private LabControls.FilePathSelect filePathSelect1;
    }
}

