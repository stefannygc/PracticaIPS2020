using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaIPS
{
    class Program
    {
        static Paciente paciente;
        static List<Paciente> pacientes = new List<Paciente>();
        static PacienteService pacienteService = new PacienteService();
        static void Main(string[] args)
        {
            Menu();

        }
        public static void Menu()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("\n******* Menu de IPS *******");
                Console.WriteLine(" 1. Registrar");
                Console.WriteLine(" 2. BuscarPaciente");
                Console.WriteLine(" 3. Modificar");
                Console.WriteLine(" 4. Consultar");
                Console.WriteLine(" 5. Eliminar");
                Console.WriteLine(" 6. Salir");

                Console.WriteLine("**************************************");

                Console.Write("\n DIGITE UNA OPCION: "); opcion = Int32.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Registrar(); break;
                    case 2: BuscarPaciente(); break;
                    case 3: Modificar(); break;
                    case 4: Consultar(); break;
                    case 5: Eliminar(); break;
                    case 6: Console.Write("\n Presione enter para salir..."); Console.ReadKey(); break;
                    default: Console.WriteLine("\n Numero fuera de rango intente de nuevo..."); break;
                }
            } while (opcion != 3);
        }
        public static void Registrar()
        {
            string mensaje;
            Paciente paciente = new Paciente();
            Console.WriteLine("Digite identificacion: ");
            paciente.Identificacion = Console.ReadLine();
            Console.WriteLine("Digite numero Liquidacion: ");
            paciente.NumLiquidacion = Console.ReadLine();
            Console.WriteLine("Digite Tipo de Afiliacion contributivo/Subsidiado :  ");
            paciente.TipoAfiliacion = Console.ReadLine();
            Console.WriteLine("Digite Salario que recibe:  ");
            paciente.Salario = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Valor del Servicio: ");
            paciente.ValorServicio = double.Parse(Console.ReadLine());
            paciente.CalcularTarifa(paciente);
            Console.WriteLine(paciente.CuotaModeradora);
            mensaje = pacienteService.Guardar(paciente);
            pacientes.Add(paciente);
            Console.Write("\n Pulse enter para continuar...");
            Console.ReadKey();
           
            
        }

        public static void BuscarPaciente()
        {
            string identificacion;
            Console.WriteLine($"\n Digite identificacion : "); identificacion = Console.ReadLine();
            paciente = pacienteService.Buscar(identificacion);
            if (paciente == null)
            {
                Console.WriteLine($"\n el numero de identificacion[{identificacion}] no existe");
            }
            else
            {

                Console.WriteLine("\n informacion de pacientes");
                Console.WriteLine("\n ******************");
                Console.WriteLine($" Identificacion: {paciente.Identificacion}");
                Console.WriteLine($" Numero de liquidacion: {paciente.NumLiquidacion}");
                Console.WriteLine($" Tipo de afiliacion[Contributivo / Subsidiado]:{paciente.TipoAfiliacion} ");
                Console.WriteLine($" Salario: {paciente.Salario}");
                Console.WriteLine($" Valor de Servicio: {paciente.ValorServicio}");
                Console.WriteLine($" Tarifa: {paciente.CuotaModeradora}");
                Console.WriteLine(" ***************************");

            }
            Console.Write("\n Pulse enter para continuar......"); Console.ReadKey();


        }
        public static void Modificar()
        {
            Paciente paciente = new Paciente();
            Console.WriteLine("Digite la identificacion a modificar :");
            paciente.Identificacion = Console.ReadLine();
            if (pacienteService.Buscar(paciente.Identificacion) != null)
            {
                Console.WriteLine("Digite identificacion a modificar:  ");
                paciente.Identificacion = Console.ReadLine();
                Console.WriteLine("Digite numero de Liquidacion a modificar:  ");
                paciente.NumLiquidacion = Console.ReadLine();
                Console.WriteLine("Digite Tipo de Afiliacion contributivo/Subsidiado a modificar:  ");
                paciente.TipoAfiliacion = Console.ReadLine();
                Console.WriteLine("Digite Salario que recibe a modificar:  ");
                paciente.Salario = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Valor del Servicio a modificar:  ");
                paciente.ValorServicio = double.Parse(Console.ReadLine());
                paciente.CalcularTarifa(paciente);
                string mensaje = pacienteService.Modificar(paciente);
                Console.WriteLine(mensaje);
                Menu();

            }
            Console.ReadKey();
        }
        public static void Eliminar()
        {
            ConsoleKeyInfo continuar;
            Console.WriteLine("Digite la identificacion que desea eliminar :");
            string identificacion = Console.ReadLine();
            string mensajeEliminar = pacienteService.Eliminar(identificacion);
            Console.WriteLine(mensajeEliminar);
            continuar = Console.ReadKey();
        }

        public static void Consultar()
        {
            List<Paciente> personas = pacienteService.Consultar();
            if (personas.Count == 0)
            {
                Console.WriteLine("\n No hay pacientes registrados");
            }
            else
            {
                foreach (var itemPaciente in pacientes)
                {
                    Console.WriteLine();
                    Console.WriteLine("\n Cosulta de Persona");
                    Console.WriteLine("\n ******************");
                    Console.WriteLine($" Identificacion: {itemPaciente.Identificacion}");
                    Console.WriteLine($" Numero de liquidacion: {itemPaciente.NumLiquidacion}");
                    Console.WriteLine($" Tipo de Afiliacion contributivo/Subsidiado: {itemPaciente.TipoAfiliacion}");
                    Console.WriteLine($" Salario: {itemPaciente.Salario}");
                    Console.WriteLine($" Valor de Servicio: {itemPaciente.ValorServicio}");
                    Console.WriteLine($" Tarifa: {itemPaciente.CuotaModeradora}");
                    Console.WriteLine(" ***************************");
                }
            }
            Console.WriteLine("\n Pulse enter para continuar...."); Console.ReadKey();



        }
    }
}
