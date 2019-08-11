using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analizadorLexico
{
    class Planificaciones
    {
        private String nombrePlanificacion;
        private DateTime fecha;
        private String descripcion;
        private String imagen;

        public Planificaciones(string nombrePlanificacion, DateTime fecha, string descripcion, string imagen)
        {
            this.nombrePlanificacion = nombrePlanificacion;
            this.fecha = fecha;
            this.descripcion = descripcion;
            this.imagen = imagen;
        }

        public string NombrePlanificacion { get => nombrePlanificacion; set => nombrePlanificacion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Imagen { get => imagen; set => imagen = value; }
    }
}
