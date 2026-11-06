using System;
using Microsoft.AspNetCore.Mvc;
using TaskMasterAPI.Services;

namespace TaskMasterAPI.Controllers;

[ApiController]
[Route("/api/[controller]")]
//api/task esa seria la ruta que estariamos llamando por ejemplo



public class TaskController : ControllerBase
{
    [HttpGet]

    public ActionResult<IEnumerable<Models.Task>> GetTasks()
    {
        return Ok(TaskDataStore.Current.Tasks);
    }

    [HttpGet("{id}")]
    public ActionResult<Models.Task> GetTasks (int id)
    {
        
        var task =  TaskDataStore.Current.Tasks.FirstOrDefault(t => t.Id == id);
        if (task == null)
        {
            return NotFound("No se encontro la tarea");

        }

        return Ok(task);


    }


    [HttpPost]
    public ActionResult<Models.Task> createTask(Models.TaskInsert taskInsert)

    {
        
        var newTask = new Models.Task
        {
            Id = TaskDataStore.Current.Tasks.Max(t => t.Id) + 1,
            FueCreado = DateTime.Now,
            FueActualizado = DateTime.Now,
            EstaCompletado = false,
            Titulo = taskInsert.Titulo,
            Descripcion = taskInsert.Descripcion
        };

        TaskDataStore.Current.Tasks.Add(newTask);
        return Ok(newTask);


    }

    [HttpPut("{id}")]
    public ActionResult<Models.Task> UpdateTask(int id, Models.TaskInsert taskInsert)
    {
        var task = TaskDataStore.Current.Tasks.FirstOrDefault(t => t.Id == id);
        if(task == null)
        {
            
            return NotFound("No se encontro la tarea");

        }

        task.Titulo = taskInsert.Titulo;
        task.Descripcion = taskInsert.Descripcion;
        task.FueActualizado = DateTime.Now;
        return Ok(task);


    }



    [HttpDelete("{id}")]
    public ActionResult deleteTask(int id)
    {
        var task = TaskDataStore.Current.Tasks.FirstOrDefault(t => t.Id == id);
        if (task == null)
        {
            
            return NotFound("No se encontro la tarea");
            
        }

        TaskDataStore.Current.Tasks.Remove(task);
        return NoContent();


    }
    
}
