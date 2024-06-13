using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1.IrielVargasPinell
{
    //CLASE
    public class Clientes
    {
        //ATRIBUTOS
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }


        private static List<Clientes> clientes = new List<Clientes>();
        public static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine();
                Console.WriteLine("****Menú principal****");
                Console.WriteLine("1. Registrar cliente");
                Console.WriteLine("2. Clientes registrados");
                Console.WriteLine("3. Salir");
                Console.WriteLine("**********************");
                Console.Write("Seleccione una opción: ");
                Console.WriteLine();
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistrarCliente();
                        break;
                    case 2:
                        ClientesRegistrados();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Ingrese una opción válida.");
                        break;

                }

            } while (opcion != 3);


        }

        //METODOS
        private static void RegistrarCliente()
        {
            Console.WriteLine();
            Console.WriteLine($"****Registar de cliente****");
            Clientes cliente = new Clientes();
            Console.WriteLine("Nombre: ");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Dirección: ");
            cliente.Direccion = Console.ReadLine();
            Console.WriteLine("Teléfono: ");
            cliente.Telefono = Console.ReadLine();
            Console.WriteLine("Correo Electrónico: ");
            cliente.CorreoElectronico = Console.ReadLine();
            clientes.Add(cliente);
            Console.WriteLine("****Cliente registrado****");
            Console.WriteLine();
        }

        private static void ClientesRegistrados()
        {
            Console.WriteLine("****Clientes Registrados****");
            if (clientes.Count == 0)
            {
                Console.WriteLine("No se encontraron clientes registrados");
            }
            else
            {
                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"Nombre: {cliente.Nombre}");
                    Console.WriteLine($"Dirección: {cliente.Direccion}");
                    Console.WriteLine($"Teléfono: {cliente.Telefono}");
                    Console.WriteLine($"Correo Electrónico: {cliente.CorreoElectronico}");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}

