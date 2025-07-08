namespace Consola.Ejercicios
{
    public class PrimerEjercicio
    {
        public DateTime PedirDatosNacimiento()
        {
            Console.WriteLine("Ingresá el día del mes en el que naciste");
            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresá el mes del año en el que naciste");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresá el año en el que naciste");
            int anio = int.Parse(Console.ReadLine());

            return new DateTime(anio, mes, dia);
        }

        public double CalcularEdad(DateTime nacimiento)
        {
            DateTime hoy = DateTime.Today;
            TimeSpan edadEnMilisegundos = hoy - nacimiento;
            return edadEnMilisegundos.TotalDays / 365.25;
        }

        public void VerificarEdad(double edadEnAnios)
        {
            int edadMinimaParaIngresar = 18;
            if (edadEnAnios >= edadMinimaParaIngresar)
            {
                Console.WriteLine("Puedes ingresar al sitio web.");
            }
            else
            {
                Console.WriteLine("Lo siento, no puedes ingresar al sitio web.");
            }
        }
    }




    //function pedirDatosNacimiento()
    //{
    //    const dia = prompt("Ingresá el día del mes en el que naciste");
    //    const mes = prompt("Ingresá el mes del año en el que naciste");
    //    const anio = prompt("Ingresá el año en el que naciste");

    //    // Restamos 1 al mes porque los meses en JavaScript van de 0 a 11
    //    return new Date(anio, mes - 1, dia);
    //}

    //function calcularEdad(fechaNacimiento)
    //{
    //    const hoy = new Date();
    //    const edadEnMilisegundos = hoy - fechaNacimiento;
    //    return edadEnMilisegundos / (1000 * 60 * 60 * 24 * 365.25);
    //}

    //function verificarEdad(edadEnAnios)
    //{
    //    const edadMinimaParaIngresar = 18;
    //    if (edadEnAnios >= edadMinimaParaIngresar)
    //    {
    //        alert("Puedes ingresar al sitio web.");
    //    }
    //    else
    //    {
    //        alert("Lo siento, no puedes ingresar al sitio web.");
    //    }
    //}
}