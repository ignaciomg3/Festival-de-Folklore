using FestivalDeFolklore_CU05.Controladores;
using FestivalDeFolklore_CU05.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.CompilerServices;


namespace FestivalDeFolklore_CU05
{
    public partial class Pantalla : Form
    {
        string parametroGlobal = "parametro";
        // Crear un objeto DiaFestival con valores ficticios

        //DateTime (año, mes, dia)
        static int añoFestival = 2024;
        static DateTime fechaDia = new DateTime(2024, 7, 1);
        static DateTime fechaLimiteAnulacionEntrada = new DateTime(2024, 6, 30);
        static DateTime fechaVtoVtaAnticipada = new DateTime(2024, 6, 15);
        static string horaPresentacion = "20:00";
        static double precioEntrada = 100.0;
        static double porcentajeDescuento = 40;

        static DiaFestival dia1 = new DiaFestival(1, true, new DateTime(2024, 7, 1), fechaLimiteAnulacionEntrada, fechaVtoVtaAnticipada, horaPresentacion, precioEntrada);
        static DiaFestival dia2 = new DiaFestival(2, true, new DateTime(2024, 7, 2), fechaLimiteAnulacionEntrada, fechaVtoVtaAnticipada, horaPresentacion, precioEntrada);
        static DiaFestival dia3 = new DiaFestival(3, true, new DateTime(2024, 7, 3), fechaLimiteAnulacionEntrada, fechaVtoVtaAnticipada, horaPresentacion, precioEntrada);

        //Hago un objeto tipo List<DiaFestival>
        static List<DiaFestival> listaDias = new List<DiaFestival> { dia1, dia2, dia3 };


        //Creo un objeto Festival 
        static Festival festival1 = new Festival(añoFestival, 50, fechaDia, "Cosquín", porcentajeDescuento, true,listaDeTuplasDatosDia,listaDias);

        //creo una variable Lista<Festival>
        static List<Festival> listaFestivales = new List<Festival> { festival1 };

        static int nroDelDia = 1;

        //creo una lista de Tuplas, cada tupla contiene los datos de UN dia.
        static List<(int, bool, DateTime, DateTime, DateTime, string, double)> listaDeTuplasDatosDia = new List<(int, bool, DateTime, DateTime, DateTime, string, double)> {};


        //Creo un objeto gestor
        static GestorFestival gestor = new GestorFestival(null, null, null, null, listaFestivales, null, "", null, null, null,false, listaDeTuplasDatosDia);

        public Pantalla()
        {
            InitializeComponent();
            RellenarCamposConDatosFicticios();
            txtNroDia.Text = nroDelDia.ToString();
            int cantidadDias = int.Parse(cmbCantidadDiasFestival.SelectedItem.ToString());
            txtCantidadDeDias.Text = cantidadDias.ToString();
            btnRegistrarFestival.Enabled = false;
            LlenarCampos();
            cmbGrupoMusical.SelectedIndex = 0;

        }
        private void RellenarCamposConDatosFicticios()
        {
            // Rellenar el ComboBox con números del 1 al 10

            for (int i = 1; i <= 5; i++)
            {
                cmbCantidadDiasFestival.Items.Add(i);
            }
            txtAñoEdicion.Text = "2024";
            txtNombreFestival.Text = "Jesus Maria";
            cmbCantidadDiasFestival.SelectedIndex = 2;
            txtDescuentoVtaAnticip.Text = "20";
            txtPorcDevAnulacion.Text = "20";

            
        }

        private void btnCrearNuevoFestival_Click(object sender, EventArgs e)
        {
            OpcionRegistrarFestival();

        }

