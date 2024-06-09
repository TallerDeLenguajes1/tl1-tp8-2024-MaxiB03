// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;
var calculadora = new Calculadora();
var ListaOperaciones = new List<Operacion>();

int num, op;
bool controlOP, controlNUM;
double anterior;

do
{
    Console.WriteLine("==============");
    Console.WriteLine("1- Sumar");
    Console.WriteLine("2- Restar");
    Console.WriteLine("3- Multiplicar");
    Console.WriteLine("4- Dividir");
    Console.WriteLine("5- Limpiar");
    Console.WriteLine("0- Salir");
    Console.WriteLine("==============");

    do
    {
        Console.WriteLine("Ingrese una Operacion: ");
        controlOP=int.TryParse(Console.ReadLine(), out op);
        if(controlOP==false)
        {
            Console.WriteLine("Operacion Ingresada Incorrecta, Ingrese nuevamente");
        }
    } while (controlOP==false || op<0 || op>5);

    if(op!=0)
    {
        if(op!=5)
        {
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                controlNUM=int.TryParse(Console.ReadLine(), out num);
                if(controlNUM==false)
                {
                    Console.WriteLine("No Ingreso un numero, Ingrese nuevamente");
                }    
            } while (controlNUM==false);

            switch (op)
            {
                case 1:
                    anterior=calculadora.Resultado;
                    calculadora.Sumar(num);
                    var operacion1 = new Operacion(anterior, calculadora.Resultado, TipoOperacion.Suma);
                    ListaOperaciones.Add(operacion1);
                break;
                case 2:
                    anterior=calculadora.Resultado;
                    calculadora.Restar(num);
                    var operacion2 = new Operacion(anterior, calculadora.Resultado, TipoOperacion.Resta);
                    ListaOperaciones.Add(operacion2);
                break;
                case 3:
                    anterior=calculadora.Resultado;
                    calculadora.Multiplicar(num);
                    var operacion3 = new Operacion(anterior, calculadora.Resultado, TipoOperacion.Multiplicacion);
                    ListaOperaciones.Add(operacion3);
                break;
                case 4:
                    anterior=calculadora.Resultado;
                    calculadora.Dividir(num);
                    var operacion4 = new Operacion(anterior, calculadora.Resultado, TipoOperacion.Division);
                    ListaOperaciones.Add(operacion4);
                break;

                default:
                Console.WriteLine("La Operacion Ingresada no existe");
                break;
            }

        }else{
            anterior=calculadora.Resultado;
            calculadora.Limpiar();
            var operacion5 = new Operacion(anterior, calculadora.Resultado, TipoOperacion.Limpiar);
            ListaOperaciones.Add(operacion5);
        }
    }
    
} while (op!=0);

Console.WriteLine("--- LISTA DE OPERACIONES ---");
foreach (var operacion in ListaOperaciones)
{
    operacion.ShowOperacion();
    Console.WriteLine("-----------");
}