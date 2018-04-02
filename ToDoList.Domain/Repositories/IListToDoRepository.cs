using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Domain.Repositories
{
    public interface IListToDoRepository : IDisposable
    {
        List<ListToDo> Get();
        ListToDo Get(int id);
        void Create(ListToDo listToDo);
        void UpDate(ListToDo listToDo);
        void Delete(int id);
        void Finaliza(int id);
    }
}
