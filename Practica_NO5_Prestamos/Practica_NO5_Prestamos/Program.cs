using System;
using System.Runtime.CompilerServices;
using Practica_NO5_Prestamos.clases;

internal class Program
{
    static List<Cliente> clientes = new List<Cliente>();
    static List<Prestamos> prestamos = new List<Prestamos>();
    static Prestamos pres;
    private static void Main(string[] args)
    {
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("\"\\n--- Menú Principal ---\"");
            Console.WriteLine("1. Gestion de Cliente");
            Console.WriteLine("2. Gestion de Prestamos");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Seleccione una opción: ");
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    MenuGestionCliente();
                    break;
                case "2":
                    MenuGestionPrestamos();
                    break;
                case "0":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción incorrecta:");
                    break;
            }
        }
    }

    // Submenu para la gestión de clientes
    static void MenuGestionCliente()
    {
        bool volver = false;
        while (!volver)
        {
            Console.WriteLine("\n--- Gestión de Cliente ---");
            Console.WriteLine("1. Agregar Cliente");
            Console.WriteLine("2. Buscar Cliente");
            Console.WriteLine("3. Editar Cliente");
            Console.WriteLine("4. Eliminar Cliente");
            Console.WriteLine("5. Lista Clientes");
            Console.WriteLine("0. Volver al menú principal");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    AgregarCliente();
                    break;
                case "2":
                    BuscarCliente();
                    break;
                case "3":
                    EditarCliente();
                    break;
                case "4":
                    EliminarCliente();
                    break;
                case "5":
                    ListaClientes();
                    break;
                case "0":
                    volver = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    // Submenu para la gestión de préstamos
    static void MenuGestionPrestamos()
    {
        bool volver = false;
        while (!volver)
        {
            Console.WriteLine("\n--- Gestión de Prestamo ---");
            Console.WriteLine("1. Agregar Prestamo");
            Console.WriteLine("2. Buscar Prestamo");
            Console.WriteLine("3. Editar Prestamo");
            Console.WriteLine("4. Eliminar Prestamo");
            Console.WriteLine("5. Lista Prestamos");
            Console.WriteLine("0. Volver al menú principal");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    AgregarPrestamo();
                    break;
                case "2":
                    BuscarPrestamo();
                    break;
                case "3":
                    EditarPrestamo();
                    break;
                case "4":
                    EliminarPrestamo();
                    break;
                case "5":
                    ListaPrestamos();
                    break;
                case "0":
                    volver = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void AgregarCliente()
    {
        Cliente clien = new Cliente();
        Console.WriteLine("\n--- Agregar Cliente ---");
        // Control de excepciones para el ID del cliente
        try
        {
            Console.Write("Ingrese ID del cliente: ");
            clien.Idcliente = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            
        }
        Console.Write("Ingrese nombre del cliente: ");
        clien.Nombre = Console.ReadLine();
        Console.Write("Ingrese apellido del cliente: ");
        clien.Apellido = Console.ReadLine();
        Console.Write("Ingrese teléfono del cliente: ");
        clien.Telefono = Console.ReadLine();
        Console.Write("Ingrese correo del cliente: ");
        clien.Correo = Console.ReadLine();

        clientes.Add(clien);
        Console.WriteLine("Cliente agregado exitosamente.");
    }

    static void BuscarCliente()
    {
        Console.WriteLine("\n--- Buscar Cliente ---");
        Console.Write("Ingrese ID del cliente a buscar: ");
        int id = int.Parse(Console.ReadLine());
        Cliente? cliente = clientes.FirstOrDefault(c => c.Idcliente == id);
        if (cliente != null)
        {
            Console.WriteLine(cliente.ToString());
        }
        else
        {
            Console.WriteLine("Cliente no encontrado.");
        }
    }

    static void EditarCliente()
    {
        Console.WriteLine("Ingrese el Id del cliente a editar: ");
        int id = int.Parse(Console.ReadLine());
        Cliente cliente = clientes.FirstOrDefault(c => c.Idcliente == id);
        if (cliente != null)
        {
            Console.Write("Ingrese nombre del cliente: ");
            cliente.Nombre = Console.ReadLine();
            Console.Write("Ingrese apellido del cliente: ");
            cliente.Apellido = Console.ReadLine();
            Console.Write("Ingrese teléfono del cliente: ");
            cliente.Telefono = Console.ReadLine();
            Console.Write("Ingrese correo del cliente: ");
            cliente.Correo = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Cliente no encontrado.");
        }
    }

    static void EliminarCliente() 
    {
        Console.WriteLine("Ingrese el Id del cliente a eliminar: ");
        int id= int.Parse(Console.ReadLine());
        Cliente? cliente = clientes.FirstOrDefault(c => c.Idcliente == id);

        if (cliente != null)
        {
            clientes.Remove(cliente);
            Console.WriteLine("Cliente eliminado exitosamente.");
        }
        else 
        {
            Console.WriteLine("Cliente no encontrado.");
        }
    }

    static void ListaClientes()
    {
        Console.WriteLine("\n--- Lista de Clientes ---");
        if (clientes.Count == 0)
        {
            Console.WriteLine("No hay clientes registrados.");
        }
        else
        {
            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente.ToString());
            }
        }
    }

    // Metodos de gestion de Prestamos
    static void AgregarPrestamo()
    {
        Console.WriteLine("\n--- Agregar Prestamo ---");
        Console.WriteLine("Tipo: 1) Prestamo Personal  2) Prestamo Hipotecario");
        string tipo = Console.ReadLine();

        switch (tipo) 
        {
            case "1":
                pres = new PrestamoPersonal();
                Console.WriteLine("Referencioa personal: ");
                ((PrestamoPersonal)pres).ReferenciaPersonal = Console.ReadLine();
                break;

            case "2":
                pres = new PrestamoHipotecario();
                Console.WriteLine("Tipo de bien: ");
                ((PrestamoHipotecario)pres).TipoBien = Console.ReadLine();
                // Control de excepciones para el monto del bien
                try
                {
                    Console.WriteLine("Monto del bien: ");
                    ((PrestamoHipotecario)pres).MontoBien = double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Numero de registro: ");
                ((PrestamoHipotecario)pres).NumeroRegistro = Console.ReadLine();
                Console.WriteLine("Direccion: ");
                ((PrestamoHipotecario)pres).Direccion = Console.ReadLine();
                break;

            default:
                Console.WriteLine("Tipo inválido.");
                return;
        }

        try
        {
            Console.WriteLine("Ingrese el codigo del prestamo: ");
            pres.CodigoPrestamo = int.Parse(Console.ReadLine());
            Console.WriteLine("ID del cliente: ");
            int id = int.Parse(Console.ReadLine());
            Cliente clienteEncontrado = clientes.FirstOrDefault(c => c.Idcliente == id);
            if (clienteEncontrado == null)
            {
                Console.WriteLine("Cliente no encontrado. Asegúrese de que el cliente exista antes de agregar un prestamo.");
                return;
            }
            pres.Cliente = clienteEncontrado;
            Console.WriteLine("Fecha de Solicitud (YYYY-MM-DD): ");
            pres.FechaSolicitud = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Año de Aprobación: ");
            pres.AnioAprobacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Monto Solicitado: ");
            pres.MontoSolicitud = double.Parse(Console.ReadLine());
            Console.WriteLine("Monto Aprobado: ");
            pres.MontoAprobado = double.Parse(Console.ReadLine());
            Console.WriteLine("Plazo (en # de meses): ");
            pres.Plazo = int.Parse(Console.ReadLine());

            prestamos.Add(pres);
            Console.WriteLine("Prestamo agregado exitosamente.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }
    }

    static void BuscarPrestamo()
    {
        Console.WriteLine("\n--- Buscar Prestamo ---");
        Console.Write("Ingrese el codigo del prestamo a buscar: ");
        int codigo = int.Parse(Console.ReadLine());
        Prestamos? prestamo = prestamos.FirstOrDefault(p => p.CodigoPrestamo == codigo);
        if (prestamo != null)
        {
            Console.WriteLine(prestamo.ToString());
        }
        else
        {
            Console.WriteLine("Prestamo no encontrado.");
        }
    }

    static void EditarPrestamo()
    {
        Console.WriteLine("Ingrese el codigo del prestamo a editar: ");
        int codigo = int.Parse(Console.ReadLine());
        Prestamos? prestamo = prestamos.FirstOrDefault(p => p.CodigoPrestamo == codigo);

        if (prestamo != null)
        {
            Console.WriteLine("ID del cliente: ");
            int id = int.Parse(Console.ReadLine());
            Cliente clienteEncontrado = clientes.FirstOrDefault(c => c.Idcliente == id);
            if (clienteEncontrado == null)
            {
                Console.WriteLine("Cliente no encontrado. Asegúrese de que el cliente exista antes de agregar un prestamo.");
                return;
            }
            pres.Cliente = clienteEncontrado;
            Console.WriteLine("Fecha de Solicitud (YYYY-MM-DD): ");
            pres.FechaSolicitud = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Año de Aprobación: ");
            pres.AnioAprobacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Monto Solicitado: ");
            pres.MontoSolicitud = double.Parse(Console.ReadLine());
            Console.WriteLine("Monto Aprobado: ");
            pres.MontoAprobado = double.Parse(Console.ReadLine());
            Console.WriteLine("Plazo (en # de meses): ");
            pres.Plazo = int.Parse(Console.ReadLine());

            if (prestamo is PrestamoPersonal personal)
            {
                Console.WriteLine("Referencia Personal: ");
                personal.ReferenciaPersonal = Console.ReadLine();
            }
            else if (prestamo is PrestamoHipotecario hipotecario)
            {
                Console.WriteLine("Tipo de bien: ");
                hipotecario.TipoBien = Console.ReadLine();
                Console.WriteLine("Monto del bien: ");
                hipotecario.MontoBien = double.Parse(Console.ReadLine());
                Console.WriteLine("Numero de registro: ");
                hipotecario.NumeroRegistro = Console.ReadLine();
                Console.WriteLine("Direccion: ");
                hipotecario.Direccion = Console.ReadLine();
            }
        }
        else
        {
            Console.WriteLine("Prestamo no encontrado.");
        }
    }

    static void EliminarPrestamo()
    {
        Console.WriteLine("Ingrese el codigo del prestamo a eliminar: ");
        int codigo = int.Parse(Console.ReadLine());
        Prestamos? prestamo = prestamos.FirstOrDefault(p => p.CodigoPrestamo == codigo);
        if (prestamo != null)
        {
            prestamos.Remove(prestamo);
            Console.WriteLine("Prestamo eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("Prestamo no encontrado.");
        }
    }

    static void ListaPrestamos()
    {
        Console.WriteLine("\n--- Lista de Prestamos ---");
        if (prestamos.Count == 0)
        {
            Console.WriteLine("No hay prestamos registrados.");
        }
        else
        {
            foreach (var prestamo in prestamos)
            {
                Console.WriteLine(prestamo.ToString());
            }
        }
    }
}