/*Ejercicio: Sistema de Registro de Ventas usando Arreglos

Contexto

Una tienda de tecnología desea registrar las ventas realizadas durante una semana.
El sistema será desarrollado en equipos de 4 estudiantes utilizando arreglos en C#.

Objetivo del ejercicio

Desarrollar un programa que permita almacenar y procesar información de ventas utilizando arreglos unidimensionales y bidimensionales.

Integrantes del equipo

Cada integrante tendrá un rol específico:*/

/*Integrante 1 — Diseño de datos
Crear los arreglos.
Definir variables y arreglos.*/

/*Integrante 2 — Entrada de datos
Programar el ingreso de información.
Validar datos.*/
//Usar arreglos para almacenar:
//Nombre del producto
//Precio
//Cantidad vendida
//Debe permitir registrar mínimo 10 productos.//

        string[] dias = new string[7] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
        double[] ventas = new double[7];
        try
        {
            for (int i = 0; i < dias.Length; i++)
            {
                Console.WriteLine("Hoy es el dia " + dias[i]);
                Console.WriteLine("Vendio algo el dia de hoy? (s/n)");
                string rsp = Console.ReadLine();
                if (rsp.ToLower() == "s")
                {
                
                Console.WriteLine("Ingrese el nombre del producto vendido: ");
                string producto = Console.ReadLine();
                Console.WriteLine("Ingrese el precio del producto: ");
                double precio = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad vendida: ");
                double cantidad = double.Parse(Console.ReadLine());
                Console.WriteLine("¿Desea registrar otra venta el dia de hoy? (s/n)");
                string respuesta = Console.ReadLine();
                ventas[i] += precio * cantidad;
                while (respuesta.ToLower() == "s")
                {
                    Console.WriteLine("Ingrese el nombre del producto vendido: ");
                    producto = Console.ReadLine();
                    Console.WriteLine("Ingrese el precio del producto: ");
                    precio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad vendida: ");
                    cantidad = double.Parse(Console.ReadLine());
                    ventas[i] += precio * cantidad;
                    Console.WriteLine("¿Desea registrar otra venta el dia de hoy? (s/n)");
                    respuesta = Console.ReadLine();
                }
                }
                else
                {
                    Console.WriteLine("No se registraron ventas el dia " + dias[i]);
                }

            }

            double totalSemana = 0;
            for (int i = 0; i < ventas.Length; i++)
                totalSemana += ventas[i];
            Console.WriteLine($"Total de ventas de la semana: {totalSemana:0.00}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Entrada no válida. Por favor, ingrese un número.");
        }
        
    

   
    








/*Integrante 3 — Procesamiento
Realizar cálculos y estadísticas.*/

/*Integrante 4 — Salida y pruebas
Mostrar reportes.
Probar el sistema y corregir errores.*/

