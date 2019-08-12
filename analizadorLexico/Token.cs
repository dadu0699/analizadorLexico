using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analizadorLexico
{
    class Token
    {
        public enum Tipo
        {
            RESERVADA_PLANIFICADOR,
            RESERVADA_ANIO,
            RESERVADA_MES,
            RESERVADA_DIA,
            RESERVADA_DESCRIPCION,
            RESERVADA_IMAGEN,
            SIMBOLO_CORCHETE_IZQ,
            SIMBOLO_CORCHETE_DCHO,
            SIMBOLO_LLAVE_IZQ,
            SIMBOLO_LLAVE_DCHO,
            SIMBOLO_PARENTESIS_IZQ,
            SIMBOLO_PARENTESIS_DCHO,
            SIMBOLO_MENOR_QUE,
            SIMBOLO_MAYOR_QUE,
            SIMBOLO_DOS_PUNTOS,
            SIMBOLO_PUNTO_Y_COMA,
            NUMERO,
            CADENA
        }

        private int idToken;
        private int fila;
        private Tipo tipoToken;
        private string valor;

        public Token(int idToken, int fila, Tipo tipoToken, string valor)
        {
            this.idToken = idToken;
            this.fila = fila;
            this.tipoToken = tipoToken;
            this.valor = valor;
        }

        public int IdToken { get => idToken; set => idToken = value; }
        public int Fila { get => fila; set => fila = value; }
        public string Valor { get => valor; set => valor = value; }
        public string TipoToken
        {
            get
            {
                switch (tipoToken)
                {
                    case Tipo.RESERVADA_PLANIFICADOR:
                        return "Reservada Planificador";
                    case Tipo.RESERVADA_ANIO:
                        return "Reservada Año";
                    case Tipo.RESERVADA_MES:
                        return "Reservada Mes";
                    case Tipo.RESERVADA_DIA:
                        return "Reservada Dia";
                    case Tipo.RESERVADA_DESCRIPCION:
                        return "Reservada Descripción";
                    case Tipo.RESERVADA_IMAGEN:
                        return "Reservada Imagen";
                    case Tipo.SIMBOLO_CORCHETE_IZQ:
                        return "Simbolo Corchete Izquierdo";
                    case Tipo.SIMBOLO_CORCHETE_DCHO:
                        return "Simbolo Corchete Derecho";
                    case Tipo.SIMBOLO_LLAVE_IZQ:
                        return "Simbolo Llave Izquierda";
                    case Tipo.SIMBOLO_LLAVE_DCHO:
                        return "Simbolo Llave Derecha";
                    case Tipo.SIMBOLO_PARENTESIS_IZQ:
                        return "Simbolo Parentesis Izquierdo";
                    case Tipo.SIMBOLO_PARENTESIS_DCHO:
                        return "Simbolo Parentesis Derecho";
                    case Tipo.SIMBOLO_MENOR_QUE:
                        return "Simbolo Menor Que";
                    case Tipo.SIMBOLO_MAYOR_QUE:
                        return "Simbolo Mayor Que";
                    case Tipo.SIMBOLO_DOS_PUNTOS:
                        return "Simbolo Dos Puntos";
                    case Tipo.SIMBOLO_PUNTO_Y_COMA:
                        return "Simbolo Punto y Coma";
                    case Tipo.NUMERO:
                        return "Numero";
                    case Tipo.CADENA:
                        return "Cadena";
                    default:
                        return "Desconocido";
                }
            }
        }
    }
}
