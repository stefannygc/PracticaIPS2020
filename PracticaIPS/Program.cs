using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BLL.PacienteService;

namespace PracticaIPS
{
    class Program
    {

        static List<Paciente> pacientes = new List<Paciente>();
        static PacienteService service = new PacienteService();
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
                Console.WriteLine(" 2. Consulta general ");
                Console.WriteLine(" 3. Modificar");
                Console.WriteLine(" 4. Eliminar");
                Console.WriteLine(" 5. Salir");

                Console.WriteLine("**************************************");

                Console.Write("\n DIGITE UNA OPCION: "); opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Registrar(); break;
                    case 2: ConsultarConsulta(service); break;
                    case 3: Modificar(service); break;
                    case 4: Eliminar(); break;
                    case 5: Console.Write("\n Presione enter para salir..."); Console.ReadKey(); break;
                    default: Console.WriteLine("\n Numero fuera de rango intente de nuevo..."); break;
                }
            } while (opcion != 5);
        }
        public static void Registrar()

        {
            Paciente paciente;
            Console.Clear();
            string identificacion, numeroLiquidacion, tipoAfiliacion;
            decimal salario, valorServicio, Tarifa;

            Console.Write("Digite identificacion: ");
            identificacion = Console.ReadLine();

            Console.Write("Digite Tarifa: ");
            Tarifa = decimal.Parse(Console.ReadLine());

            Console.Write("Digite numero de liquidacion: ");
            numeroLiquidacion = Console.ReadLine();

            Console.Write("Digite tipo de afiliacion: ");
            tipoAfiliacion = Console.ReadLine();

            Console.Write("Digite salario devengado: ");
            salario = decimal.Parse(Console.ReadLine());

            Console.Write("Digite valor servicio de hospitalizacion: ");
            valorServicio = decimal.Parse(Console.ReadLine());




            if (tipoAfiliacion.ToLower() == "subsidiado")
            {
                paciente = new Subsidiado();
            }
            else
            {
                paciente = new Contributivo();
            }


            paciente.Identificacion = identificacion;
            paciente.Tarifa = Tarifa;
            paciente.NumLiquidacion = numeroLiquidacion;
            paciente.TipoAfiliacion = tipoAfiliacion;
            paciente.Salario = salario;
            paciente.ValorServicio = valorServicio;
            paciente.CalcularCuotaModeradora();
            pacientes.Add(paciente);

            PacienteService service = new PacienteService();

            string mensaje = service.Guardar(paciente);
            Console.Write(mensaje);
            Console.ReadKey();
            Console.Clear();


        }





        public static void ConsultarConsulta(PacienteService service)
        {
            Console.Clear();
            RespuestaConsulta respuestaConsulta = service.ConsultarConsulta();
            Console.WriteLine(respuestaConsulta.Mensaje);
            if (!respuestaConsulta.Error)
            {

                foreach (var item in respuestaConsulta.pacientes)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static void Modificar(PacienteService service)
        {
            Console.Clear();

            Console.WriteLine("\tModificar una liquidacion");
            Console.Write("\tDigite numero de liquidacion: ");
            string numeroLiquidacion;
            numeroLiquidacion = Console.ReadLine();
            RespuestaBusqueda respuestaBusqueda = service.Buscar(numeroLiquidacion);
            Console.WriteLine(respuestaBusqueda.Mensaje);

            Paciente paciente = service.BuscarId(numeroLiquidacion);
            if (paciente != null)
            {
                Console.Write("Ingrese nuevo valor del servicio de hospitalizacion: ");
                paciente.ValorServicio = decimal.Parse(Console.ReadLine());
                paciente.CalcularCuotaModeradora();
                string mensaje = service.Modificar(paciente);
                Console.Write(mensaje);
                Console.WriteLine(paciente.ToString());
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void Eliminar()
        {
            ConsoleKeyInfo continuar;
            Console.WriteLine("Digite la identificacion que desea eliminar :");
            string identificacion = Console.ReadLine();
            string mensajeEliminar = service.Eliminar(identificacion);
            Console.WriteLine(mensajeEliminar);
            continuar = Console.ReadKey();
        }
    }
}
    

