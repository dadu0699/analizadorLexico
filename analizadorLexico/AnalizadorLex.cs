using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analizadorLexico
{
    class AnalizadorLex
    {
        private LinkedList<Token> linkedListSalida;
        private String auxiliarLexema;
        private int estado;

        public AnalizadorLex()
        {
            linkedListSalida = new LinkedList<Token>();
            auxiliarLexema = "";
            estado = 0;
        }

        public LinkedList<Token> escaner(String entrada)
        {
            entrada += "#";
            Char caracter;

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
                        else if (char.IsWhiteSpace(caracter) || caracter.Equals('\n'))
                        {
                            estado = 0;
                            auxiliarLexema = "";
                        }
                        // Simbolo
                        else if (!agregarSimbolo(caracter))
                        {
                            if (caracter.Equals('#')  && i == (entrada.Length - 1))
                            {
                                Console.WriteLine("Analisis finalizado");
                            }
                            else
                            {
                                Console.WriteLine("Error lexico: No se encotro '" + caracter + "' en los patrones definidos");
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
                            i -= 1;
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
                            i -= 1;
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
            }

            return linkedListSalida;
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
                auxiliarLexema = "";
                estado = 0;
            }
        }

        public void agregarToken(Token.Tipo tipo)
        {
            linkedListSalida.AddLast(new Token(tipo, auxiliarLexema));
            auxiliarLexema = "";
            estado = 0;
        }

        public void imprimirTokens(LinkedList<Token> linkedList)
        {
            foreach (Token item in linkedList)
            {
                Console.WriteLine(item.TipoToken + " <--> " + item.Valor);
            }
        }
    }
}
