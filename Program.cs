using biblioteca_compartida;

namespace Tp_primer_ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var admin_1 = new Administrador(1, 1);

            //Console.WriteLine(admin_1.MostrarInfo());

            //var alumno_1 = new Estudiante("1234", "juan","corrales", 1234, "juan23qgmail.com", "AV corodba 145", new DateTime(1995, 06, 4), "12345678", 0001);

            //Console.WriteLine(alumno_1.MostrarInfo());

            //var numero = GestorUsuarios.GetRandomNumber();

            //Console.WriteLine(numero);
            ////Console.WriteLine(alumno_1.MostrarInfo());


            ////r materia1 = Datos.Abrir().Materias; //--> retorna un objeto de clase maestra


            ///*
            //foreach (var curso in materia1)
            //{
            //    if (curso.Curso == 0)
            //    {

            //        Console.WriteLine("Año: Primero");
            //        Console.WriteLine("Materias: ");

            //        foreach (var mat in curso.Materias)
            //        {
            //            Console.WriteLine(mat);
            //        }

            //    }

            //}
            //*/

            //var direccion = Directorios.ObtenerDirectorio();
            //Console.WriteLine(direccion);

            Console.WriteLine("*********************************");
            var datos = Datos.Abrir();
            List<Administrador> listaAdministradores = datos.Administradores;

            var admin = new Administrador(2, 2);

            Console.WriteLine(admin.MostrarInfo());

            listaAdministradores.Add(admin);


            foreach (var item in listaAdministradores)
            {
                Console.WriteLine(item.MostrarInfo());
            }

            Datos.Guardar(datos);



        }
    }
}