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

string[] NombreProducto = new string[10];
double[] PrecioProducto = new double[10];
int[] CantidadProducto = new int[10];
int[,] registroVentas = new int [10, 3];
int TotalVendido = 0;
int opcion= 0;

Console.WriteLine("Bienvenido al sistema de registro de ventas");

Console.WriteLine("==========Menú==========\n 1. Registrar productos\n 2. Mostrar productos\n 3. Calcular total vendido\n 4. Mostrar producto más vendido\n 5. Mostrar promedio de ventas\n 6. Salir");

try
{
    Console.WriteLine("Introdizca la opcion que desea realizar");
    opcion=int.Parse(Console.ReadLine()!);
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Ocurrió un error: {ex.Message}");
    Console.ResetColor();
}
switch (opcion)
{
    case 1:
        // Código para registrar productos
        break;
    case 2:
        // Código para mostrar productos
        break;
    case 3:
        // Código para calcular total vendido
        break;
    case 4:
        // Código para mostrar producto más vendido
        break;
    case 5:
        // Código para mostrar promedio de ventas
        break;
    case 6:
        Console.WriteLine("Saliendo del programa...");
        break;
}
/*Integrante 2 — Entrada de datos
Programar el ingreso de información.
Validar datos.*/

/*Integrante 3 — Procesamiento
Realizar cálculos y estadísticas.*/

/*Integrante 4 — Salida y pruebas
Mostrar reportes.
Probar el sistema y corregir errores.*/

