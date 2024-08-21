using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestivalDeFolklore_CU05.Entidades
{
    internal class Festival
    {
        //atributos
        public int? AñoEdicion { get; set; }
        public int? DescuentoVentaAnticipada { get; set; }
        public DateTime? FechaInicio { get; set; }
        public string Nombre { get; set; }
        public double? PorcentajeDevolucionPorAnulacion { get; set; }
        public bool? Vigente { get; set; }
        public List<(int, bool, DateTime, DateTime, DateTime, string, double)> ListaDeTuplasDatosDia { get; set; }
        public List<DiaFestival> ListaDiasFestival { get; set; }


        // Constructor
        public Festival(int? añoEdicion, 
                        int? descuentoVentaAnticipada, 
                        DateTime? fechaInicio,
                        string nombre, 
                        double? porcentajeDevolucionPorAnulacion,
                        bool? vigente,
                        List<(int, bool, DateTime, DateTime, DateTime, string, double)> listaDeTuplasDatosDia,
                        List<DiaFestival> diasFestival)
        {
            AñoEdicion = añoEdicion;
            DescuentoVentaAnticipada = descuentoVentaAnticipada;
            FechaInicio = fechaInicio;
            Nombre = nombre;
            PorcentajeDevolucionPorAnulacion = porcentajeDevolucionPorAnulacion;
            Vigente = vigente;
            ListaDeTuplasDatosDia = listaDeTuplasDatosDia;
            ListaDiasFestival = diasFestival;

        }


        //metodos
        public void CrearDiaFestival()
        {

            //* crear un DiaFestval (Mientras haya días)
            foreach (var dia in ListaDeTuplasDatosDia)
            {
                DiaFestival diaNuevo = new DiaFestival(dia.Item1, dia.Item2, dia.Item3, dia.Item4, dia.Item5, dia.Item6, dia.Item7);
                this.ListaDiasFestival.Add(diaNuevo);
                Console.WriteLine("Dia agregado a la lista.");
            }
            
        }

        public bool ExisteFestival(int año, string nombre, DateTime fechaInicio)
        {
            bool existe = false;

            if (
                    this.AñoEdicion == año &&
                    this.FechaInicio == fechaInicio &&
                    this.Nombre == nombre)
            {
                // Si encuentra una coincidencia, retorna false, el Festival ya existe.
                existe = true;
            }

            else
            {
                // Si no hay coincidencia quiere decir que el festival a registrar no existe aún.
                existe = false;
            }

            return existe;
        }
    }
}