        public void OpcionRegistrarFestival()
        {
            

            //obtengo los datos  que identifican al al festival en una TUPLA.
            (int año, DateTime fechaInicio, string nombreFestival) datosIdent = PedirDatosFestival();

            int añoEd       = datosIdent.Item1;
            DateTime fechaI = datosIdent.Item2;
            string nombreF  = datosIdent.Item3;
            
            bool festivalValido = gestor.TomarDatosIdentFestival(añoEd,nombreF,fechaI);

            if (festivalValido)
            {
                MessageBox.Show("Festival Válido");

                //deshabilito el box2 y el oculto el botón crear Nuevo Festival.
                btnCrearNuevoFestival.Visible = false;
                box2_CrearNuevoFestival.Enabled = false;
                btnSiguienteDia.Enabled = true;

                //pido los demás datos.
                int[] descuentoYPorcentaje = PedirDemasDatosFestival();
                gestor.TomarDatosRestantesFestival(descuentoYPorcentaje);

                //Pido los datos de los Dias.
                PedirDatosDiaFestival();
            }
            else //el festival no es válido, 
            {
                MessageBox.Show("Este festival ya existe.");

            }

        }
        private void HabilitarVentana()
        {
            //debo habilitar el box1
            box1.Enabled = true;
        }
        private (int, DateTime, string) PedirDatosFestival()
        {
            int año                  = TomarAñoEdicion();
            DateTime fechaInicioSola = TomarFechaInicio();
            string nombreFestival    = TomarNombre();

            object[] vector = new object[3] {año,fechaInicioSola,nombreFestival };
            // Retornamos el array
            //return vector;
            return  (año, fechaInicioSola, nombreFestival);
        }
        private int TomarAñoEdicion()
        {
            int añoEdicion = int.Parse(txtAñoEdicion.Text);
            return añoEdicion;
        }
        private DateTime TomarFechaInicio()
        {
            DateTime fechaInicioYHora = dtpFechaInicio.Value;
            return fechaInicioYHora.Date;
        }
        private string TomarNombre()
        {
            string nombre = txtNombreFestival.Text;
            return nombre;
        }
        private int[] PedirDemasDatosFestival()
        {
            int[] descuentoYPorcentajeDevolucion = new int[] { TomarDtoVtaAnticipada(),TomarPorcDevAnulacion() };
            
            return descuentoYPorcentajeDevolucion;
        }
        private int TomarDtoVtaAnticipada()
        {
            int descuentoPorAnticipada = int.Parse(txtDescuentoVtaAnticip.Text);
            return descuentoPorAnticipada;
        }
        private int TomarPorcDevAnulacion()
        {
            int porcentajePorDevolucion = int.Parse(txtPorcDevAnulacion.Text);
            return porcentajePorDevolucion;

        }
        private void PedirDatosDiaFestival()
        {

            //habilito el box1-RegistrarDia
            HabilitarVentana();

            //pido datos de cada dia [mientras haya días de festival]
            //int cantidadDias = int.Parse(cmbCantidadDiasFestival.SelectedItem.ToString());
            
        } 

        private (DateTime, string, DateTime, DateTime, string, string, string, double) TomarDatosLoop()
        {
            //Tomo los datos del dia y los devuelvo como tupla.

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
            tuplaDatosDia = (fechaDia, horaPresentacion, fechaLimite, fechaVtoAnticipada, grupoMusical, duracion, ordenActuacion, precioEntrada);

            return tuplaDatosDia;

        }

