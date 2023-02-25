namespace WindowsFormsApp1
{
    partial class Ejercicio3
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
            this.DetalleslistBox1 = new System.Windows.Forms.ListBox();
            this.Evaluebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DetalleslistBox1
            // 
            this.DetalleslistBox1.FormattingEnabled = true;
            this.DetalleslistBox1.Location = new System.Drawing.Point(12, 12);
            this.DetalleslistBox1.Name = "DetalleslistBox1";
            this.DetalleslistBox1.Size = new System.Drawing.Size(373, 446);
            this.DetalleslistBox1.TabIndex = 0;
            // 
            // Evaluebutton
            // 
            this.Evaluebutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Evaluebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Evaluebutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Evaluebutton.Location = new System.Drawing.Point(401, 12);
            this.Evaluebutton.Name = "Evaluebutton";
            this.Evaluebutton.Size = new System.Drawing.Size(145, 62);
            this.Evaluebutton.TabIndex = 1;
            this.Evaluebutton.Text = "Evalue";
            this.Evaluebutton.UseVisualStyleBackColor = false;
            this.Evaluebutton.Click += new System.EventHandler(this.Evaluebutton_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 470);
            this.Controls.Add(this.Evaluebutton);
            this.Controls.Add(this.DetalleslistBox1);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DetalleslistBox1;
        private System.Windows.Forms.Button Evaluebutton;
    }
}