using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestivalDeFolklore_CU05.Entidades
{
    internal class DiaFestival
    {
        //faltan un par de atributos que no ponemos
        //que no hacen falta en este CU.
        public int NroDeDia { get; set; }
        public bool Completa { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaLimiteAnulacionEntrada { get; set; }
        public DateTime FechaVtoVtaAnticipada { get; set; }
        public string HoraPresentacion { get; set; }
        public double PrecioEntrada { get; set; }



        // Constructor
        public DiaFestival(int nroDeDia, 
                            bool completa, 
                            DateTime fecha, 
                            DateTime fechaLimiteAnulacionEntrada, 
                            DateTime fechaVtoVtaAnticipada, 
                            string horaPresentacion, 
                            double precioEntrada)
        {
            NroDeDia = nroDeDia;
            Completa = completa;
            Fecha = fecha;
            FechaLimiteAnulacionEntrada = fechaLimiteAnulacionEntrada;
            FechaVtoVtaAnticipada = fechaVtoVtaAnticipada;
            HoraPresentacion = horaPresentacion;
            PrecioEntrada = precioEntrada;
        }

        

    }
}
