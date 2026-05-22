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

Console.WriteLine("Bienvenido al sistema de registro de ventas");

Console.WriteLine("==========Menú==========");
Console.WriteLine("1. Registrar productos\n 2.");
/*Integrante 2 — Entrada de datos
Programar el ingreso de información.
Validar datos.*/

/*Integrante 3 — Procesamiento
Realizar cálculos y estadísticas.*/

/*Integrante 4 — Salida y pruebas
Mostrar reportes.
Probar el sistema y corregir errores.*/

