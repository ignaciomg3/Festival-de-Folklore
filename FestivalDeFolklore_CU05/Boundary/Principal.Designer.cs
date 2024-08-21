namespace FestivalDeFolklore_CU05.Boundary
{
    partial class Principal
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
            this.btnCasoUso05 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCasoUso05
            // 
            this.btnCasoUso05.Location = new System.Drawing.Point(23, 23);
            this.btnCasoUso05.Name = "btnCasoUso05";
            this.btnCasoUso05.Size = new System.Drawing.Size(194, 54);
            this.btnCasoUso05.TabIndex = 0;
            this.btnCasoUso05.Text = "Registrar Festival";
            this.btnCasoUso05.UseVisualStyleBackColor = true;
            this.btnCasoUso05.Click += new System.EventHandler(this.btnCasoUso05_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FestivalDeFolklore_CU05.Properties.Resources.chaqueño;
            this.ClientSize = new System.Drawing.Size(915, 534);
            this.Controls.Add(this.btnCasoUso05);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCasoUso05;
    }
}