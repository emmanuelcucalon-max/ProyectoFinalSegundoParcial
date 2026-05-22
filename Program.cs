string[] NombreProducto = new string[10];
double[] PrecioProducto = new double[10];
int[] CantidadProducto = new int[10];
int contadorProductos = 0; 

string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
double[] ventasPorDia = new double[7]; 


int opcion = 0;


do
{
    Console.Clear();
    Console.WriteLine("Bienvenido al sistema de registro de ventas");
    Console.WriteLine("==========Menú==========");
    Console.WriteLine(" 1. Registrar productos por día");
    Console.WriteLine(" 2. Mostrar productos registrados");
    Console.WriteLine(" 3. Calcular total vendido");
    Console.WriteLine(" 4. Mostrar producto más vendido");
    Console.WriteLine(" 5. Mostrar promedio de ventas diarias");
    Console.WriteLine(" 6. Salir");
    Console.WriteLine("========================");

    try
    {
        Console.WriteLine("Introduzca la opción que desea realizar:");
        opcion = int.Parse(Console.ReadLine()!);
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Ocurrió un error: {ex.Message}");
        Console.ResetColor();
        Console.ReadKey();
        continue;
    }

    switch (opcion)
    {
        case 1: 
           
                for (int i = 0; i < dias.Length; i++)
                {
                    string rsp;
                    do
                    {
                        Console.WriteLine($"\n¿Desea registrar ventas para el día {dias[i]}? (s/n)");
                        rsp = Console.ReadLine()!.ToLower();
                        if (rsp != "s" && rsp != "n")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Respuesta no válida. Debe ingresar 's' o 'n'.");
                            Console.ResetColor();
                        }
                    } while (rsp != "s" && rsp != "n");

                    if (rsp == "s")
                    {
                        string respuesta = "s";
                        while (respuesta == "s")
                        {
                            if (contadorProductos >= 10)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("¡Alerta! Ya se alcanzó el límite máximo de 10 productos registrados.");
                                Console.ResetColor();
                                break;
                            }

                            Console.WriteLine("Ingrese el nombre del producto vendido: ");
                            NombreProducto[contadorProductos] = Console.ReadLine()!;

                            Console.WriteLine("Ingrese el precio del producto: ");
                            try
                            {
                                PrecioProducto[contadorProductos] = double.Parse(Console.ReadLine()!);
                            }
                            catch (FormatException)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Entrada no válida para el precio. Por favor, ingrese un número válido.");
                                Console.ResetColor();
                                continue; 
                            }

                            Console.WriteLine("Ingrese la cantidad vendida: ");
                            try
                            {
                                CantidadProducto[contadorProductos] = int.Parse(Console.ReadLine()!);
                            }
                            catch (FormatException)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Entrada no válida para la cantidad. Por favor, ingrese un número válido.");
                                Console.ResetColor();
                                continue; 
                            }

                            // Acumulamos el dinero de la venta en el día correspondiente
                            ventasPorDia[i] += PrecioProducto[contadorProductos] * CantidadProducto[contadorProductos];
                            
                            contadorProductos++; // Avanzamos a la siguiente posición del arreglo

                            do
                            {
                                Console.WriteLine("¿Desea registrar otra venta el día de hoy? (s/n)");
                                respuesta = Console.ReadLine()!.ToLower();
                                if (respuesta != "s" && respuesta != "n")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Respuesta no válida. Debe ingresar 's' o 'n'.");
                                    Console.ResetColor();
                                }
                            } while (respuesta != "s" && respuesta != "n");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"No se registraron ventas el día {dias[i]}");
                    }
                }
            break;

        case 2: 
            Console.WriteLine("\n--- Productos Registrados ---");
            if (contadorProductos == 0)
            {
                Console.WriteLine("No hay productos registrados aún.");
            }
            else
            {
                for (int i = 0; i < contadorProductos; i++)
                {
                    Console.WriteLine($"Producto: {NombreProducto[i]}, Precio: ${PrecioProducto[i]}, Cantidad: {CantidadProducto[i]}");
                }
            }
            break; 

        case 3: 
            double totalVendido = 0;
            for (int i = 0; i < contadorProductos; i++)
            {
                totalVendido += PrecioProducto[i] * CantidadProducto[i];
            }
            Console.WriteLine($"\nEl total de dinero vendido es: ${totalVendido}");
            break; 

        case 4: 
            if (contadorProductos == 0)
            {
                Console.WriteLine("No hay productos registrados para evaluar.");
            }
            else
            {
                int mayor = CantidadProducto[0];
                int posicion = 0;

                for (int i = 1; i < contadorProductos; i++)
                {
                    if (CantidadProducto[i] > mayor)
                    {
                        mayor = CantidadProducto[i];
                        posicion = i;
                    }
                }
                Console.WriteLine($"\nProducto más vendido: {NombreProducto[posicion]}");
                Console.WriteLine($"Cantidad total vendida: {mayor} unidades");
            }
            break; 

        case 5: 
            double sumaVentasDias = 0;
            for (int i = 0; i < 7; i++)
            {
                sumaVentasDias += ventasPorDia[i];
            }
            double promedioDiario = sumaVentasDias / 7.0;
            Console.WriteLine($"\nEl promedio de ventas diarias en la semana es de: ${promedioDiario:F2}");
            break;

        case 6:
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break; 
    }

    if (opcion != 6)
    {
        Console.WriteLine("\nPresione cualquier tecla para continuar... ");
        Console.ReadKey();
    }

} while (opcion != 6);