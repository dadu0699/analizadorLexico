using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analizadorLexico
{
    class AnalizadorLex
    {
        private String auxiliarLexema;
        private int estado;
        private int idToken;
        private int idError;
        private int fila = 1;
        private int columna = 1;

        internal List<Token> ListToken { get; set; }
        internal List<Error> ListError { get; set; }

        public AnalizadorLex()
        {
            ListToken = new List<Token>();
            ListError = new List<Error>();
            auxiliarLexema = "";
            estado = 0;
            idToken = 0;
            idError = 0;
            fila = 1;
            columna = 1;
        }

        public void escaner(String entrada)
        {
            Char caracter;
            entrada += "#";

            for (int i = 0; i < entrada.Length; i++)
            {
                caracter = entrada.ElementAt(i);
                switch (estado)
                {
                    case 0:
                        // Palabra Reservada
                        if (char.IsLetter(caracter))
                        {
                            estado = 1;
                            auxiliarLexema += caracter;
                        }
                        // Digito
                        else if (char.IsDigit(caracter))
                        {
                            estado = 2;
                            auxiliarLexema += caracter;
                        }
                        // Cadena
                        else if (caracter.Equals('"'))
                        {
                            estado = 3;
                            auxiliarLexema += caracter;
                        }
                        // Espacios en blanco y saltos de linea
                        else if (char.IsWhiteSpace(caracter))
                        {
                            estado = 0;
                            auxiliarLexema = "";
                            // Cambio de fila y reinicio de columnas en los saltos de linea
                            if (caracter.CompareTo('\n') == 0)
                            {
                                columna = 1;
                                fila++;
                            }
                        }
                        // Simbolo
                        else if (!agregarSimbolo(caracter))
                        {
                            if (caracter.Equals('#')  && i == (entrada.Length - 1))
                            {
                                Console.WriteLine("Analisis lexico finalizado");
                            }
                            else
                            {
                                Console.WriteLine("Error lexico: No se encotro '" + caracter + "' en los patrones definidos");
                                agregarError(caracter.ToString());
                                estado = 0;
                            }
                        }
                        break;
                    case 1:
                        if (Char.IsLetter(caracter))
                        {
                            estado = 1;
                            auxiliarLexema += caracter;
                        }
                        else
                        {
                            agregarPalabraR();
                            i --;
                        }
                        break;
                    case 2:
                        if (Char.IsDigit(caracter))
                        {
                            estado = 2;
                            auxiliarLexema += caracter;
                        }
                        else
                        {
                            agregarToken(Token.Tipo.NUMERO);
                            i --;
                        }
                        break;
                    case 3:
                        if (!caracter.Equals('"'))
                        {
                            estado = 3;
                            auxiliarLexema += caracter;
                        }
                        else
                        {
                            auxiliarLexema += caracter;
                            agregarToken(Token.Tipo.CADENA);
                        }
                        break;
                }
                columna++;
            }
        }

        public Boolean agregarSimbolo(Char caracter)
        {
            if (caracter.Equals('['))
            {
                auxiliarLexema += caracter;
                agregarToken(Token.Tipo.SIMBOLO_CORCHETE_IZQ);
                return true;
            }
            else if (caracter.Equals(']'))
            {
                auxiliarLexema += caracter;
                agregarToken(Token.Tipo.SIMBOLO_CORCHETE_DCHO);
                return true;
            }
            else if (caracter.Equals('{'))
            {
                auxiliarLexema += caracter;
                agregarToken(Token.Tipo.SIMBOLO_LLAVE_IZQ);
                return true;
            }
            else if (caracter.Equals('}'))
            {
                auxiliarLexema += caracter;
                agregarToken(Token.Tipo.SIMBOLO_LLAVE_DCHO);
                return true;
            }
            else if (caracter.Equals('('))
            {
                auxiliarLexema += caracter;
                agregarToken(Token.Tipo.SIMBOLO_PARENTESIS_IZQ);
                return true;
            }
            else if (caracter.Equals(')'))
            {
                auxiliarLexema += caracter;
                agregarToken(Token.Tipo.SIMBOLO_PARENTESIS_DCHO);
                return true;
            }
            else if (caracter.Equals('<'))
            {
                auxiliarLexema += caracter;
                agregarToken(Token.Tipo.SIMBOLO_MENOR_QUE);
                return true;
            }
            else if (caracter.Equals('>'))
            {
                auxiliarLexema += caracter;
                agregarToken(Token.Tipo.SIMBOLO_MAYOR_QUE);
                return true;
            }
            else if (caracter.Equals(':'))
            {
                auxiliarLexema += caracter;
                agregarToken(Token.Tipo.SIMBOLO_DOS_PUNTOS);
                return true;
            }
            else if (caracter.Equals(';'))
            {
                auxiliarLexema += caracter;
                agregarToken(Token.Tipo.SIMBOLO_PUNTO_Y_COMA);
                return true;
            }
            return false;
        }

        public void agregarPalabraR()
        {
            if (auxiliarLexema.Equals("planificador", StringComparison.InvariantCultureIgnoreCase))
            {
                agregarToken(Token.Tipo.RESERVADA_PLANIFICADOR);
            }
            else if (auxiliarLexema.Equals("anio", StringComparison.InvariantCultureIgnoreCase))
            {
                agregarToken(Token.Tipo.RESERVADA_ANIO);
            }
            else if (auxiliarLexema.Equals("mes", StringComparison.InvariantCultureIgnoreCase))
            {
                agregarToken(Token.Tipo.RESERVADA_MES);
            }
            else if (auxiliarLexema.Equals("dia", StringComparison.InvariantCultureIgnoreCase))
            {
                agregarToken(Token.Tipo.RESERVADA_DIA);
            }
            else if (auxiliarLexema.Equals("descripcion", StringComparison.InvariantCultureIgnoreCase))
            {
                agregarToken(Token.Tipo.RESERVADA_DESCRIPCION);
            }
            else if (auxiliarLexema.Equals("imagen", StringComparison.InvariantCultureIgnoreCase))
            {
                agregarToken(Token.Tipo.RESERVADA_IMAGEN);
            }
            else
            {
                Console.WriteLine("Error lexico: No se encotró '" + auxiliarLexema + "' en los patrones definidos");
                agregarError(auxiliarLexema);
                auxiliarLexema = "";
                estado = 0;
            }
        }

        public void agregarToken(Token.Tipo tipo)
        {
            idToken++;
            ListToken.Add(new Token(idToken, tipo, auxiliarLexema));
            auxiliarLexema = "";
            estado = 0;
        }

        public void agregarError(string cadena)
        {
            idError++;
            ListError.Add(new Error(idError, fila, columna, cadena, "Patron desconocido"));
        }

        public void imprimirTokens()
        {
            foreach (Token item in ListToken)
            {
                Console.WriteLine(item.IdToken + " " + item.TipoToken + " ---> " + item.Valor);
            }
        }

        public void imprimirErrores()
        {
            foreach (Error item in ListError)
            {
                Console.WriteLine(item.IdError + " ---> " + item.Fila + " ---> " + item.Columna
                    + " <--> " + item.Caracter + " ---> " + item.Descripcion);
            }
        }
    }
}
