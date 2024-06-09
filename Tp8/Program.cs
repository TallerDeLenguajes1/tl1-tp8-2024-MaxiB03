// See https://aka.ms/new-console-template for more information
int resp;
var TareasPendientes = new List<Tarea>();
var TareasRealizadas = new List<Tarea>();

int cantidadDeTareas=(new Random()).Next(6);

TareasPendientes=CrearListaDeTareas(cantidadDeTareas);
var copiaTareasPendientes = new List<Tarea>(TareasPendientes);

Console.WriteLine("Cantidad Total de Tareas: "+ TareasPendientes.Count);

foreach (var tarea in copiaTareasPendientes)
{
    tarea.ShowTarea();

    Console.WriteLine("Realizo la tarea? (Si=1) (No=0)");
    bool control = int.TryParse(Console.ReadLine(), out resp);

    if(control)
    {
        if(resp==1)
        {
            tarea.Estado = EstadoTarea.Completada;
            TareasRealizadas.Add(tarea);
            TareasPendientes.Remove(tarea);
        }

    }else{
        Console.WriteLine("Respuesta mal ingresada");
    }

    Console.WriteLine("-----------");
}

Console.WriteLine("--- TAREAS PENDIENTES ---");
foreach (var tarea in TareasPendientes)
{
    tarea.ShowTarea();
    Console.WriteLine("-----------");
}

Console.WriteLine("--- TAREAS REALIZADAS ---");
foreach (var tarea in TareasRealizadas)
{
    tarea.ShowTarea();
    Console.WriteLine("-----------");
}

Console.WriteLine("Ingrese una Descripcion para buscar una tarea: ");
string? descrip=Console.ReadLine();

Tarea? tareaBuscada = BuscarTarea(TareasPendientes, TareasRealizadas, descrip);

if(tareaBuscada!=null)
{
    Console.WriteLine("--- TAREAS ENCONTRADA ---");
    tareaBuscada.ShowTarea();
}else{
    Console.WriteLine("--- TAREAS NO ENCONTRADA ---");
}

//Funcion para crear la Lista de N Tareas
List<Tarea> CrearListaDeTareas(int cantidad)
{
    var Tareas = new List<Tarea>();
    for (int i=0;i<cantidad;i++)
    {
        var tarea = new Tarea(i+1, $"Descripcion {i}", (new Random()).Next(10,101), EstadoTarea.Pendiente);
        Tareas.Add(tarea);
    }

    return Tareas;
}

//Funcion para Buscar Tarea por Descripcion
Tarea? BuscarTarea(List<Tarea> tareas1 , List<Tarea> tareas2,  string descripcion)
{
    foreach (var tarea in tareas1)
    {
        if(tarea.Descripcion.Contains(descripcion))
        {
            return tarea;
        }
    }

    foreach (var tarea in tareas2)
    {
        if(tarea.Descripcion.Contains(descripcion))
        {
            return tarea;
        }
    }

    return null;
}