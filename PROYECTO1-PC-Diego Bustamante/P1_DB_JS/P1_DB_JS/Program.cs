using System;

class ParqueoInteligente
{
    static void Main()
    {
        // --- VARIABLES (Según especificaciones de variables simples) ---
        string nombreOperador, codigoTurno, placaVehiculo = "", nombreCliente = "";
        int capacidadParqueo, ticketsCreados = 0, ticketsCerrados = 0, tiempoSimulado = 0;
        int tipoVehiculo = 0, minutoEntrada = 0, minutosEstacionado, opcion, longitudCodigo;
        int longitudPlaca, minutosAvanzar, espaciosOcupados, espaciosDisponibles, tiempoActualVehiculo;

        double dineroRecaudado = 0.0, tarifaHora = 0.0, montoBase, multa, descuento, recargoExtremo, montoFinal;
        bool ticketActivo = false, VIP = false;

        // --- REGISTRO INICIAL ---
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=== SISTEMA DE PARQUEO SMARTPARK - REGISTRO INICIAL ===");
        Console.ResetColor();

        Console.Write("Ingrese nombre del operador: ");
        nombreOperador = Console.ReadLine();

        // Validación de código de turno (Exactamente 4 caracteres)
        do
        {
            Console.Write("Ingrese codigo de turno (4 caracteres): ");
            codigoTurno = Console.ReadLine();
            longitudCodigo = codigoTurno.Length;

            if (longitudCodigo != 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: El codigo debe ser de exactamente 4 caracteres.");
                Console.ResetColor();
            }
        } while (longitudCodigo != 4);

        // Validación de capacidad (Mínimo 10)
        do
        {
            Console.Write("Ingrese capacidad del parqueo (minimo 10): ");
            capacidadParqueo = int.Parse(Console.ReadLine());

            if (capacidadParqueo < 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: La capacidad minima permitida es 10.");
                Console.ResetColor();
            }
        } while (capacidadParqueo < 10);

        // --- MENU PRINCIPAL ---
        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n***************************************************");
            Console.WriteLine("   MENU PRINCIPAL - Reloj: " + tiempoSimulado + " min");
            Console.WriteLine("***************************************************");
            Console.ResetColor();
            Console.WriteLine("1. Crear ticket de entrada");
            Console.WriteLine("2. Registrar salida y calcular cobro");
            Console.WriteLine("3. Ver estado del parqueo");
            Console.WriteLine("4. Simular paso del tiempo");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opcion: ");

            if (!int.TryParse(Console.ReadLine(), out opcion)) opcion = 0;

            switch (opcion)
            {
                case 1:
                    // Validación de disponibilidad y ticket activo
                    if (ticketActivo)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Ya existe un vehiculo en el sistema (limite de 1 ticket).");
                        Console.ResetColor();
                    }
                    else
                    {
                        // Ingreso de datos con validación de placa
                        do
                        {
                            Console.Write("Ingrese placa (6 a 8 caracteres): ");
                            placaVehiculo = Console.ReadLine();
                            longitudPlaca = placaVehiculo.Length;

                            if (longitudPlaca < 6 || longitudPlaca > 8)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("ERROR: Placa invalida (debe tener entre 6 y 8 caracteres).");
                                Console.ResetColor();
                            }
                        } while (longitudPlaca < 6 || longitudPlaca > 8);

                        Console.Write("Tipo de vehiculo (1=Moto, 2=Auto, 3=Pickup): ");
                        tipoVehiculo = int.Parse(Console.ReadLine());

                        Console.Write("Nombre del cliente: ");
                        nombreCliente = Console.ReadLine();

                        Console.Write("¿Es cliente VIP? (true/false): ");
                        VIP = bool.Parse(Console.ReadLine());

                        minutoEntrada = tiempoSimulado;
                        ticketActivo = true;
                        ticketsCreados++;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("CONFIRMACION: Ticket creado exitosamente para placa: " + placaVehiculo);
                        Console.ResetColor();
                    }
                    break;

