using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analizadorLexico
{
    class GeneradorHTML
    {
        private FileStream fileStream;
        private StreamWriter streamWriter;

        public GeneradorHTML()
        {
        }

        public void encabezadoHTML()
        {
            streamWriter = null;
            streamWriter = new StreamWriter(fileStream, Encoding.UTF8);

            streamWriter.WriteLine("<!doctype html>");
            streamWriter.WriteLine("<html lang=\"es\">");
            streamWriter.WriteLine("<head>");
            streamWriter.WriteLine("<meta charset=\"utf - 8\">");
            streamWriter.WriteLine("<meta name=\"viewport\" content=\"width = device - width, initial - scale = 1, shrink - to - fit = no\">");
            streamWriter.WriteLine("<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.3/css/bootstrap.css\">");
            streamWriter.WriteLine("<link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.19/css/jquery.dataTables.css\">");
        }

        public void footerHTML()
        {
            streamWriter.WriteLine("<script src=\"https://code.jquery.com/jquery-3.3.1.js\"></script>");
            streamWriter.WriteLine("<script src=\"https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js\"></script>");
            streamWriter.WriteLine("<script src=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js\"></script>");
            streamWriter.WriteLine("<script src=\"https://cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js\"></script>");
            streamWriter.WriteLine("<script> $(document).ready(function () {$('#example').DataTable();});</script>");
            streamWriter.WriteLine("</body>");
            streamWriter.WriteLine("</html>");

            streamWriter.Close();
            fileStream.Close();
        }

        public void generarReporte(string nombreArchivo, List<Token> listTokens)
        {
            fileStream = null;
            fileStream = new FileStream(nombreArchivo, FileMode.Create);
            encabezadoHTML();

            streamWriter.WriteLine("<title>Tokens</title>");
            streamWriter.WriteLine("</head>");
            streamWriter.WriteLine("<body>");
            streamWriter.WriteLine("<div class=\"container\"><br>");
            streamWriter.WriteLine("<h1>Listado de Tokens</h1><hr>");
            streamWriter.WriteLine("<table id=\"example\" class=\"table table - striped table - bordered\" style=\"width: 100 % \">");
            streamWriter.WriteLine("<thead><tr><th>#</th><th>Fila</th><th>Lexema</th><th>Token</th></tr></thead>");
            streamWriter.WriteLine("<tbody>");

            foreach (var item in listTokens)
            {
                streamWriter.WriteLine("<tr>");
                streamWriter.WriteLine("<th>" + item.IdToken + "</th>");
                streamWriter.WriteLine("<th>" + item.Fila + "</th>");
                streamWriter.WriteLine("<th>" + item.Valor + "</th>");
                streamWriter.WriteLine("<th>" + item.TipoToken + "</th>");
                streamWriter.WriteLine("</tr>");
            }

            streamWriter.WriteLine("</tbody>");
            streamWriter.WriteLine("</table>");
            streamWriter.WriteLine("</div>");

            footerHTML();
        }

        public void generarReporte(string nombreArchivo, List<Error> listError)
        {
            fileStream = new FileStream(nombreArchivo, FileMode.Create);
            encabezadoHTML();

            streamWriter.WriteLine("<title>Errores</title>");
            streamWriter.WriteLine("</head>");
            streamWriter.WriteLine("<body>");
            streamWriter.WriteLine("<div class=\"container\"><br>");
            streamWriter.WriteLine("<h1>Listado de Errores</h1><hr>");
            streamWriter.WriteLine("<table id=\"example\" class=\"table table - striped table - bordered\" style=\"width: 100 % \">");
            streamWriter.WriteLine("<thead><tr><th>#</th><th>Fila</th><th>Columna</th><th>Caractér</th><th>Descripción</th></tr></thead>");
            streamWriter.WriteLine("<tbody>");

            foreach (var item in listError)
            {
                streamWriter.WriteLine("<tr>");
                streamWriter.WriteLine("<th>" + item.IdError + "</th>");
                streamWriter.WriteLine("<th>" + item.Fila + "</th>");
                streamWriter.WriteLine("<th>" + item.Columna + "</th>");
                streamWriter.WriteLine("<th>" + item.Caracter + "</th>");
                streamWriter.WriteLine("<th>" + item.Descripcion + "</th>");
                streamWriter.WriteLine("</tr>");
            }

            streamWriter.WriteLine("</tbody>");
            streamWriter.WriteLine("</table>");
            streamWriter.WriteLine("</div>");

            footerHTML();
        }
    }
}
