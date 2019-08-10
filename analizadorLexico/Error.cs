using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analizadorLexico
{
    class Error
    {
        private int idError;
        private int fila;
        private int columna;
        private String caracter;
        private String descripcion;

        public Error(int idError, int fila, int columna, string caracter, string descripcion)
        {
            this.IdError = idError;
            this.Fila = fila;
            this.Columna = columna;
            this.Caracter = caracter;
            this.Descripcion = descripcion;
        }

        public int IdError { get => idError; set => idError = value; }
        public int Fila { get => fila; set => fila = value; }
        public int Columna { get => columna; set => columna = value; }
        public string Caracter { get => caracter; set => caracter = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
