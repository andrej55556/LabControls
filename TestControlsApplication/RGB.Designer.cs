namespace TestControlsApplication
{
    partial class RGB
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
            this.rgb1 = new LabControls.RGB();
            this.SuspendLayout();
            // 
            // rgb1
            // 
            this.rgb1.CurColor = System.Drawing.Color.Black;
            this.rgb1.Location = new System.Drawing.Point(12, 12);
            this.rgb1.Name = "rgb1";
            this.rgb1.Size = new System.Drawing.Size(482, 220);
            this.rgb1.TabIndex = 0;
            // 
            // RGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 192);
            this.Controls.Add(this.rgb1);
            this.Name = "RGB";
            this.Text = "RGB";
            this.ResumeLayout(false);

        }

        #endregion

        private LabControls.RGB rgb1;
    }
}