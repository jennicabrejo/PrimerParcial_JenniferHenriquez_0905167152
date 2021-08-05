using System;
using System.IO;

namespace PrimerParcial_JenniferHenriquez_0905167152
{
    class Program
    {
        static string Input(string txt)
        {
            Console.Write(txt);
            string val = Console.ReadLine();

            return val;
        }
        static void Main(string[] args)
        {
        Inicio:
            Console.WriteLine("Datos Personales");

        

            string nombre = Input("Nombre: ");
            string apellido = Input("Apellido: ");
            int dpi = Convert.ToInt32(Input("DPI: "));
            string lugar = Input("Lugar de nacimiento: ");
            string fechanaci = Input("Fecha de nacimiento: ");
            string nacionalidad = Input("Nacionalidad: ");
            int edad = Convert.ToInt32(Input("Edad: "));
            int nit = Convert.ToInt32(Input("NIT: "));
            string estado = Input("Estado Civil: ");
            string direccion = Input("Direccion: ");
            int telefono = Convert.ToInt32(Input("Telefono: "));
            string profesion = Input("Profesion: ");

            Console.WriteLine("Habilidades");
            Console.Write("Ingrese 3 Habilidades : ");
            string[] arreglo = new string[3];

            for (int i = 0; i < 3; i++)
            {
                arreglo[i] = Console.ReadLine();
            }

            Console.WriteLine("Hobies");
            Console.Write("Ingrese 3 Hobbies : ");
            string[] arreglo1 = new string[3];

            for (int i = 0; i < 3; i++)
            {
                arreglo1[i] = Console.ReadLine();
            }

            Console.WriteLine("Informacion laboral: ");
            Console.Write("Ingrese su experiencia laboral: ");
            string[] arreglo2 = new string[3];

            for (int i = 0; i < 3; i++)
            {
                arreglo2[i] = Console.ReadLine();
            }

            string ruta = ("C:\\tmp\\DatosCV");

            try
            {
                if (Directory.Exists(ruta))
                {
                    Console.WriteLine("El archivo donde desea guardar estos datos ya existe");
                }
                else
                {
                    Console.WriteLine("El archivo no existe, espere un momento mientras se crea");
                    Directory.CreateDirectory(ruta);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR" + ex.Message);
            }

            string css = "table{width:100%;border:10px solid #5c797c}th{text-align:left;vertical-align:top;border-collapse:collapse;padding:1em;caption-side:bottom}td{padding:3em}caption{border-radius:20px;padding:3em;color:#eee;background:#0097A7;font-size:20px;margin:30px;font-family:'Franklin Gothic Medium','Arial Narrow',Arial,sans-serif}th{background:#BDBDBD;text-align:center}h1{padding:0.3em;text-align:center;color:#0097A7;font-family:'Franklin Gothic Medium','Arial Narrow',Arial,sans-serif}h3{text-align:center;padding:1em;color:cornflowerblue;font-size:50px;font-family:'Franklin Gothic Medium','Arial Narrow',Arial,sans-serif;background-color:bisque}h2{text-align:center;padding:1em;color:cadetblue;font-size:40px;font-family:'Franklin Gothic Medium','Arial Narrow',Arial,sans-serif}p{color:#eee;background-color:rgb(58, 128, 156);padding:10px;border:5px solid silver;margin:auto;text-align:center}ol{display:block;padding:2em;color:rgb(17, 96, 128);font-family:'Franklin Gothic Medium','Arial Narrow',Arial,sans-serif;font-size:25px;background-color:rgb(233,232,232)}ul{color:rgb(17, 96, 128);background-color:rgb(233, 232, 232);font-family:'Franklin Gothic Medium','Arial Narrow',Arial,sans-serif;font-size:25px;padding:2em}li{color:rgb(17,96,128)}dl,dt{color:#eee;background-color:rgb(118, 177, 177);font-family:Verdana,Geneva,Tahoma,sans-serif;font-size:25px;text-align:center}td a{display:block;color:rgb(17,96,128);text-align:center;text-decoration:none}a{display:block;color:rgb(17, 96, 128);text-decoration:none}";

            string desarrollo = "<html>" +
                "<head>" +
                "<style>" + css + "</style>" +
                "</head>" +
                "<body>" +
                 "<br>" +
                 "<br>" +
                      "<table>" +
                          "<CAPTION ALIGN=top> DATOS PERSONALES </CAPTION>" +
                          "<tr>" +
                              "<th> IMAGEN </th>" +
                              "<th> NOMBRE </th>" +
                              "<th> APELLIDO </th>" +
                              "<th> DPI </th>" +
                              "<th> DATOS PERSONALES </th>" +
                              "<th> HABILIDADES y HOBBIES</th>" +
                              "<th> DATOS LABORALES </th>" +
                          "</tr>" +
                          "<tr>" +
                              "<td><div align='center'><img src='C:\\tmp\\DatosCV\\imagen/pp.jpg' width='200px;' height='200px'></div></td>" +
                              "<td>" + nombre + "</td>" +
                              "<td>" + apellido + "</td>" +
                              "<td>" + dpi + "</td>" +
                              "<td>" +
                                  "<a href='personal.html'>Informacion Personal</a></td>" +
                              "<td>" +
                                 "<a href='habilidad.html'>Habilidad y Pasatiempos</a></td>" +
                              "<td>" +
                                  "<a href='laboral.html'>Informacion Laboral</a></td>" +
                          "</tr>" +
                    "</table>" +
                    "</body>" +
                    "</html>";

            string personales = "<html>" +
               "<head>" +
               "<style>" + css + "</style>" +
               "</head>" +
               "<body>" +
                "<br>" +
                "<a href='principal.html'>Regresar</a>" +
                "<br>" +
                "<hr>" +
                "<table>" +
                    "<h1>INFORMACION PERSONAL</h1>" +
                    "<hr>" +
                    "<br>" +
                    "<tr>" +
                        "<th>Lugar de nacimiento</th>" +
                        "<th>Fecha de nacimiento</th>" +
                        "<th>Nacionalidad</th>" +
                        "<th>Edad</th>" +
                        "<th>NIT</th>" +
                        "<th>Estado Civil</th>" +
                        "<th>Direccion</th>" +
                        "<th>Telefono</th>" +
                        "<th>Profesion</th>" +
                    "</tr>" +
                     "<tr> " +
                           "<td>" + lugar + "</td>" +
                           "<td>" + fechanaci + "</td>" +
                           "<td>" + nacionalidad + "</td>" +
                            "<td>" + edad + "</td>" +
                           "<td>" + nit + "</td>" +
                           "<td>" + estado + "</td>" +
                            "<td>" + direccion + "</td>" +
                           "<td>" + telefono + "</td>" +
                           "<td>" + profesion + "</td>" +
                    "</tr>" +
                   "</table>" +
                   "</body>" +
                   "</html>";

            string habilidades = "<html>" +
                "<head>" +
                "<style>" + css + "</style>" +
                "</head>" +
                "<body>" +
                 "<a href='principal.html'>Regresar</a>" +
                 "<ol>" +
                        "<p>HABILIDADES REGISTRADOS</p>" +
                        "<hr>" +
                         "<li><strong>" + String.Join("\n", arreglo[0]) + "</strong></li>" +
                         "<li><strong>" + String.Join("\n", arreglo[1]) + "</strong></li>" +
                         "<li><strong>" + String.Join("\n", arreglo[2]) + "</strong></li>" +
                    "</ol>" +
                    "<ul>" +
                        "<p>HOBBIES REGISTRADOS</p>" +
                        "<hr>" +
                        "<li><strong>" + String.Join("\n", arreglo1[0]) + "</strong></li>" +
                        "<li><strong>" + String.Join("\n", arreglo1[1]) + "</strong></li>" +
                        "<li><strong>" + String.Join("\n", arreglo1[2]) + "</strong></li>" +
                    "</ul>" +
                "</body>" +
                "</html>";

            string laborales = "<html>" +
                "<head>" +
                "<style>" + css + "</style>" +
                "</head>" +
                "<body>" +
                "<br>" +
                "<hr>" +
                "<a href='principal.html'>Regresar</a>" +
                "<h2>INFORMACION LABORAL</h2>" +
                "<hr>" +
                "<dl>" +
                       "<dt><strong>" + String.Join("\n", arreglo2[0]) + "</strong></li>" +
                       "<dt><strong>" + String.Join("\n", arreglo2[1]) + "</strong></dt>" +
                       "<dt><strong>" + String.Join("\n", arreglo2[2]) + "</strong></dt>" +
                "</dl>" +
                "<hr>" +
                "</body>" +
                "</html>";


            File.WriteAllText("C:\\tmp\\DatosCV\\" + "principal" + ".html", desarrollo);
            File.WriteAllText("C:\\tmp\\DatosCV\\" + "personal" + ".html", personales);
            File.WriteAllText("C:\\tmp\\DatosCV\\" + "habilidad" + ".html", habilidades);
            File.WriteAllText("C:\\tmp\\DatosCV\\" + "laboral" + ".html", laborales);

            File.WriteAllText("C:\\tmp\\DatosCV\\" + "estilo" + ".css", css);

            string text = "Nombre: " + nombre + " Apellido: " + apellido + " DPI: " + dpi + " Lugar de nacimiento: " + lugar + " Fecha de nacimiento: " + fechanaci + " Nacionalidad: " + nacionalidad + " Edad: " + edad +
            " NIT: " + nit + " Estado civil: " + estado + " Direccion: " + direccion + " Telefono: " + telefono + " Profesion: " + profesion + arreglo[0] + " Habilidad: " + arreglo[1] + " Habilidad: " + arreglo[2] +
            " Hobbie: " + arreglo1[0] + " Hobbie: " + arreglo1[1] + " Hobbie: " + arreglo1[2] + " Laboral: " + arreglo2[0] + " Laboral: " + arreglo2[1] + " Laboral: " + arreglo2[2];

            File.WriteAllText("C:\\tmp\\DatosCV\\Registro.txt", text);

            Console.WriteLine("Desea anadir datos de otra persona? si/ no");
            string agregar = Console.ReadLine();
            switch (agregar.ToLower())
            {
                case "si":
                    goto Inicio;
                case "no":
                    Console.WriteLine("Presione una tecla para salir...");
                    break;
            }
            Console.ReadLine();
        }


    }
}