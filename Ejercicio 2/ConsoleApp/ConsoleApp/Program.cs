using System.Text.RegularExpressions;

namespace ConsoleApp
{
    public class Program
    {
        static void Main()
        {
            Console.Title = "Academia de Aventureros - Formulario de Ingreso";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
==============================
    ACADEMIA DE AVENTUREROS
==============================
¡Bienvenido, valiente! Antes de comenzar tu viaje épico,
debes registrar tus datos en el códice de la hermandad.
");
            Console.ResetColor();

            string nombre = LeerNombre();
            int edad = LeerEdad();
            string dni = LeerDNI();
            string email = LeerEmail();
            DateTime nacimiento = LeerFechaNacimiento(edad);
            string clase = ElegirClase();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n*** Ficha de Aventurero Creada con Éxito ***\n");
            Console.ResetColor();

            Console.WriteLine($"👤 Nombre: {nombre}");
            Console.WriteLine($"📅 Edad: {edad}");
            Console.WriteLine($"🆔 DNI: {dni}");
            Console.WriteLine($"📧 Correo: {email}");
            Console.WriteLine($"🎂 Nacimiento: {nacimiento:dd/MM/yyyy}");
            Console.WriteLine($"🛡️ Clase: {clase}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPrepárate, tu aventura está por comenzar...");
            Console.ResetColor();
        }

        static string LeerNombre()
        {
            while (true)
            {
                Console.Write("👤 ¿Cuál es tu nombre completo?: ");
                string nombre = Console.ReadLine().Trim();
                if (!string.IsNullOrEmpty(nombre) && Regex.IsMatch(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
                    return nombre;
                Console.WriteLine("Ese nombre no es digno de un héroe. Intenta nuevamente.");
            }
        }

        static int LeerEdad()
        {
            while (true)
            {
                Console.Write("📅 ¿Qué edad tienes?: ");
                if (int.TryParse(Console.ReadLine(), out int edad) && edad > 0 && edad <= 120)
                    return edad;
                Console.WriteLine("Esa edad no parece real. Vuelve a intentarlo.");
            }
        }

        static string LeerDNI()
        {
            while (true)
            {
                Console.Write("🆔 Tu número de identificación en el reino (DNI): ");
                string dni = Console.ReadLine().Trim();
                if (Regex.IsMatch(dni, @"^\d{7,8}$"))
                    return dni;
                Console.WriteLine("Eso no parece un número válido del reino.");
            }
        }

        static string LeerEmail()
        {
            while (true)
            {
                Console.Write("📧 Deja tu dirección de cuervopostal (email): ");
                string email = Console.ReadLine().Trim();
                if (Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    return email;
                Console.WriteLine("Ese cuervopostal no vuela bien. Revisa el formato.");
            }
        }

        static DateTime LeerFechaNacimiento(int edad)
        {
            while (true)
            {
                Console.Write("🎂 Fecha de nacimiento (dd/mm/aaaa): ");
                string entrada = Console.ReadLine().Trim();

                if (DateTime.TryParseExact(entrada, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fecha))
                {
                    int edadCalculada = CalcularEdad(fecha);
                    if (edadCalculada == edad)
                        return fecha;
                    else
                        Console.WriteLine($"La edad declarada no concuerda con el ciclo lunar de tu nacimiento. Edad real: {edadCalculada}");
                }
                else
                {
                    Console.WriteLine("Eso no es una fecha válida del calendario real.");
                }
            }
        }

        static int CalcularEdad(DateTime nacimiento)
        {
            var hoy = DateTime.Today;
            int edad = hoy.Year - nacimiento.Year;
            if (nacimiento > hoy.AddYears(-edad)) edad--;
            return edad;
        }

        static string ElegirClase()
        {
            Console.WriteLine("\n🛡️ Elige tu clase de aventurero:");
            Console.WriteLine("1. Guerrero");
            Console.WriteLine("2. Mago");
            Console.WriteLine("3. Arquero");
            Console.WriteLine("4. Sanador");

            while (true)
            {
                Console.Write("➡️ Ingrese el número de tu elección: ");
                string opcion = Console.ReadLine().Trim();

                return opcion switch
                {
                    "1" => "Guerrero",
                    "2" => "Mago",
                    "3" => "Arquero",
                    "4" => "Sanador",
                    _ => "Opción no válida. Intenta de nuevo."
                } is string clase && clase != "Opción no válida. Intenta de nuevo." ? clase : null;
            }
        }
    }
}