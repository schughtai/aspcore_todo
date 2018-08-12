using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspcore.Models;
using aspcore.Presistence;
using Microsoft.AspNetCore.Mvc;

namespace aspcore.Controllers
{
    public class TasksController
    {
        private readonly TaskContext context;
        public TasksController(TaskContext context)
        {
            this.context = context;
        }
        [HttpGet("api/tasks/all")]
        public  IEnumerable<TaskDetails> GetTasks(){
            return context.TaskDetails.ToList();
        }
    }
}