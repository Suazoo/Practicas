using Practica_NO4.clases;

internal class Program
{
    static List<Cliente> clientes = new List<Cliente>();
    static List<Empleado> empleados = new List<Empleado>();
    static Empleado emple;

    private static void Main(string[] args)
    {
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("\"\\n--- Menú Principal ---\"");
            Console.WriteLine("1. Gestión de Cliente");
            Console.WriteLine("2. Gestión de Empleado");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    MenuGestionCliente();
                    break;
                case "2":
                    MenuGestionEmpleado();
                    break;
                case "0":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        }

    }

    // Submenú para gestión de clientes
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
            Console.WriteLine("5. Listar Clientes");
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
                    ListarClientes();
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

    // Submenú para gestión de empleados
    static void MenuGestionEmpleado()
    {
        bool volver = false;
        while (!volver)
        {
            Console.WriteLine("\n--- Gestión de Empleado ---");
            Console.WriteLine("1. Agregar Empleado");
            Console.WriteLine("2. Buscar Empleado");
            Console.WriteLine("3. Editar Empleado");
            Console.WriteLine("4. Eliminar Empleado");
            Console.WriteLine("5. Listar Empleados");
            Console.WriteLine("0. Volver al menú principal");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarEmpleado();
                    break;
                case "2":
                    BuscarEmpleado();
                    break;
                case "3":
                    EditarEmpleado();
                    break;
                case "4":
                    EliminarEmpleado();
                    break;
                case "5":
                    ListarEmpleados();
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

    // Métodos de gestión de clientes
    static void AgregarCliente()
    {
        Cliente clien = new Cliente();
        Console.WriteLine("\n--- Agregar Cliente ---");
        Console.WriteLine("ID: ");
        clien.IdCliente = int.Parse(Console.ReadLine());
        Console.WriteLine("Nombres: ");
        clien.Nombres = Console.ReadLine();
        Console.WriteLine("Apellidos: ");
        clien.Apellidos = Console.ReadLine();
        Console.WriteLine("Dirección: ");
        clien.Direccion = Console.ReadLine();
        Console.WriteLine("Telefono: ");
        clien.Telefono = Console.ReadLine();
        Console.WriteLine("Correo Electrónico: ");
        clien.CorreoElectronico = Console.ReadLine();
        Console.WriteLine("Fecha de Registro (YYYY-MM-DD): ");
        clien.FechaRegistro = DateOnly.Parse(Console.ReadLine());

        clientes.Add(clien);
        Console.WriteLine("Cliente agregado exitosamente.");
    }

    static void BuscarCliente()
    {
        Console.WriteLine("Ingrese el ID del cliente: ");
        int id = int.Parse(Console.ReadLine());
        Cliente? cliente = clientes.FirstOrDefault(c => c.IdCliente == id);

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
        Console.WriteLine("Ingrese el ID del cliente a editar: ");
        int id = int.Parse(Console.ReadLine());
        Cliente? cliente = clientes.FirstOrDefault(c => c.IdCliente == id);

        if (cliente != null)
        {
            Console.WriteLine("Nombres: ");
            cliente.Nombres = Console.ReadLine();
            Console.WriteLine("Apellidos: ");
            cliente.Apellidos = Console.ReadLine();
            Console.WriteLine("Dirección: ");
            cliente.Direccion = Console.ReadLine();
            Console.WriteLine("Telefono: ");
            cliente.Telefono = Console.ReadLine();
            Console.WriteLine("Correo Electrónico: ");
            cliente.CorreoElectronico = Console.ReadLine();
            Console.WriteLine("Fecha de Registro (YYYY-MM-DD): ");
            cliente.FechaRegistro = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Cliente editado exitosamente.");
        }
        else
        {
            Console.WriteLine("Cliente no encontrado.");
        }
    }

    static void EliminarCliente()
    {
        Console.WriteLine("Ingrese el ID del cliente a eliminar: ");
        int id = int.Parse(Console.ReadLine());
        Cliente? cliente = clientes.FirstOrDefault(c => c.IdCliente == id);

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

    static void ListarClientes()
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

    // Métodos de gestión de empleados
    static void AgregarEmpleado()
    {
        
        Console.WriteLine("\n--- Agregar Empleado ---");
        Console.WriteLine("Tipo: 1) Por Hora  2) Por Comisión  3) Asalariado  4) Base + Comisión");
        string tipo = Console.ReadLine();

        

        switch (tipo)
        {
            case "1":
                emple = new EmpleadoPorHora();
                Console.Write("Horas Trabajadas: ");
                ((EmpleadoPorHora)emple).HorasTrabajadas = int.Parse(Console.ReadLine());
                Console.Write("Pago por Hora: ");
                ((EmpleadoPorHora)emple).PagoPorHora = double.Parse(Console.ReadLine());
                break;

            case "2":
                emple = new EmpleadoPorComision();
                Console.Write("Ventas Brutas: ");
                ((EmpleadoPorComision)emple).VentasTotales = int.Parse(Console.ReadLine());
                Console.Write("Tarifa Comisión: ");
                ((EmpleadoPorComision)emple).TarifaComision = double.Parse(Console.ReadLine());
                break;

            case "3":
                emple = new EmpleadoAsalariado();
                Console.Write("Salario Semanal: ");
                ((EmpleadoAsalariado)emple).SalarioSemanal = double.Parse(Console.ReadLine());
                break;

            case "4":
                emple = new EmpleadoBaseMasComision();
                Console.Write("Salario Base: ");
                ((EmpleadoBaseMasComision)emple).SalarioBase = double.Parse(Console.ReadLine());
                Console.Write("Ventas Brutas: ");
                ((EmpleadoBaseMasComision)emple).VentasTotales = int.Parse(Console.ReadLine());
                Console.Write("Tarifa Comisión: ");
                ((EmpleadoBaseMasComision)emple).TarifaComision = double.Parse(Console.ReadLine());
                break;

            default:
                Console.WriteLine("Tipo inválido.");
                return;
        }

        Console.WriteLine("ID: ");
        emple.IdEmpleado = int.Parse(Console.ReadLine());
        Console.WriteLine("Nombres: ");
        emple.Nombres = Console.ReadLine();
        Console.WriteLine("Apellidos: ");
        emple.Apellidos = Console.ReadLine();
        Console.WriteLine("Dirección: ");
        emple.Direccion = Console.ReadLine();
        Console.WriteLine("Telefono: ");
        emple.Telefono = Console.ReadLine();
        Console.WriteLine("Correo Electrónico: ");
        emple.CorreoElectronico = Console.ReadLine();
        Console.WriteLine("Fecha de Nombramiento (YYYY-MM-DD): ");
        emple.FechaNombramiento = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine("Número de Seguro Social: ");
        emple.NumeroSeguroSocial = Console.ReadLine();
        empleados.Add(emple);
        Console.WriteLine("Empleado agregado exitosamente.");
    }

    static void BuscarEmpleado()
    {
        Console.WriteLine("Ingrese el ID del empleado: ");
        int id = int.Parse(Console.ReadLine());
        Empleado? empleado = empleados.FirstOrDefault(e => e.IdEmpleado == id);

        if (empleado != null)
        {
            Console.WriteLine(empleado.ToString());
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }

    static void EditarEmpleado()
    {
        Console.WriteLine("Ingrese el ID del empleado a editar: ");
        int id = int.Parse(Console.ReadLine());
        Empleado? empleado = empleados.FirstOrDefault(e => e.IdEmpleado == id);

        if (empleado != null)
        {
            Console.WriteLine("Nombres: ");
            empleado.Nombres = Console.ReadLine();
            Console.WriteLine("Apellidos: ");
            empleado.Apellidos = Console.ReadLine();
            Console.WriteLine("Dirección: ");
            empleado.Direccion = Console.ReadLine();
            Console.WriteLine("Telefono: ");
            empleado.Telefono = Console.ReadLine();
            Console.WriteLine("Correo Electrónico: ");
            empleado.CorreoElectronico = Console.ReadLine();
            Console.WriteLine("Fecha de Nombramiento (YYYY-MM-DD): ");
            empleado.FechaNombramiento = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Número de Seguro Social: ");
            empleado.NumeroSeguroSocial = Console.ReadLine();

            if (empleado is EmpleadoPorHora)
            {
                Console.Write("Horas Trabajadas: ");
                ((EmpleadoPorHora)empleado).HorasTrabajadas = int.Parse(Console.ReadLine());
                Console.Write("Pago por Hora: ");
                ((EmpleadoPorHora)empleado).PagoPorHora = double.Parse(Console.ReadLine());
            }
            else if (empleado is EmpleadoPorComision)
            {
                Console.Write("Ventas Brutas: ");
                ((EmpleadoPorComision)empleado).VentasTotales = int.Parse(Console.ReadLine());
                Console.Write("Tarifa Comisión: ");
                ((EmpleadoPorComision)empleado).TarifaComision = double.Parse(Console.ReadLine());
            }
            else if (empleado is EmpleadoAsalariado)
            {
                Console.Write("Salario Semanal: ");
                ((EmpleadoAsalariado)empleado).SalarioSemanal = double.Parse(Console.ReadLine());
            }
            else if (empleado is EmpleadoBaseMasComision)
            {
                Console.Write("Salario Base: ");
                ((EmpleadoBaseMasComision)empleado).SalarioBase = double.Parse(Console.ReadLine());
                Console.Write("Ventas Brutas: ");
                ((EmpleadoBaseMasComision)empleado).VentasTotales = int.Parse(Console.ReadLine());
                Console.Write("Tarifa Comisión: ");
                ((EmpleadoBaseMasComision)empleado).TarifaComision = double.Parse(Console.ReadLine());
            }


        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }

    static void EliminarEmpleado()
    {
        Console.WriteLine("Ingrese el ID del empleado a eliminar: ");
        int id = int.Parse(Console.ReadLine());
        Empleado? empleado = empleados.FirstOrDefault(e => e.IdEmpleado == id);
        if (empleado != null)
        {
            empleados.Remove(empleado);
            Console.WriteLine("Empleado eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }

    static void ListarEmpleados()
    {
        Console.WriteLine("\n--- Lista de Empleados ---");
        if (empleados.Count == 0)
        {
            Console.WriteLine("No hay empleados registrados.");
        }
        else
        {
            foreach (var empleado in empleados)
            {
                Console.WriteLine(empleado.ToString());
            }
        }
    }

}