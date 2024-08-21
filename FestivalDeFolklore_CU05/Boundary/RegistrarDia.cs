using FestivalDeFolklore_CU05.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FestivalDeFolklore_CU05
{
    public partial class RegistrarDia : Form
    {
        static int nroDelDia = 1;
        static List<Entidades.DiaFestival> listaDias = new List<Entidades.DiaFestival>();

        public RegistrarDia(int cantidadDias)
        {
            InitializeComponent();
            txtNroDia.Text = nroDelDia.ToString();
            txtCantidadDeDias.Text = cantidadDias.ToString();
            LlenarCampos();
            cmbGrupoMusical.SelectedIndex = 0;
        }

        private void LlenarCampos()
        {
            cmbGrupoMusical.Items.Add("Los Manseros Santiagueños");
            cmbGrupoMusical.Items.Add("Chaqueño Palavecino");
            cmbGrupoMusical.Items.Add("Los Nocheros");
            cmbGrupoMusical.Items.Add("Abel Pintos");
            cmbGrupoMusical.Items.Add("Trio San Javier");
            cmbGrupoMusical.Items.Add("Los Huayras");
            cmbGrupoMusical.Items.Add("Los Tekis");
            cmbGrupoMusical.Items.Add("");
            txtNroActuacion.Text = "1";
            mascaraDuracion.Text = "0100";
            mascaraHoraInicio.Text = "2000";
            txtPrecioEntrada.Text = "1000";
            txtPrecioEntrada.Enabled = false;


        }

        public void button1_Click(object sender, EventArgs e)
        {
            int cantDias = int.Parse(txtCantidadDeDias.Text);

            //si quedan días por registrar..
            if(nroDelDia <= cantDias)
            {
                MessageBox.Show("Registrando el Dia: " + nroDelDia );
                Console.WriteLine($"Iteración {nroDelDia}");

                //creo una tupla con los datos del día.
                (DateTime fechaDia,
                 string horaPresentacion,
                 DateTime fechaLimite,
                 DateTime fechaVtoAnticipada,
                 string grupoMusical,
                 string duracion,
                 string ordenActuacion,
                 double precioE) tuplaDia = TomarDatosLoop();
              
                object[] datosDia = {tuplaDia.Item1,tuplaDia.Item5, tuplaDia.Item6,tuplaDia.Item2,tuplaDia.Item7 };

                //agrego los datos a la grilla.
                RellenarGrilla(datosDia);

                //Crear objeto DiaFestival
                DiaFestival diaNuevo = new DiaFestival(nroDelDia, true, tuplaDia.Item1, tuplaDia.Item3, tuplaDia.Item4, tuplaDia.Item5, tuplaDia.Item8);
                //Añadir Dia a la lista<DiasFestivales>.
                listaDias.Add(diaNuevo);

                MessageBox.Show("Dia " + nroDelDia + " registrado");
                
                //tomo los datos y los almaceno.
                nroDelDia++;
                //Limpio los campos.
                LimpiarCampos(nroDelDia, cantDias);

                if(nroDelDia > cantDias)
                //si ya se registraron todos los días
                {
                    MessageBox.Show("Ya registraste todos los días de este fetival.");
                    txtNroActuacion.Text = "";
                    cmbGrupoMusical.SelectedIndex = -1;
                    //deshabilito el botón
                    btnSiguienteDia.Enabled = false;
                    btnRegistrarFestival.Enabled = true;
                }
            }
            
             
            //tengo que agregar los datos del Dia a la ListaDias
            
            //cierro la ventana.
            //this.Hide();


        }
        private (DateTime ,string,DateTime ,DateTime,string,string, string,double) TomarDatosLoop()
        {

            DateTime fechaDia = TomarFechaDiaFestival();
            string horaPresentacion = TomarHoraPresentacion();
            DateTime fechaLimite = TomarFechaLimiteAnulacion();
            DateTime fechaVtoAnticipada = TomarFechaVtoVtaAnticipada();
            
            //vamos a suponer que solo actua un grupo musical por día.
            string grupoMusical = TomarGrupoMusical();
            string duracion = TomarDuracion();
            string ordenActuacion = TomarOrdenActuacion();
            double precioEntrada = TomarPrecioEntrada();

            //creo una TUPLA:
            (DateTime fechaDia, 
            string horaPresentacion,
            DateTime fechaLimite, 
            DateTime fechaVtoAnticipada,
            string grupoMusical,
            string duracion,
            string ordenActuacion,
            double precioEntrada) 
            tuplaDatosDia = ( fechaDia, horaPresentacion, fechaLimite, fechaVtoAnticipada, grupoMusical, duracion, ordenActuacion, precioEntrada);

            return tuplaDatosDia;

        }

        public void RellenarGrilla(object[] vectorDatosDias)
        {
            // Agregar una fila a la grilla
            int indiceFila = dgvGrillaDiasFestival.Rows.Add();
            int numeroDia = 0;
            // Recorrer el arreglo y las celdas de la grilla al mismo tiempo
            for (int i = 0; i < vectorDatosDias.Length; i++)
            {
                if(i== 0)
                {
                    numeroDia++;
                    dgvGrillaDiasFestival.Rows[indiceFila].Cells[i].Value = numeroDia;

                }
                // Asignar los valores a las celdas de la fila
                dgvGrillaDiasFestival.Rows[indiceFila].Cells[i].Value = vectorDatosDias[i];
            }
        }
        private void LimpiarCampos(int nroDia, int cantDias)
        {

            //int cantDias = int.Parse(txtCantidadDeDias.ToString());

            //que numero de día es:
            if (nroDia <= cantDias)
            { txtNroDia.Text = nroDia.ToString(); }
            
            cmbGrupoMusical.SelectedIndex ++;
            txtNroActuacion.Text = nroDelDia.ToString();
            //mascaraDuracion.Text = string.Empty;
            //mascaraHoraInicio.Text = string.Empty;


        }
        private DateTime TomarFechaDiaFestival()
        {
            DateTime fechaDia = dtpFechaDia.Value;
            return fechaDia;
        }
        private string TomarHoraPresentacion()
        {
            string horaPres = mascaraHoraInicio.Text;
            return horaPres;
        }

        private DateTime TomarFechaVtoVtaAnticipada()
        {
            DateTime fechaVencimientoAnti = dtpFechaVencimientoAnticipada.Value;
            return fechaVencimientoAnti;
        }

        private DateTime TomarFechaLimiteAnulacion()
        {
            DateTime fechaLimiteAnulacion = dtpFechaLimiteAnulacion.Value;
            return fechaLimiteAnulacion;
        }

        private string TomarGrupoMusical()
        {
            string grupo = cmbGrupoMusical.SelectedItem.ToString();

            return grupo;
        }
        private string TomarOrdenActuacion()
        {
            return txtNroActuacion.Text;
        }

        private string TomarDuracion()
        {
            return mascaraDuracion.Text;
        }

        private double TomarPrecioEntrada()
        {
            return double.Parse(txtPrecioEntrada.Text);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RegistrarDia_Load(object sender, EventArgs e)
        {

        }
    }
}
