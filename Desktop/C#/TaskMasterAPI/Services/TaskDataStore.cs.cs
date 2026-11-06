namespace TaskMasterAPI.Services;

public class TaskDataStore
{
  public List<Models.Task> Tasks { get; set; }

  public static TaskDataStore Current { get; } = new TaskDataStore();

  public TaskDataStore()
  {
    Tasks =
    [
      new Models.Task(){
            Id = 1,
            Titulo = "Aprender C#",
            Descripcion = "Aprender los fundamentos C#",
            EstaCompletado = false,
            FueCreado = DateTime.Now,
            FueActualizado = DateTime.Now
        },
        new Models.Task(){
            Id = 2,
            Titulo = "Aprender ASP.NET Core",
            Descripcion = "Aprender los fundamentos ASP.NET Core",
            EstaCompletado = false,
            FueCreado = DateTime.Now,
            FueActualizado = DateTime.Now
        },
        new Models.Task(){
            Id = 3,
            Titulo = "Aprender Entity Framework Core",
            Descripcion = "Aprender los fundamentos Entity Framework Core",
            EstaCompletado = false,
            FueCreado = DateTime.Now,
            FueActualizado = DateTime.Now
        }
    ];
  }
}