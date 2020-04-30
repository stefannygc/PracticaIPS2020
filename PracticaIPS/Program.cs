using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BLL.LiquidaCuotaService;

namespace PracticaIPS
{
    class Program
    {

        static List<LiquidaCuota> liquidaCuotas = new List<LiquidaCuota>();
        static LiquidaCuotaService service = new LiquidaCuotaService();
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
            LiquidaCuota liquidaCuota;
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
                liquidaCuota = new Subsidiado();
            }
            else
            {
                liquidaCuota = new Contributivo();
            }


            liquidaCuota.Identificacion = identificacion;
            liquidaCuota.Tarifa = Tarifa;
            liquidaCuota.NumLiquidacion = numeroLiquidacion;
            liquidaCuota.TipoAfiliacion = tipoAfiliacion;
            liquidaCuota.Salario = salario;
            liquidaCuota.ValorServicio = valorServicio;
            liquidaCuota.CalcularCuotaModeradora();
            liquidaCuotas.Add(liquidaCuota);

            LiquidaCuotaService service = new LiquidaCuotaService();

            string mensaje = service.Guardar(liquidaCuota);
            Console.Write(mensaje);
            Console.ReadKey();
            Console.Clear();


        }





        public static void ConsultarConsulta(LiquidaCuotaService service)
        {
            Console.Clear();
            RespuestaConsulta respuestaConsulta = service.ConsultarConsulta();
            Console.WriteLine(respuestaConsulta.Mensaje);
            if (!respuestaConsulta.Error)
            {

                foreach (var item in respuestaConsulta.liquidaCuotas)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static void Modificar(LiquidaCuotaService service)
        {
            Console.Clear();

            Console.WriteLine("\tModificar una liquidacion");
            Console.Write("\tDigite numero de liquidacion: ");
            string numeroLiquidacion;
            numeroLiquidacion = Console.ReadLine();
            RespuestaBusqueda respuestaBusqueda = service.Buscar(numeroLiquidacion);
            Console.WriteLine(respuestaBusqueda.Mensaje);

            LiquidaCuota liquidaCuota = service.BuscarId(numeroLiquidacion);
            if (liquidaCuota != null)
            {
                Console.Write("Ingrese nuevo valor del servicio de hospitalizacion: ");
                liquidaCuota.ValorServicio = decimal.Parse(Console.ReadLine());
                liquidaCuota.CalcularCuotaModeradora();
                string mensaje = service.Modificar(liquidaCuota);
                Console.Write(mensaje);
                Console.WriteLine(liquidaCuota.ToString());
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
    

