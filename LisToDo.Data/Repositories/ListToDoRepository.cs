using LisToDo.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using ToDoList.Domain;
using ToDoList.Domain.Repositories;

namespace LisToDo.Data.Repositories
{
    public class ListToDoRepository : IListToDoRepository
    {
        private AppDataContext _db;

        public ListToDoRepository()
        {
            _db = new AppDataContext();
        }

        public void Create(ListToDo listToDo)
        {
            ListToDo lis = new ListToDo(listToDo.NomeItem, listToDo.DescricaoItem);
            _db.ListToDos.Add(lis);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            _db.ListToDos.Remove(Get(id));
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Finaliza(int id)
        {
            ListToDo lis = Get(id);

            lis.Status = "Concluido";
            lis.DataConclusao = DateTime.Now.Date;

            UpDate(lis);
        }

        public List<ListToDo> Get()
        {
            return _db.ListToDos.OrderBy(x => x.DataDeCriacao).ToList();
        }

        public ListToDo Get(int id)
        {
            return _db.ListToDos.Find(id);
        }

        public void UpDate(ListToDo listToDo)
        {
            _db.Entry<ListToDo>(listToDo).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
