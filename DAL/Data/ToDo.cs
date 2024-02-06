using Models.Models;
using Microsoft.EntityFrameworkCore;
using DAL.Interfaces;
namespace DAL.Data
{
    public class ToDo : IToDo
    {

        private readonly AllContext _context;

        public ToDo(AllContext context)
        {
            _context = context;
        }
        public async Task<List<todo>> GetArrToDos()
        {
           
            List<todo> todos = await _context.Todo.ToListAsync();
            return todos;
        }
        public async Task<bool> DeleteTodo(int id)
        {
            var idTodo = _context.Todo.FirstOrDefault(x => x.id == id);
            _context.Todo.Remove(idTodo);
            var isOk = _context.SaveChanges() > 0;
            return isOk;
        }

        public async Task<bool> UpdateTodo(todo todo)
        {
            var idTodo = _context.Todo.FirstOrDefault(x => x.id == todo.id);
            if (idTodo == null)
            {
                return false;
            }
            idTodo.time = todo.time;
            idTodo.titel = todo.titel;
            idTodo.cheked = todo.cheked;
            idTodo.content = todo.content;
            var isOk = _context.SaveChanges() > 0;
            return isOk;

        }

        public async Task<bool> Addtodo(todo todo)
        {
            
            await _context.Todo.AddAsync(todo);
            var isOk = _context.SaveChanges() > 0;
            return isOk;
        }

        


    }
}


