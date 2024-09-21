namespace LabControls
{
    partial class RGB
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.rbtnDec = new System.Windows.Forms.RadioButton();
            this.rbtnHex = new System.Windows.Forms.RadioButton();
            this.ntbBlue = new LabControls.NumberTB(this.components);
            this.ntbGreen = new LabControls.NumberTB(this.components);
            this.ntbRed = new LabControls.NumberTB(this.components);
            this.SuspendLayout();
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(3, 22);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(63, 16);
            this.lblRed.TabIndex = 0;
            this.lblRed.Text = "Красный";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(1, 53);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(65, 16);
            this.lblGreen.TabIndex = 1;
            this.lblGreen.Text = "Зелёный";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(3, 86);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(48, 16);
            this.lblBlue.TabIndex = 2;
            this.lblBlue.Text = "Синий";
            // 
            // rbtnDec
            // 
            this.rbtnDec.AutoSize = true;
            this.rbtnDec.Location = new System.Drawing.Point(6, 114);
            this.rbtnDec.Name = "rbtnDec";
            this.rbtnDec.Size = new System.Drawing.Size(53, 20);
            this.rbtnDec.TabIndex = 3;
            this.rbtnDec.TabStop = true;
            this.rbtnDec.Text = "Dec";
            this.rbtnDec.UseVisualStyleBackColor = true;
            this.rbtnDec.CheckedChanged += new System.EventHandler(this.RbutDecCheckedChanged);
            // 
            // rbtnHex
            // 
            this.rbtnHex.AutoSize = true;
            this.rbtnHex.Location = new System.Drawing.Point(84, 114);
            this.rbtnHex.Name = "rbtnHex";
            this.rbtnHex.Size = new System.Drawing.Size(52, 20);
            this.rbtnHex.TabIndex = 4;
            this.rbtnHex.TabStop = true;
            this.rbtnHex.Text = "Hex";
            this.rbtnHex.UseVisualStyleBackColor = true;
            this.rbtnHex.CheckedChanged += new System.EventHandler(this.RbutHexCheckedChanged);
            // 
            // ntbBlue
            // 
            this.ntbBlue.ForeColor = System.Drawing.Color.Blue;
            this.ntbBlue.Location = new System.Drawing.Point(84, 83);
            this.ntbBlue.MaxLength = 3;
            this.ntbBlue.Name = "ntbBlue";
            this.ntbBlue.Size = new System.Drawing.Size(52, 22);
            this.ntbBlue.TabIndex = 10;
            this.ntbBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ntbBlue.TextMode = LabControls.NumberTB.Mode.Dec;
            this.ntbBlue.TextChanged += new System.EventHandler(this.NtbBlueTextChanged);
            // 
            // ntbGreen
            // 
            this.ntbGreen.ForeColor = System.Drawing.Color.Green;
            this.ntbGreen.Location = new System.Drawing.Point(84, 50);
            this.ntbGreen.MaxLength = 3;
            this.ntbGreen.Name = "ntbGreen";
            this.ntbGreen.Size = new System.Drawing.Size(52, 22);
            this.ntbGreen.TabIndex = 9;
            this.ntbGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ntbGreen.TextMode = LabControls.NumberTB.Mode.Dec;
            this.ntbGreen.TextChanged += new System.EventHandler(this.NtbGreenTextChanged);
            // 
            // ntbRed
            // 
            this.ntbRed.ForeColor = System.Drawing.Color.Red;
            this.ntbRed.Location = new System.Drawing.Point(84, 22);
            this.ntbRed.MaxLength = 3;
            this.ntbRed.Name = "ntbRed";
            this.ntbRed.Size = new System.Drawing.Size(52, 22);
            this.ntbRed.TabIndex = 8;
            this.ntbRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ntbRed.TextMode = LabControls.NumberTB.Mode.Dec;
            this.ntbRed.TextChanged += new System.EventHandler(this.NtbRedTextChanged);
            // 
            // RGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ntbBlue);
            this.Controls.Add(this.ntbGreen);
            this.Controls.Add(this.ntbRed);
            this.Controls.Add(this.rbtnHex);
            this.Controls.Add(this.rbtnDec);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Name = "RGB";
            this.Size = new System.Drawing.Size(300, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.RadioButton rbtnDec;
        private System.Windows.Forms.RadioButton rbtnHex;
        private NumberTB ntbRed;
        private NumberTB ntbGreen;
        private NumberTB ntbBlue;
    }
}
