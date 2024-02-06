using DAL.Data;
using Models.Models;

namespace DAL.Interfaces
{
    public interface IToDo
    {
        Task<List<todo>> GetArrToDos();
        Task<bool> DeleteTodo(int id);
        Task<bool> UpdateTodo(todo todo);
        Task<bool>Addtodo(todo todo);






    }
}