                case 2:
                    if (ticketActivo)
                    {
                        minutosEstacionado = tiempoSimulado - minutoEntrada;
                        montoBase = 0;
                        multa = 0;
                        descuento = 0;
                        recargoExtremo = 0;

                        // 1. Cálculo de Monto Base (Gratis primeros 15 min)
                        if (minutosEstacionado > 15)
                        {
                            if (tipoVehiculo == 1) tarifaHora = 5.0;      // Moto
                            else if (tipoVehiculo == 2) tarifaHora = 10.0; // Auto
                            else tarifaHora = 15.0;                       // Pickup

                            // Se cobra por fracción de hora
                            montoBase = (minutosEstacionado / 60.0) * tarifaHora;
                        }

                        // 2. Multa por más de 6 horas (360 min)
                        if (minutosEstacionado > 360)
                        {
                            multa = 25.0;
                        }

                        // 3. Descuento VIP (10% sobre el monto base)
                        if (VIP)
                        {
                            descuento = montoBase * 0.10;
                        }

                        montoFinal = montoBase + multa - descuento;

                        // 4. Recargo Extremo por más de 12 horas (720 min)
                        if (minutosEstacionado > 720)
                        {
                            recargoExtremo = montoFinal * 0.20;
                            montoFinal += recargoExtremo;
                        }

                        dineroRecaudado += montoFinal;
                        ticketsCerrados++;
                        ticketActivo = false;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n--- RESUMEN DE COBRO ---");
                        Console.WriteLine("Cliente: " + nombreCliente);
                        Console.WriteLine("Tiempo: " + minutosEstacionado + " min");
                        Console.WriteLine("Monto Base: Q" + Math.Round(montoBase, 2));
                        if (multa > 0) Console.WriteLine("Multa (>6h): Q" + multa);
                        if (descuento > 0) Console.WriteLine("Descuento VIP: -Q" + Math.Round(descuento, 2));
                        if (recargoExtremo > 0) Console.WriteLine("Recargo Extremo (>12h): Q" + Math.Round(recargoExtremo, 2));
                        Console.WriteLine("TOTAL A PAGAR: Q" + Math.Round(montoFinal, 2));
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: No hay ningun vehiculo registrado para salida.");
                        Console.ResetColor();
                    }
                    break;

                case 3:
                    espaciosOcupados = ticketActivo ? 1 : 0;
                    espaciosDisponibles = capacidadParqueo - espaciosOcupados;

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n--- ESTADO DEL PARQUEO ---");
                    Console.ResetColor();
                    Console.WriteLine("Capacidad Total: " + capacidadParqueo);
                    Console.WriteLine("Ocupados: " + espaciosOcupados + " | Disponibles: " + espaciosDisponibles);
                    Console.WriteLine("Recaudacion Total: Q" + Math.Round(dineroRecaudado, 2));
                    Console.WriteLine("Tickets Totales: " + ticketsCreados + " | Cerrados: " + ticketsCerrados);
                    break;

                case 4:
                    do
                    {
                        Console.Write("Minutos a avanzar (1 a 1440): ");
                        minutosAvanzar = int.Parse(Console.ReadLine());

                        if (minutosAvanzar < 1 || minutosAvanzar > 1440)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: Ingrese un tiempo valido (1 min a 24h).");
                            Console.ResetColor();
                        }
                    } while (minutosAvanzar < 1 || minutosAvanzar > 1440);

                    tiempoSimulado += minutosAvanzar;
                    Console.WriteLine("Reloj actualizado a: " + tiempoSimulado + " min");

                    // Advertencias proactivas si hay un vehículo
                    if (ticketActivo)
                    {
                        tiempoActualVehiculo = tiempoSimulado - minutoEntrada;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        if (tiempoActualVehiculo > 720)
                            Console.WriteLine("ADVERTENCIA: El vehiculo ya supero las 12 horas (Recargo Extremo)");
                        else if (tiempoActualVehiculo > 360)
                            Console.WriteLine("ADVERTENCIA: El vehiculo ya supero las 6 horas (Multa aplicada)");
                        Console.ResetColor();
                    }
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n==========================================");
                    Console.WriteLine("         INFORME FINAL DE TURNO           ");
                    Console.WriteLine("==========================================");
                    Console.ResetColor();
                    Console.WriteLine("Operador: " + nombreOperador);
                    Console.WriteLine("Codigo de Turno: " + codigoTurno);
                    Console.WriteLine("Total Recaudado: Q" + Math.Round(dineroRecaudado, 2));
                    Console.WriteLine("Tickets Atendidos: " + ticketsCerrados);
                    Console.WriteLine("Tiempo Total Simulado: " + tiempoSimulado + " min");
                    Console.WriteLine("==========================================\n");
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Opcion no valida.");
                    Console.ResetColor();
                    break;
            }

        } while (opcion != 5);
    }
}