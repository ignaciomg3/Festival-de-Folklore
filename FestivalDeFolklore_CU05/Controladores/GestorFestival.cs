using FestivalDeFolklore_CU05.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestivalDeFolklore_CU05.Controladores
{

    internal class GestorFestival
    {

        //ATRIBUTOS
        public bool? DiagCompleta { get; set; }
        public int? Duracion { get; set; }
        public TimeSpan? HoraInicio { get; set; }
        public int? NroOrden { get; set; }
        public List<Festival> ListaFestivales { get; set; }
        public int? AñoFestivalNuevo { get; set; }
        public string  NombreFestivalNuevo { get; set; }
        public DateTime? FechaInicioFestivalNuevo { get; set; }
        public int? DescuentoVtaAnticipada { get; set; }
        public int? PorcentajeAnulacion { get; set; }
        public bool? VigenciaFestivalNuevo { get; set; }
        // Atributo que es una lista de tuplas que serán los atributos de los días.
        public List<(int, bool, DateTime, DateTime, DateTime,string, double)> ListaDeTuplasDatosDia { get; set; }

        // Constructor
        public GestorFestival(bool? diagCompleta, 
                            int? duracion, 
                            TimeSpan? horaInicio,
                            int? nroOrden,
                            List<Festival> festivales,
                            int? añoFestivalNuevo,
                            string nombreFestivalNuevo,
                            DateTime? fechaInicioFestivalNuevo,
                            int? descuento,
                            int? porcentaje,
                            bool? vigenciaFestivalNuevo,
                            List<(int, bool, DateTime, DateTime, DateTime, string, double)> listaDeTuplasDatosDia
                            )
        {
            DiagCompleta = diagCompleta;
            Duracion = duracion;
            HoraInicio = horaInicio;
            NroOrden = nroOrden;
            ListaFestivales = festivales;
            AñoFestivalNuevo = añoFestivalNuevo;
            NombreFestivalNuevo = nombreFestivalNuevo;
            FechaInicioFestivalNuevo = fechaInicioFestivalNuevo;
            DescuentoVtaAnticipada = descuento;
            PorcentajeAnulacion = porcentaje;
            VigenciaFestivalNuevo = vigenciaFestivalNuevo;
            ListaDeTuplasDatosDia = listaDeTuplasDatosDia;

        }

        //métodos:

        public void nuevoFestival()
        {
            
        }
        public bool TomarDatosIdentFestival(int año,string nombre, DateTime fechaInicio)
        {
            bool valido = ValidarFestival( año, nombre, fechaInicio);

            if (valido)
            {
                this.AñoFestivalNuevo = año;
                this.NombreFestivalNuevo = nombre;
                this.FechaInicioFestivalNuevo = fechaInicio;
            }

            return valido;
        }
        public bool ValidarFestival(int año, string nombre, DateTime fechaInicio)
        {
            bool esValido = false;
            //recorre la lista de Festivales y vé si no hay uno igual
            foreach (Festival festival in ListaFestivales)
            {
                  
                // Compara los 3 datos del festival con los datos que se quieren ingresar.
                if (festival.ExisteFestival(año,nombre,fechaInicio))
                {
                    // Si encuentra una coincidencia, retorna existe = true, el Festival ya existe.
                    //Si existe --> entonces no es válido.
                    esValido = false; break;
                }
                else 
                {
                    // Si no hay coincidencia quiere decir que el festival a registrar aún no existe.
                    //Si no existe --> es válido para registrarlo.
                    esValido = true;
                }
            }

            // Si no encuentra ninguna coincidencia, retorna false
            return esValido;
        }
        
        public void TomarDatosRestantesFestival(int[] descuentoYPorcentaje)
        {
            int descuento = descuentoYPorcentaje[0];
            int porcentaje = descuentoYPorcentaje[1];

            this.DescuentoVtaAnticipada = descuento;
            this.PorcentajeAnulacion = porcentaje;
        }
        public bool TomarDatosDiaFestival(List<(int, bool, DateTime, DateTime, DateTime, string, double)>  listaTuplasDatosDia)  
        {
            if (ValidarDuplicacionDiasFestival(listaTuplasDatosDia)) {
                
                MessageBox.Show("Fechas Válidas");
                return true;
            }
            else
            {
                MessageBox.Show("Fechas repetidas");
                return false;

            }

        }
        public bool ValidarDuplicacionDiasFestival(List<(int, bool, DateTime, DateTime, DateTime, string, double)> listaTuplasDatosDia)
        {

            // HashSet para almacenar los terceros elementos (DateTime)
            HashSet<DateTime> fechasDia = new HashSet<DateTime>();

            foreach (var tupla in listaTuplasDatosDia)
            {
                // Verificar si el tercer elemento de la tupla ya está en el HashSet
                if (!fechasDia.Add(tupla.Item3))
                {
                    // Se encontró un tercer elemento duplicado
                    return false;
                }
            }

            return true;

        }
        public void tomarConfRegistroFestival()
        {
            AsignarVigenciaFestival();

            CrearFestival();
        }
        public void AsignarVigenciaFestival()
        {
            VigenciaFestivalNuevo = true;
        }
        public void CrearFestival()
        {   
            //creo una listaDiasFestival vacía.
            List<DiaFestival> listaDiasVacia = new List<DiaFestival>();

            //Festival festival = new Festival(___)
            Festival festivalNuevo = new Festival(AñoFestivalNuevo,
                                                DescuentoVtaAnticipada,
                                                FechaInicioFestivalNuevo,
                                                NombreFestivalNuevo,
                                                PorcentajeAnulacion,
                                                VigenciaFestivalNuevo,
                                                ListaDeTuplasDatosDia,
                                                listaDiasVacia
                                                );
            
            Console.WriteLine("Festival Creado");

            festivalNuevo.CrearDiaFestival();

            ListaFestivales.Add(festivalNuevo);

            FinCU();

        }
        public void FinCU()
        {
            MessageBox.Show("Festival registrado con éxito");

            MostrarFestivales();

            MessageBox.Show("Fin de Caso de Uso nro 5 - Registrar Festival.");
        }

        private void MostrarFestivales()
        {

            StringBuilder sb = new StringBuilder();

            foreach (var festival in ListaFestivales)
            {
                sb.AppendLine($"Nombre del festival: {festival.Nombre}");
                sb.AppendLine($"Año de edición: {festival.AñoEdicion}");
                sb.AppendLine($"Descuento venta anticipada: {festival.DescuentoVentaAnticipada}");
                // Agrega otros datos del festival...

                sb.AppendLine("Días del festival:");
                foreach (var dia in festival.ListaDiasFestival)
                {
                    sb.AppendLine($"Número de día: {dia.NroDeDia}");
                    sb.AppendLine($"Completa: {dia.Completa}");
                    sb.AppendLine($"Fecha: {dia.Fecha}");
                    // Agrega otros datos del día...
                }

                sb.AppendLine(); // Salto de línea entre festivales
            }
            MessageBox.Show(sb.ToString(), "Información de los festivales", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        private void MostrarFestivalesPorConsola()
        { 
            foreach (var festival in ListaFestivales)
            {
                Console.WriteLine($"Nombre del festival: {festival.Nombre}");
                Console.WriteLine($"Año de edición: {festival.AñoEdicion}");
                Console.WriteLine($"Descuento venta anticipada: {festival.DescuentoVentaAnticipada}");
                // Mostrar otros datos del festival...

                Console.WriteLine("Días del festival:");
                foreach (var dia in festival.ListaDiasFestival)
                {
                    Console.WriteLine($"Número de día: {dia.NroDeDia}");
                    Console.WriteLine($"Completa: {dia.Completa}");
                    Console.WriteLine($"Fecha: {dia.Fecha}");
                    // Mostrar otros datos del día...
                }

                Console.WriteLine(); // Salto de línea entre festivales
            }
            
        }
    }


    
}
