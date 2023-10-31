using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class Pantallas
    {
        public static float[] registrar = new float [300];
        public static int contador = 0; 
        public static int pantallaPrincipal()
        {
            string texto = "================================\n" +
                "Casos con arreglos\n" +
                "================================\n" +
                "1: Registrar notas\n" +
                "2: Hallar la nota mayor\n" +
                "3: Hallar la nota menor\n" +
                "4: Encontrar una nota\n" +
                "5: Modificar una nota\n" +
                "6: Ver notas registradas\n" +
                "7: Salir\n"+
                "================================\n";
                
            Console.Write(texto);
            return Operaciones.getEntero("Ingresa una opción: ",texto);
        }
        public static int registrarNota()
        {
            string texto = "================================\n" +
                "Registrar una nota\n" +
                "================================\n";
            
            Console.Write(texto);
            float ingreseNota = Operaciones.getDecimal("Ingrese una nota: ");

            if (contador == 300)
            {
                Console.WriteLine("LA LISTA YA ESTA LLENA");
            }

            registrar [contador] = ingreseNota;
            contador++;
            
            string texto2 = "================================\n" +
                "1: Registrar otra nota\n" +
                "2: Regresar\n";

            Console.Write(texto2);
            int opcion = Operaciones.getEntero("Ingrese una opcón: ",texto);
            if (opcion == 2) return 0;
            return opcion;
        }
        public static int notaMayor()
        {
            float mayor = registrar[0];
            int posicionMayor = 0;
            for (int i = 0; i < contador; i++)
            {
                if (registrar[i] > mayor)
                {
                    mayor = registrar[i];
                    posicionMayor = i;
                }
            }
            
            float ingreseNota = registrar[posicionMayor];

            string texto = "================================\n" +
                "La nota mayor\n"+
                "================================\n" +
                "La nota mayor es: " + ingreseNota + "\n";
            
            Console.Write(texto);
            
            for (int i = 0; i < contador; i++)
            {
                if (i == posicionMayor)
                {
                    Console.Write("[" + registrar[i] + "] ");
                }
                else
                {
                    Console.Write(registrar[i] + " ");
                }
            }
            Console.WriteLine();
            string texto2 = "================================\r\n" +
                "1: Regresar";
            Console.WriteLine(texto2);

            int opcion = Operaciones.getEntero("Ingrese una opcón: ", texto);
            if (opcion == 1) return 0;
            return opcion;
        }
        public static int notaMenor()
        {
            float menor = registrar[0];
            int posicionMenor = 0;
            for (int i = 0; i < contador; i++)
            {
                if (registrar[i] < menor)
                {
                    menor = registrar[i];
                    posicionMenor = i;
                }
            }

            float ingreseNota = registrar[posicionMenor];

            string texto = "================================\n" +
                "La nota menor\n" +
                "================================\n" +
                "La nota menor es: " + ingreseNota + "\n";

            Console.Write(texto);

            for (int i = 0; i < contador; i++)
            {
                if (i == posicionMenor)
                {
                    Console.Write("[" + registrar[i] + "] ");
                }
                else
                {
                    Console.Write(registrar[i] + " ");
                }
            }
            Console.WriteLine();
            string texto2 = "================================\r\n" +
                "1: Regresar";
            Console.WriteLine(texto2);

            int opcion = Operaciones.getEntero("Ingrese una opcón: ", texto);
            if (opcion == 1) return 0;
            return opcion;
        }
        public static int buscarNota()
        {
            string texto = "================================\n" +
                "Notas Registradas\n" +
                "================================\n";
            Console.Write(texto);
            if (contador == 0)
            {
                Console.WriteLine("No hay ningun número registrado");
            }
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(i + " -> " + registrar[i]);
            }
            string texto2 = "================================\n" +
               "1: Regresar\n";
            Console.Write(texto2);
            int opcion = Operaciones.getEntero("Ingrese una opción: ", texto);
            if (opcion == 1) return 0;
            return opcion;


        } 
        public static int notasRegistradas()
        {
            string texto = "================================\n" +
                "Notas Registradas\n" +
                "================================\n";
            Console.Write(texto);
            if (contador ==0)
            {
                Console.WriteLine("No hay ningun número registrado");
            }
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(i + " -> " + registrar [i]);
            } 
             string texto2 = "================================\n"+
                "1: Regresar\n";
            Console.Write(texto2);
            int opcion = Operaciones.getEntero("Ingrese una opción: ", texto);
            if (opcion == 1) return 0;
            return opcion;
        }
        public static int modificarNota()
        {
            
            string texto = "================================\r\n" +
                "Modificar nota\r\n" +
                "================================\r\n" +
                "Ingrese la posición: 3\r\n" +
                "Ingrese el nuevo valor: 19\r\n" +
                "================================\r\n" +
                "Antes:\r\n" +
                "15 16 18 [10] 12 15 13\r\n" +
                "Después:\r\n" +
                "15 16 18 [19] 12 15 13\r\n" +
                "================================\r\n" +
                "1: Regresar\n";
            Console.Write(texto);
            int opcion = Operaciones.getEntero("Ingrese una opción: ", texto);
            if (opcion == 1) return 0;
            return opcion;
        }
    }
}
