namespace FestivalDeFolklore_CU05
{
    partial class RegistrarDia
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
            this.mascaraHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.mascaraDuracion = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroActuacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDiasFestival = new System.Windows.Forms.Label();
            this.dgvGrillaDiasFestival = new System.Windows.Forms.DataGridView();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo_Musical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_Actuacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbGrupoMusical = new System.Windows.Forms.ComboBox();
            this.btnSiguienteDia = new System.Windows.Forms.Button();
            this.txtNroDia = new System.Windows.Forms.TextBox();
            this.dtpFechaDia = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDia = new System.Windows.Forms.Label();
            this.dtpFechaLimiteAnulacion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaVencimientoAnticipada = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadDeDias = new System.Windows.Forms.TextBox();
            this.labelCantiDias = new System.Windows.Forms.Label();
            this.btnRegistrarFestival = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioEntrada = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaDiasFestival)).BeginInit();
            this.SuspendLayout();
            // 
            // mascaraHoraInicio
            // 
            this.mascaraHoraInicio.Location = new System.Drawing.Point(377, 120);
            this.mascaraHoraInicio.Mask = "00:00";
            this.mascaraHoraInicio.Name = "mascaraHoraInicio";
            this.mascaraHoraInicio.Size = new System.Drawing.Size(50, 20);
            this.mascaraHoraInicio.TabIndex = 56;
            this.mascaraHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // mascaraDuracion
            // 
            this.mascaraDuracion.Location = new System.Drawing.Point(377, 80);
            this.mascaraDuracion.Mask = "00:00";
            this.mascaraDuracion.Name = "mascaraDuracion";
            this.mascaraDuracion.Size = new System.Drawing.Size(50, 20);
            this.mascaraDuracion.TabIndex = 55;
            this.mascaraDuracion.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "horas";
            // 
            // txtNroActuacion
            // 
            this.txtNroActuacion.Location = new System.Drawing.Point(137, 120);
            this.txtNroActuacion.Name = "txtNroActuacion";
            this.txtNroActuacion.Size = new System.Drawing.Size(65, 20);
            this.txtNroActuacion.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Grupo Musical: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Nro De Actuacion: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Hora Inicio: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Duracion: ";
            // 
            // lblDiasFestival
            // 
            this.lblDiasFestival.AutoSize = true;
            this.lblDiasFestival.Location = new System.Drawing.Point(80, 50);
            this.lblDiasFestival.Name = "lblDiasFestival";
            this.lblDiasFestival.Size = new System.Drawing.Size(51, 13);
            this.lblDiasFestival.TabIndex = 48;
            this.lblDiasFestival.Text = "Día Nro: ";
            // 
            // dgvGrillaDiasFestival
            // 
            this.dgvGrillaDiasFestival.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaDiasFestival.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia,
            this.Grupo_Musical,
            this.Duracion,
            this.HoraInicio,
            this.nro_Actuacion});
            this.dgvGrillaDiasFestival.Location = new System.Drawing.Point(30, 244);
            this.dgvGrillaDiasFestival.Name = "dgvGrillaDiasFestival";
            this.dgvGrillaDiasFestival.Size = new System.Drawing.Size(545, 194);
            this.dgvGrillaDiasFestival.TabIndex = 47;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Dia";
            this.Dia.Name = "Dia";
            // 
            // Grupo_Musical
            // 
            this.Grupo_Musical.HeaderText = "Grupo";
            this.Grupo_Musical.Name = "Grupo_Musical";
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.Name = "Duracion";
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.Name = "HoraInicio";
            // 
            // nro_Actuacion
            // 
            this.nro_Actuacion.HeaderText = "Orden Actuacion";
            this.nro_Actuacion.Name = "nro_Actuacion";
            // 
            // cmbGrupoMusical
            // 
            this.cmbGrupoMusical.FormattingEnabled = true;
            this.cmbGrupoMusical.Location = new System.Drawing.Point(137, 81);
            this.cmbGrupoMusical.Name = "cmbGrupoMusical";
            this.cmbGrupoMusical.Size = new System.Drawing.Size(121, 21);
            this.cmbGrupoMusical.TabIndex = 46;
            // 
            // btnSiguienteDia
            // 
            this.btnSiguienteDia.Location = new System.Drawing.Point(30, 472);
            this.btnSiguienteDia.Name = "btnSiguienteDia";
            this.btnSiguienteDia.Size = new System.Drawing.Size(136, 45);
            this.btnSiguienteDia.TabIndex = 58;
            this.btnSiguienteDia.Text = "Registrar Dia";
            this.btnSiguienteDia.UseVisualStyleBackColor = true;
            this.btnSiguienteDia.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNroDia
            // 
            this.txtNroDia.Enabled = false;
            this.txtNroDia.Location = new System.Drawing.Point(137, 47);
            this.txtNroDia.Name = "txtNroDia";
            this.txtNroDia.Size = new System.Drawing.Size(66, 20);
            this.txtNroDia.TabIndex = 59;
            // 
            // dtpFechaDia
            // 
            this.dtpFechaDia.Location = new System.Drawing.Point(377, 43);
            this.dtpFechaDia.Name = "dtpFechaDia";
            this.dtpFechaDia.Size = new System.Drawing.Size(235, 20);
            this.dtpFechaDia.TabIndex = 61;
            // 
            // lblFechaDia
            // 
            this.lblFechaDia.AutoSize = true;
            this.lblFechaDia.Location = new System.Drawing.Point(292, 47);
            this.lblFechaDia.Name = "lblFechaDia";
            this.lblFechaDia.Size = new System.Drawing.Size(79, 13);
            this.lblFechaDia.TabIndex = 60;
            this.lblFechaDia.Text = "Fecha del Dia: ";
            // 
            // dtpFechaLimiteAnulacion
            // 
            this.dtpFechaLimiteAnulacion.Location = new System.Drawing.Point(136, 163);
            this.dtpFechaLimiteAnulacion.Name = "dtpFechaLimiteAnulacion";
            this.dtpFechaLimiteAnulacion.Size = new System.Drawing.Size(122, 20);
            this.dtpFechaLimiteAnulacion.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Fecha Limite";
            // 
            // dtpFechaVencimientoAnticipada
            // 
            this.dtpFechaVencimientoAnticipada.Location = new System.Drawing.Point(136, 203);
            this.dtpFechaVencimientoAnticipada.Name = "dtpFechaVencimientoAnticipada";
            this.dtpFechaVencimientoAnticipada.Size = new System.Drawing.Size(122, 20);
            this.dtpFechaVencimientoAnticipada.TabIndex = 67;
            this.dtpFechaVencimientoAnticipada.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Fecha Vencimiento Anti: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCantidadDeDias
            // 
            this.txtCantidadDeDias.Enabled = false;
            this.txtCantidadDeDias.Location = new System.Drawing.Point(136, 12);
            this.txtCantidadDeDias.Name = "txtCantidadDeDias";
            this.txtCantidadDeDias.Size = new System.Drawing.Size(66, 20);
            this.txtCantidadDeDias.TabIndex = 68;
            // 
            // labelCantiDias
            // 
            this.labelCantiDias.AutoSize = true;
            this.labelCantiDias.Location = new System.Drawing.Point(39, 15);
            this.labelCantiDias.Name = "labelCantiDias";
            this.labelCantiDias.Size = new System.Drawing.Size(91, 13);
            this.labelCantiDias.TabIndex = 69;
            this.labelCantiDias.Text = "Cantidad de Dias:";
            // 
            // btnRegistrarFestival
            // 
            this.btnRegistrarFestival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegistrarFestival.Enabled = false;
            this.btnRegistrarFestival.Location = new System.Drawing.Point(430, 472);
            this.btnRegistrarFestival.Name = "btnRegistrarFestival";
            this.btnRegistrarFestival.Size = new System.Drawing.Size(136, 45);
            this.btnRegistrarFestival.TabIndex = 70;
            this.btnRegistrarFestival.Text = "Registrar Festival";
            this.btnRegistrarFestival.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Precio Entrada: ";
            // 
            // txtPrecioEntrada
            // 
            this.txtPrecioEntrada.Location = new System.Drawing.Point(377, 163);
            this.txtPrecioEntrada.Name = "txtPrecioEntrada";
            this.txtPrecioEntrada.Size = new System.Drawing.Size(65, 20);
            this.txtPrecioEntrada.TabIndex = 72;
            // 
            // RegistrarDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 545);
            this.Controls.Add(this.txtPrecioEntrada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRegistrarFestival);
            this.Controls.Add(this.labelCantiDias);
            this.Controls.Add(this.txtCantidadDeDias);
            this.Controls.Add(this.dtpFechaVencimientoAnticipada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaLimiteAnulacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaDia);
            this.Controls.Add(this.lblFechaDia);
            this.Controls.Add(this.txtNroDia);
            this.Controls.Add(this.btnSiguienteDia);
            this.Controls.Add(this.mascaraHoraInicio);
            this.Controls.Add(this.mascaraDuracion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNroActuacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDiasFestival);
            this.Controls.Add(this.dgvGrillaDiasFestival);
            this.Controls.Add(this.cmbGrupoMusical);
            this.Name = "RegistrarDia";
            this.Text = "Registrar Dia";
            this.Load += new System.EventHandler(this.RegistrarDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaDiasFestival)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mascaraHoraInicio;
        private System.Windows.Forms.MaskedTextBox mascaraDuracion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroActuacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDiasFestival;
        private System.Windows.Forms.DataGridView dgvGrillaDiasFestival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo_Musical;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_Actuacion;
        private System.Windows.Forms.ComboBox cmbGrupoMusical;
        private System.Windows.Forms.Button btnSiguienteDia;
        private System.Windows.Forms.TextBox txtNroDia;
        private System.Windows.Forms.DateTimePicker dtpFechaDia;
        private System.Windows.Forms.Label lblFechaDia;
        private System.Windows.Forms.DateTimePicker dtpFechaLimiteAnulacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimientoAnticipada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadDeDias;
        private System.Windows.Forms.Label labelCantiDias;
        private System.Windows.Forms.Button btnRegistrarFestival;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecioEntrada;
    }
}