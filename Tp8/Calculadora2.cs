namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato=0;

        public void Sumar(double termino)
        {
            dato += termino;
        }

        public void Restar(double termino)
        {
            dato -= termino;
        }

        public void Multiplicar(double termino)
        {
            dato *= termino;
        }

        public void Dividir(double termino)
        {
            dato /= termino;
        }

        public void Limpiar()
        {
            dato=0;
        }

        public double Resultado
        {
            get {return dato;}
        }

    }

    public class Operacion
    {
        double resultadoAnterior;
        double nuevoValor;
        TipoOperacion operacion;

        public TipoOperacion OperacionARealizar { get => operacion; set => operacion = value; }

        public double ResultadoAnterior
        {
            get {return resultadoAnterior;}
        }

        public double ResultadoNuevo
        {
            get {return nuevoValor;}
        }

        //Contructor
        public Operacion (double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
        {
            this.resultadoAnterior=resultadoAnterior;
            this.nuevoValor=nuevoValor;
            this.operacion=operacion;
        }

        //Mostrar la Operacion
        public void ShowOperacion()
        {
            Console.WriteLine("Operacion: "+ OperacionARealizar);
            Console.WriteLine("Nuevo Valor: "+ ResultadoNuevo);
            Console.WriteLine("Resultado anterior: "+ ResultadoAnterior);
        }
    }
    
}

public enum TipoOperacion{Suma, Resta, Multiplicacion, Division, Limpiar}