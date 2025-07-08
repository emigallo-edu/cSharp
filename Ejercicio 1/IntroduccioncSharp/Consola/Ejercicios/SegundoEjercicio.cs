using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Consola.Ejercicios
{
    // Una profesora guarda las notas de sus alumnos en un arreglo. Cada nota es un número entre 0 y 10. Necesitás escribir un programa que:
    // Calcule el promedio de las notas.
    // Cuente cuántos alumnos aprobaron (nota mayor o igual a 6).
    // Encuentre la nota más alta y la más baja.

    public class SegundoEjercicio
    {
        private int[] notas;
        private DateTime creacion;


        buscar alguno video que hable de Poo
            preparar material de Poo con alguna ejercitacion para el viernes
        public SegundoEjercicio(int[] n)
        {
            notas = n;
        }

        public double CalcularPromedio()
        {
            int suma = 0;
            foreach (int nota in notas)
            {
                suma += nota;
            }

            return suma / notas.Length;
        }

        public int ContarAprobados()
        {
            int contador = 0;
            foreach (int nota in notas)
            {
                if (nota >= 6)
                {
                    contador++;
                }
            }
            return contador;
        }
    }



    //    const notas = [7, 4, 10, 6, 5, 8, 3];

    //    // 1. Promedio
    //    function calcularPromedio(notas)
    //    {
    //        let suma = 0;
    //        for (let nota of notas)
    //        {
    //            suma += nota;
    //        }
    //        return suma / notas.length;
    //    }

    //    // 2. Aprobados
    //    function contarAprobados(notas)
    //    {
    //        let contador = 0;
    //        for (let nota of notas)
    //        {
    //            if (nota >= 6)
    //            {
    //                contador++;
    //            }
    //        }
    //        return contador;
    //    }

    //    // 3. Nota máxima y mínima
    //    function obtenerMaximo(notas)
    //    {
    //        let max = notas[0];
    //        for (let nota of notas)
    //        {
    //            if (nota > max) max = nota;
    //        }
    //        return max;
    //    }

    //    function obtenerMinimo(notas)
    //    {
    //        let min = notas[0];
    //        for (let nota of notas)
    //        {
    //            if (nota < min) min = nota;
    //        }
    //        return min;
    //    }

    //    // Mostrar resultados
    //    console.log("Promedio:", calcularPromedio(notas));
    //console.log("Aprobados:", contarAprobados(notas));
    //console.log("Nota más alta:", obtenerMaximo(notas));
    //console.log("Nota más baja:", obtenerMinimo(notas));
}
