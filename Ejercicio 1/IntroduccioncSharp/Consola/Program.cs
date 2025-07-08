using Consola.Ejercicios;
using Consola.Utils;

namespace Consola
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] notas = new int[args.Length];

            for (int i = 0; i < args.Length; i++)
            {
                notas[i] = int.Parse(args[i]);
            }

            SegundoEjercicio segundoEjercicio = new SegundoEjercicio(notas);

            Console.WriteLine(segundoEjercicio.ContarAprobados());

            //PrimerEjercicio ejercicio = new PrimerEjercicio();
            //DateTime fecha = ejercicio.PedirDatosNacimiento();
            //double edadEnAnios = ejercicio.CalcularEdad(fecha);
            //ejercicio.VerificarEdad(edadEnAnios);

            //Console.WriteLine(arg[0]);
            //Prueba prueba = new Prueba();
            //Console.WriteLine(prueba.GetValor());

            //PruebaBiz pruebaBiz = new PruebaBiz();
            //Console.WriteLine(pruebaBiz.GetValorBiz());
        }
    }
}