        public void RellenarGrilla(object[] vectorDatosDias)
        {
            // Agregar una fila a la grilla
            int indiceFila = dgvGrillaDiasFestival.Rows.Add();
            int numeroDia  = 0;
            // Recorrer el arreglo y las celdas de la grilla al mismo tiempo.
            for (int i = 0; i < vectorDatosDias.Length; i++)
            {
                if (i == 0)
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
            {   
                txtNroDia.Text = nroDia.ToString();

                
            }

            cmbGrupoMusical.SelectedIndex++;
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
          
        private void LlenarCampos()
        {
            LlenarComboBox();
            txtNroActuacion.Text = "1";
            mascaraDuracion.Text = "0100";
            mascaraHoraInicio.Text = "2000";
            txtPrecioEntrada.Text = "1000";
            txtPrecioEntrada.Enabled = false;
        }
        private void LlenarComboBox()
        {
            cmbGrupoMusical.Items.Add("Los Manseros Santiagueños");
            cmbGrupoMusical.Items.Add("Chaqueño Palavecino");
            cmbGrupoMusical.Items.Add("Los Nocheros");
            cmbGrupoMusical.Items.Add("Abel Pintos");
            cmbGrupoMusical.Items.Add("Trio San Javier");
            cmbGrupoMusical.Items.Add("Los Huayras");
            cmbGrupoMusical.Items.Add("Los Tekis");
            cmbGrupoMusical.Items.Add("");
        }
        private void btnSiguienteDia_Click(object sender, EventArgs e)
        {
            int cantDias = int.Parse(txtCantidadDeDias.Text);

            //si quedan días por registrar..
            if (nroDelDia <= cantDias)
            {
                MessageBox.Show("Registrando el Dia: " + nroDelDia+" ...");
                Console.WriteLine($"Iteración nro: {nroDelDia}");


                //Tomo los datos del dia.
                int nroDelDiaActual = nroDelDia;
                bool completo = true; 
                DateTime fechaDia           = TomarFechaDiaFestival();
                string horaPresentacion     = TomarHoraPresentacion();
                DateTime fechaLimite        = TomarFechaLimiteAnulacion();
                DateTime fechaVtoAnticipada = TomarFechaVtoVtaAnticipada();
                string grupoMusical         = TomarGrupoMusical(); //Vamos a suponer que solo actua un grupo musical por día.
                string duracion             = TomarDuracion();
                string ordenActuacion       = TomarOrdenActuacion();
                double precioEntrada        = TomarPrecioEntrada();

                object[] datosDia = { fechaDia, grupoMusical,duracion,horaPresentacion,ordenActuacion};

                //agrego los datos a la grilla.
                RellenarGrilla(datosDia);

                //creo una tupla con los datos del día.
                var tuplaDia = (nroDelDia, completo, fechaDia, fechaLimite, fechaVtoAnticipada, horaPresentacion, precioEntrada);

                //Añadir tupla a la lista<TuplaDatosDelDia>. Que luego se la pasamos al gestor.
                listaDeTuplasDatosDia.Add(tuplaDia);

                MessageBox.Show("Dia " + nroDelDia + " registrado");

                // Obtener la fecha de mañana
                DateTime diaSiguiente = DateTime.Today.AddDays(nroDelDia);

                // Establecer el valor del DateTimePicker en el día de mañana
                dtpFechaDia.Value = diaSiguiente;

                //tomo los datos y los almaceno.
                nroDelDia++;

                //Limpio los campos.
                LimpiarCampos(nroDelDia, cantDias);

                if (nroDelDia > cantDias)
                //si ya se registraron todos los días
                {
                    MessageBox.Show("Ya registraste todos los días de este fetival.");
                    txtNroActuacion.Text = "";
                    cmbGrupoMusical.SelectedIndex = -1;
                    //deshabilito el botón del "Siguiente Dia" y habilito el Registrar Festival..
                    btnSiguienteDia.Enabled      = false;
                    btnRegistrarFestival.Enabled = true;
                }
            }
        }

        private void btnRegistrarFestival_Click_1(object sender, EventArgs e)
        {
            bool valido = gestor.TomarDatosDiaFestival(listaDeTuplasDatosDia);

            if (valido)
            {
                PedirConfirmacionRegistroFestival();
            }

        }

        private void PedirConfirmacionRegistroFestival()
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas registrar este festival?", "Confirmar registro de festival", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar si el usuario hizo clic en el botón "Sí"
            if (resultado == DialogResult.Yes)
            {
                TomarConfirmacionRegistroFestival();
                // Aquí puedes realizar las acciones necesarias si el usuario confirmó el registro
                // Por ejemplo, guardar los datos del festival
            }
            else
            {
                // Aquí puedes realizar las acciones necesarias si el usuario canceló el registro
                // Por ejemplo, volver al formulario anterior o limpiar los campos
                ReiniciarPrograma();
            }
        }

        private void TomarConfirmacionRegistroFestival()
        {
            gestor.tomarConfRegistroFestival();

        }

        public void ReiniciarPrograma()
        {
            // Obtén la ruta del archivo ejecutable del programa actual
            string rutaEjecutable = Process.GetCurrentProcess().MainModule.FileName;

            // Inicia una nueva instancia del programa
            Process.Start(rutaEjecutable);

            // Cierra todas las ventanas abiertas
            this.Hide();

            // Abre una nueva instancia de la ventana principal
            //Application.Restart();
            //try
            //{

            //// Sale del programa actual
            // Environment.Exit(0);
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show("Error: "+e);
            //    throw;
            //}
            
        }
    }
}
