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

/*Integrante 3 — Procesamiento
Realizar cálculos y estadísticas.*/

/*Integrante 4 — Salida y pruebas
Mostrar reportes.
Probar el sistema y corregir errores.*/
double total = 0;

for (int i = 0; i < contador; i++)
{
    total += PrecioProducto[i] * CantidadProducto[i];
}

System.Console.WriteLine("Total vendido: " + total);



int mayor = CantidadProducto[0];
int posicion = 0;

for (int i = 1; i < contador; i++)
{
    if (CantidadProducto[i] > mayor)
    {
        mayor = CantidadProducto[i];
        posicion = i;
    }
}

System.Console.WriteLine("Producto mas vendido: " + NombreProducto[posicion]);
System.Console.WriteLine("Cantidad vendida: " + mayor);



double suma = 0;

for (int i = 0; i < contador; i++)
{
    suma = suma + (PrecioProducto[i] * CantidadProducto[i]);
}

double promedio = suma / contador;

System.Console.WriteLine("Promedio de ventas: " + promedio);