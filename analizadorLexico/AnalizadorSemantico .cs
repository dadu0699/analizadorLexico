using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analizadorLexico
{
    class AnalizadorSemantico
    {
        public AnalizadorSemantico()
        {
        }

        public Boolean analizar(List<Token> ListToken)
        {
            for (int i = 0; i < ListToken.Count; i++)
            {
                Console.WriteLine(i + " " + ListToken[i].TipoToken);
                if (i == 0)
                {
                    if (!ListToken[i].TipoToken.Equals("Reservada Planificador"))
                    {
                        Console.WriteLine("Reservada Planificador: " + ListToken[i].TipoToken);
                        return false;
                    }
                }
                else if (i == (ListToken.Count - 1))
                {
                    if (!ListToken[i].TipoToken.Equals("Simbolo Corchete Derecho"))
                    {
                        Console.WriteLine("Simbolo Corchete Derecho: " + ListToken[i].TipoToken);
                        return false;
                    }
                }
                else
                {
                    if (ListToken[i].TipoToken.Equals("Reservada Planificador")
                        && !ListToken[i + 1].TipoToken.Equals("Simbolo Dos Puntos"))
                    {
                        Console.WriteLine("Reservada Planificador: " + ListToken[i].TipoToken 
                            + " -- " + ListToken[i + 1].TipoToken);
                        return false;
                    }
                    else if (ListToken[i].TipoToken.Equals("Simbolo Dos Puntos")
                        && !ListToken[i + 1].TipoToken.Equals("Cadena") 
                        && !ListToken[i + 1].TipoToken.Equals("Numero"))
                    {
                        Console.WriteLine("Simbolo Dos Puntos: " + ListToken[i].TipoToken 
                            + " -- " + ListToken[i + 1].TipoToken);
                        return false;
                    }
                    else if (ListToken[i].TipoToken.Equals("Cadena")
                        && !ListToken[i + 1].TipoToken.Equals("Simbolo Corchete Izquierdo")
                        && !ListToken[i + 1].TipoToken.Equals("Simbolo Punto y Coma"))
                    {
                        Console.WriteLine("Cadena: " + ListToken[i].TipoToken
                            + " -- " + ListToken[i + 1].TipoToken);
                        return false;
                    }
                    else if (ListToken[i].TipoToken.Equals("Simbolo Corchete Izquierdo")
                        && !ListToken[i + 1].TipoToken.Equals("Reservada Año"))
                    {
                        Console.WriteLine("Simbolo Corchete Izquierdo: " + ListToken[i].TipoToken
                            + " -- " + ListToken[i + 1].TipoToken);
                        return false;
                    }
                    else if (ListToken[i].TipoToken.Equals("Reservada Año")
                        && !ListToken[i + 1].TipoToken.Equals("Simbolo Dos Puntos"))
                    {
                        Console.WriteLine("Reservada Año: " + ListToken[i].TipoToken
                            + " -- " + ListToken[i + 1].TipoToken);
                        return false;
                    }
                    else if (ListToken[i].TipoToken.Equals("Numero")
                        && !ListToken[i + 1].TipoToken.Equals("Simbolo Llave Izquierda")
                        && !ListToken[i + 1].TipoToken.Equals("Simbolo Parentesis Izquierdo")
                        && !ListToken[i + 1].TipoToken.Equals("Simbolo Menor Que"))
                    {
                        Console.WriteLine("Numero: " + ListToken[i].TipoToken
                            + " -- " + ListToken[i + 1].TipoToken);
                        return false;
                    }
                    else if (ListToken[i].TipoToken.Equals("Simbolo Llave Izquierda")
                        && !ListToken[i + 1].TipoToken.Equals("Reservada Mes"))
                    {
                        Console.WriteLine("Simbolo Llave Izquierda: " + ListToken[i].TipoToken
                            + " -- " + ListToken[i + 1].TipoToken);
                        return false;
                    }
                    else if (ListToken[i].TipoToken.Equals("Reservada Mes")
                        && !ListToken[i + 1].TipoToken.Equals("Simbolo Dos Puntos"))
                    {
                        Console.WriteLine("Reservada Mes: " + ListToken[i].TipoToken
                            + " -- " + ListToken[i + 1].TipoToken);
                        return false;
                    }
                    else if (ListToken[i].TipoToken.Equals("Simbolo Parentesis Izquierdo")
                        && !ListToken[i + 1].TipoToken.Equals("Reservada Dia"))
                    {
                        Console.WriteLine("Simbolo Parentesis Izquierdo: " + ListToken[i].TipoToken
                            + " -- " + ListToken[i + 1].TipoToken);
                        return false;
                    }
                    else if (ListToken[i].TipoToken.Equals("Reservada Dia")
                        && !ListToken[i + 1].TipoToken.Equals("Simbolo Dos Puntos"))
                    {
                        Console.WriteLine("Reservada Dia: " + ListToken[i].TipoToken
                            + " -- " + ListToken[i + 1].TipoToken);
                        return false;
                    }
                    else if (ListToken[i].TipoToken.Equals("Simbolo Menor Que")
                        && !ListToken[i + 1].TipoToken.Equals("Reservada Descripción"))
                    {
                        Console.WriteLine("Simbolo Menor Que: " + ListToken[i].TipoToken
                            + " -- " + ListToken[i + 1].TipoToken);
                        return false;
                    }
                    else if (ListToken[i].TipoToken.Equals("Reservada Descripción")
                        && !ListToken[i + 1].TipoToken.Equals("Simbolo Dos Puntos"))
                    {
                        Console.WriteLine("Reservada Descripción: " + ListToken[i].TipoToken
                            + " -- " + ListToken[i + 1].TipoToken);
                        return false;
                    }
                    else if (ListToken[i].TipoToken.Equals("Simbolo Punto y Coma")
                        && !ListToken[i + 1].TipoToken.Equals("Reservada Imagen")
                        && !ListToken[i + 1].TipoToken.Equals("Simbolo Mayor Que"))
                    {
                        Console.WriteLine("Simbolo Punto y Coma: " + ListToken[i].TipoToken
                            + " -- " + ListToken[i + 1].TipoToken);
                        return false;
                    }
                    else if (ListToken[i].TipoToken.Equals("Reservada Imagen")
                        && !ListToken[i + 1].TipoToken.Equals("Simbolo Dos Puntos"))
                    {
                        Console.WriteLine("Reservada Imagen: " + ListToken[i].TipoToken
                            + " -- " + ListToken[i + 1].TipoToken);
                        return false;
                    }
                    else if (ListToken[i].TipoToken.Equals("Simbolo Mayor Que")
                        && !ListToken[i + 1].TipoToken.Equals("Reservada Dia")
                        && !ListToken[i + 1].TipoToken.Equals("Simbolo Parentesis Derecho"))
                    {
                        Console.WriteLine("Simbolo Mayor Que: " + ListToken[i].TipoToken
                            + " -- " + ListToken[i + 1].TipoToken);
                        return false;
                    }
                    else if (ListToken[i].TipoToken.Equals("Simbolo Parentesis Derecho")
                        && !ListToken[i + 1].TipoToken.Equals("Reservada Mes")
                        && !ListToken[i + 1].TipoToken.Equals("Simbolo Llave Derecha"))
                    {
                        Console.WriteLine("Simbolo Parentesis Derecho: " + ListToken[i].TipoToken
                            + " -- " + ListToken[i + 1].TipoToken);
                        return false;
                    }
                    else if (ListToken[i].TipoToken.Equals("Simbolo Llave Derecha")
                        && !ListToken[i + 1].TipoToken.Equals("Reservada Año")
                        && !ListToken[i + 1].TipoToken.Equals("Simbolo Corchete Derecho"))
                    {
                        Console.WriteLine("Simbolo Llave Derecha: " + ListToken[i].TipoToken
                            + " -- " + ListToken[i + 1].TipoToken);
                        return false;
                    }
                    else if (ListToken[i].TipoToken.Equals("Simbolo Corchete Derecho")
                        && !ListToken[i + 1].TipoToken.Equals("Reservada Planificador"))
                    {
                        Console.WriteLine("Simbolo Corchete Derecho: " + ListToken[i].TipoToken
                            + " -- " + ListToken[i + 1].TipoToken);
                        return false;
                    }
                }
            }
            Console.WriteLine("Analisis sintactico finalizado");
            return true;
        }
    }
}
