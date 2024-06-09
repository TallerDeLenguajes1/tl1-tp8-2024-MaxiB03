// See https://aka.ms/new-console-template for more information
public class Tarea
{
    int idTarea;
    string? descripcion;
    int duracion;
    EstadoTarea estado;

    //Constructor
    public Tarea(int idTarea, string descripcion, int duracion, EstadoTarea estado)
    {
        this.idTarea=idTarea;
        this.descripcion=descripcion;
        this.duracion=duracion;
        this.estado=estado;
    }

    public int IdTarea { get => idTarea; set => idTarea = value; }
    public string? Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }
    public EstadoTarea Estado { get => estado; set => estado = value; }

    public void ShowTarea()
    {
        Console.WriteLine("Id Tarea: "+IdTarea);
        Console.WriteLine("Descripcion: "+Descripcion);
        Console.WriteLine("Duracion: "+Duracion);
        Console.WriteLine("Estado: "+Estado.ToString());
    }
}

public enum EstadoTarea {Pendiente=0, Completada=1}