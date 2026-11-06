using System;

namespace TaskMasterAPI.Models;

public class Task
{

    public int Id {get; set;}
    public string? Titulo {get; set;} = string.Empty;
    public string? Descripcion {get; set;} = string.Empty;
    public bool EstaCompletado {get; set;}
    public DateTime FueCreado {get; set;}
    public DateTime FueActualizado {get; set;}

}
