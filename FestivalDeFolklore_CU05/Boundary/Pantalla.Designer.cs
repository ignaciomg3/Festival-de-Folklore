namespace FestivalDeFolklore_CU05
{
    partial class Pantalla
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearNuevoFestival = new System.Windows.Forms.Button();
            this.lblDiasFestival = new System.Windows.Forms.Label();
            this.txtNombreFestival = new System.Windows.Forms.TextBox();
            this.txtAñoEdicion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescuentoVtaAnticip = new System.Windows.Forms.TextBox();
            this.txtPorcDevAnulacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCantidadDiasFestival = new System.Windows.Forms.ComboBox();
            this.box1 = new System.Windows.Forms.GroupBox();
            this.txtPrecioEntrada = new System.Windows.Forms.TextBox();
            this.labelCantiDias = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrupoMusical = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCantidadDeDias = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpFechaVencimientoAnticipada = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFechaLimiteAnulacion = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNroActuacion = new System.Windows.Forms.TextBox();
            this.dtpFechaDia = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFechaDia = new System.Windows.Forms.Label();
            this.mascaraDuracion = new System.Windows.Forms.MaskedTextBox();
            this.txtNroDia = new System.Windows.Forms.TextBox();
            this.mascaraHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.dgvGrillaDiasFestival = new System.Windows.Forms.DataGridView();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo_Musical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_Actuacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSiguienteDia = new System.Windows.Forms.Button();
            this.btnRegistrarFestival = new System.Windows.Forms.Button();
            this.box2_CrearNuevoFestival = new System.Windows.Forms.GroupBox();
            this.box1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaDiasFestival)).BeginInit();
            this.box2_CrearNuevoFestival.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearNuevoFestival
            // 
            this.btnCrearNuevoFestival.BackColor = System.Drawing.Color.Peru;
            this.btnCrearNuevoFestival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearNuevoFestival.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCrearNuevoFestival.Location = new System.Drawing.Point(621, 19);
            this.btnCrearNuevoFestival.Name = "btnCrearNuevoFestival";
            this.btnCrearNuevoFestival.Size = new System.Drawing.Size(165, 77);
            this.btnCrearNuevoFestival.TabIndex = 0;
            this.btnCrearNuevoFestival.Text = "Crear Nuevo Festival";
            this.btnCrearNuevoFestival.UseVisualStyleBackColor = false;
            this.btnCrearNuevoFestival.Click += new System.EventHandler(this.btnCrearNuevoFestival_Click);
            // 
            // lblDiasFestival
            // 
            this.lblDiasFestival.AutoSize = true;
            this.lblDiasFestival.Location = new System.Drawing.Point(9, 148);
            this.lblDiasFestival.Name = "lblDiasFestival";
            this.lblDiasFestival.Size = new System.Drawing.Size(91, 13);
            this.lblDiasFestival.TabIndex = 4;
            this.lblDiasFestival.Text = "Dias de Festival:  ";
            // 
            // txtNombreFestival
            // 
            this.txtNombreFestival.Location = new System.Drawing.Point(111, 105);
            this.txtNombreFestival.Name = "txtNombreFestival";
            this.txtNombreFestival.Size = new System.Drawing.Size(119, 20);
            this.txtNombreFestival.TabIndex = 33;
            // 
            // txtAñoEdicion
            // 
            this.txtAñoEdicion.Location = new System.Drawing.Point(111, 34);
            this.txtAñoEdicion.Name = "txtAñoEdicion";
            this.txtAñoEdicion.Size = new System.Drawing.Size(119, 20);
            this.txtAñoEdicion.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Fecha Inicio: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nombre Festival: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Año Edición:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(111, 71);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(235, 20);
            this.dtpFechaInicio.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Descuento Vta Anticipada:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Porcentaje por Devolución:";
            // 
            // txtDescuentoVtaAnticip
            // 
            this.txtDescuentoVtaAnticip.Location = new System.Drawing.Point(494, 37);
            this.txtDescuentoVtaAnticip.Name = "txtDescuentoVtaAnticip";
            this.txtDescuentoVtaAnticip.Size = new System.Drawing.Size(100, 20);
            this.txtDescuentoVtaAnticip.TabIndex = 39;
            // 
            // txtPorcDevAnulacion
            // 
            this.txtPorcDevAnulacion.Location = new System.Drawing.Point(494, 74);
            this.txtPorcDevAnulacion.Name = "txtPorcDevAnulacion";
            this.txtPorcDevAnulacion.Size = new System.Drawing.Size(50, 20);
            this.txtPorcDevAnulacion.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(550, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "%";
            // 
            // cmbCantidadDiasFestival
            // 
            this.cmbCantidadDiasFestival.FormattingEnabled = true;
            this.cmbCantidadDiasFestival.Location = new System.Drawing.Point(111, 145);
            this.cmbCantidadDiasFestival.Name = "cmbCantidadDiasFestival";
            this.cmbCantidadDiasFestival.Size = new System.Drawing.Size(121, 21);
            this.cmbCantidadDiasFestival.TabIndex = 45;
            // 
            // box1
            // 
            this.box1.Controls.Add(this.txtPrecioEntrada);
            this.box1.Controls.Add(this.labelCantiDias);
            this.box1.Controls.Add(this.label2);
            this.box1.Controls.Add(this.cmbGrupoMusical);
            this.box1.Controls.Add(this.label15);
            this.box1.Controls.Add(this.txtCantidadDeDias);
            this.box1.Controls.Add(this.label14);
            this.box1.Controls.Add(this.dtpFechaVencimientoAnticipada);
            this.box1.Controls.Add(this.label13);
            this.box1.Controls.Add(this.label3);
            this.box1.Controls.Add(this.label12);
            this.box1.Controls.Add(this.dtpFechaLimiteAnulacion);
            this.box1.Controls.Add(this.label8);
            this.box1.Controls.Add(this.label5);
            this.box1.Controls.Add(this.txtNroActuacion);
            this.box1.Controls.Add(this.dtpFechaDia);
            this.box1.Controls.Add(this.label6);
            this.box1.Controls.Add(this.lblFechaDia);
            this.box1.Controls.Add(this.mascaraDuracion);
            this.box1.Controls.Add(this.txtNroDia);
            this.box1.Controls.Add(this.mascaraHoraInicio);
            this.box1.Enabled = false;
            this.box1.Location = new System.Drawing.Point(12, 184);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(939, 218);
            this.box1.TabIndex = 46;
            this.box1.TabStop = false;
            this.box1.Text = "Registrar Dia";
            // 
            // txtPrecioEntrada
            // 
            this.txtPrecioEntrada.Location = new System.Drawing.Point(535, 145);
            this.txtPrecioEntrada.Name = "txtPrecioEntrada";
            this.txtPrecioEntrada.Size = new System.Drawing.Size(65, 20);
            this.txtPrecioEntrada.TabIndex = 93;
            // 
            // labelCantiDias
            // 
            this.labelCantiDias.AutoSize = true;
            this.labelCantiDias.Location = new System.Drawing.Point(84, 38);
            this.labelCantiDias.Name = "labelCantiDias";
            this.labelCantiDias.Size = new System.Drawing.Size(91, 13);
            this.labelCantiDias.TabIndex = 91;
            this.labelCantiDias.Text = "Cantidad de Dias:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "Precio Entrada: ";
            // 
            // cmbGrupoMusical
            // 
            this.cmbGrupoMusical.FormattingEnabled = true;
            this.cmbGrupoMusical.Location = new System.Drawing.Point(182, 104);
            this.cmbGrupoMusical.Name = "cmbGrupoMusical";
            this.cmbGrupoMusical.Size = new System.Drawing.Size(121, 21);
            this.cmbGrupoMusical.TabIndex = 73;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(125, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 74;
            this.label15.Text = "Día Nro: ";
            // 
            // txtCantidadDeDias
            // 
            this.txtCantidadDeDias.Enabled = false;
            this.txtCantidadDeDias.Location = new System.Drawing.Point(181, 35);
            this.txtCantidadDeDias.Name = "txtCantidadDeDias";
            this.txtCantidadDeDias.Size = new System.Drawing.Size(66, 20);
            this.txtCantidadDeDias.TabIndex = 90;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(473, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 75;
            this.label14.Text = "Duracion: ";
            // 
            // dtpFechaVencimientoAnticipada
            // 
            this.dtpFechaVencimientoAnticipada.Location = new System.Drawing.Point(535, 187);
            this.dtpFechaVencimientoAnticipada.Name = "dtpFechaVencimientoAnticipada";
            this.dtpFechaVencimientoAnticipada.Size = new System.Drawing.Size(122, 20);
            this.dtpFechaVencimientoAnticipada.TabIndex = 89;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(465, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 76;
            this.label13.Text = "Hora Inicio: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Fecha Vencimiento Anti: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(78, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 77;
            this.label12.Text = "Nro De Actuacion: ";
            // 
            // dtpFechaLimiteAnulacion
            // 
            this.dtpFechaLimiteAnulacion.Location = new System.Drawing.Point(181, 186);
            this.dtpFechaLimiteAnulacion.Name = "dtpFechaLimiteAnulacion";
            this.dtpFechaLimiteAnulacion.Size = new System.Drawing.Size(122, 20);
            this.dtpFechaLimiteAnulacion.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Grupo Musical: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "Fecha Limite";
            // 
            // txtNroActuacion
            // 
            this.txtNroActuacion.Location = new System.Drawing.Point(182, 143);
            this.txtNroActuacion.Name = "txtNroActuacion";
            this.txtNroActuacion.Size = new System.Drawing.Size(65, 20);
            this.txtNroActuacion.TabIndex = 79;
            // 
            // dtpFechaDia
            // 
            this.dtpFechaDia.Location = new System.Drawing.Point(535, 34);
            this.dtpFechaDia.Name = "dtpFechaDia";
            this.dtpFechaDia.Size = new System.Drawing.Size(235, 20);
            this.dtpFechaDia.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "horas";
            // 
            // lblFechaDia
            // 
            this.lblFechaDia.AutoSize = true;
            this.lblFechaDia.Location = new System.Drawing.Point(446, 37);
            this.lblFechaDia.Name = "lblFechaDia";
            this.lblFechaDia.Size = new System.Drawing.Size(79, 13);
            this.lblFechaDia.TabIndex = 84;
            this.lblFechaDia.Text = "Fecha del Dia: ";
            // 
            // mascaraDuracion
            // 
            this.mascaraDuracion.Location = new System.Drawing.Point(535, 62);
            this.mascaraDuracion.Mask = "00:00";
            this.mascaraDuracion.Name = "mascaraDuracion";
            this.mascaraDuracion.Size = new System.Drawing.Size(50, 20);
            this.mascaraDuracion.TabIndex = 81;
            this.mascaraDuracion.ValidatingType = typeof(System.DateTime);
            // 
            // txtNroDia
            // 
            this.txtNroDia.Enabled = false;
            this.txtNroDia.Location = new System.Drawing.Point(182, 70);
            this.txtNroDia.Name = "txtNroDia";
            this.txtNroDia.Size = new System.Drawing.Size(66, 20);
            this.txtNroDia.TabIndex = 83;
            // 
            // mascaraHoraInicio
            // 
            this.mascaraHoraInicio.Location = new System.Drawing.Point(535, 102);
            this.mascaraHoraInicio.Mask = "00:00";
            this.mascaraHoraInicio.Name = "mascaraHoraInicio";
            this.mascaraHoraInicio.Size = new System.Drawing.Size(50, 20);
            this.mascaraHoraInicio.TabIndex = 82;
            this.mascaraHoraInicio.ValidatingType = typeof(System.DateTime);
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
            this.dgvGrillaDiasFestival.Enabled = false;
            this.dgvGrillaDiasFestival.Location = new System.Drawing.Point(12, 408);
            this.dgvGrillaDiasFestival.Name = "dgvGrillaDiasFestival";
            this.dgvGrillaDiasFestival.Size = new System.Drawing.Size(529, 250);
            this.dgvGrillaDiasFestival.TabIndex = 48;
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
            // btnSiguienteDia
            // 
            this.btnSiguienteDia.Enabled = false;
            this.btnSiguienteDia.Location = new System.Drawing.Point(565, 459);
            this.btnSiguienteDia.Name = "btnSiguienteDia";
            this.btnSiguienteDia.Size = new System.Drawing.Size(136, 45);
            this.btnSiguienteDia.TabIndex = 59;
            this.btnSiguienteDia.Text = "Registrar Dia";
            this.btnSiguienteDia.UseVisualStyleBackColor = true;
            this.btnSiguienteDia.Click += new System.EventHandler(this.btnSiguienteDia_Click);
            // 
            // btnRegistrarFestival
            // 
            this.btnRegistrarFestival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegistrarFestival.Enabled = false;
            this.btnRegistrarFestival.Location = new System.Drawing.Point(565, 563);
            this.btnRegistrarFestival.Name = "btnRegistrarFestival";
            this.btnRegistrarFestival.Size = new System.Drawing.Size(136, 45);
            this.btnRegistrarFestival.TabIndex = 71;
            this.btnRegistrarFestival.Text = "Registrar Festival";
            this.btnRegistrarFestival.UseVisualStyleBackColor = false;
            this.btnRegistrarFestival.Click += new System.EventHandler(this.btnRegistrarFestival_Click_1);
            // 
            // box2_CrearNuevoFestival
            // 
            this.box2_CrearNuevoFestival.Controls.Add(this.cmbCantidadDiasFestival);
            this.box2_CrearNuevoFestival.Controls.Add(this.lblDiasFestival);
            this.box2_CrearNuevoFestival.Controls.Add(this.label7);
            this.box2_CrearNuevoFestival.Controls.Add(this.label4);
            this.box2_CrearNuevoFestival.Controls.Add(this.label1);
            this.box2_CrearNuevoFestival.Controls.Add(this.label11);
            this.box2_CrearNuevoFestival.Controls.Add(this.btnCrearNuevoFestival);
            this.box2_CrearNuevoFestival.Controls.Add(this.txtAñoEdicion);
            this.box2_CrearNuevoFestival.Controls.Add(this.txtPorcDevAnulacion);
            this.box2_CrearNuevoFestival.Controls.Add(this.txtNombreFestival);
            this.box2_CrearNuevoFestival.Controls.Add(this.txtDescuentoVtaAnticip);
            this.box2_CrearNuevoFestival.Controls.Add(this.dtpFechaInicio);
            this.box2_CrearNuevoFestival.Controls.Add(this.label10);
            this.box2_CrearNuevoFestival.Controls.Add(this.label9);
            this.box2_CrearNuevoFestival.Location = new System.Drawing.Point(12, 9);
            this.box2_CrearNuevoFestival.Name = "box2_CrearNuevoFestival";
            this.box2_CrearNuevoFestival.Size = new System.Drawing.Size(939, 169);
            this.box2_CrearNuevoFestival.TabIndex = 72;
            this.box2_CrearNuevoFestival.TabStop = false;
            this.box2_CrearNuevoFestival.Text = "Crear Nuevo Festival";
            // 
            // Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.box2_CrearNuevoFestival);
            this.Controls.Add(this.btnRegistrarFestival);
            this.Controls.Add(this.btnSiguienteDia);
            this.Controls.Add(this.dgvGrillaDiasFestival);
            this.Controls.Add(this.box1);
            this.Name = "Pantalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Administracion Festival";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaDiasFestival)).EndInit();
            this.box2_CrearNuevoFestival.ResumeLayout(false);
            this.box2_CrearNuevoFestival.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearNuevoFestival;
        private System.Windows.Forms.Label lblDiasFestival;
        private System.Windows.Forms.TextBox txtNombreFestival;
        private System.Windows.Forms.TextBox txtAñoEdicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescuentoVtaAnticip;
        private System.Windows.Forms.TextBox txtPorcDevAnulacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbCantidadDiasFestival;
        private System.Windows.Forms.GroupBox box1;
        private System.Windows.Forms.TextBox txtPrecioEntrada;
        private System.Windows.Forms.Label labelCantiDias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrupoMusical;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCantidadDeDias;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimientoAnticipada;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFechaLimiteAnulacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNroActuacion;
        private System.Windows.Forms.DateTimePicker dtpFechaDia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFechaDia;
        private System.Windows.Forms.MaskedTextBox mascaraDuracion;
        private System.Windows.Forms.TextBox txtNroDia;
        private System.Windows.Forms.MaskedTextBox mascaraHoraInicio;
        private System.Windows.Forms.DataGridView dgvGrillaDiasFestival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo_Musical;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_Actuacion;
        private System.Windows.Forms.Button btnSiguienteDia;
        private System.Windows.Forms.Button btnRegistrarFestival;
        private System.Windows.Forms.GroupBox box2_CrearNuevoFestival;
    }
}

