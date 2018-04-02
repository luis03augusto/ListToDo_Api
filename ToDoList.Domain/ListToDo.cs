using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Domain
{
    public class ListToDo
    {
        public int Id { get; set; }
        public string NomeItem { get; set; }
        public string DescricaoItem { get; set; }
        public string Status { get; set; }
        public DateTime DataDeCriacao { get; set; }
        public Nullable<DateTime> DataConclusao { get; set; }

        public ListToDo(string nomeItem, string descricaoItem)
        {
            NomeItem = nomeItem;
            DescricaoItem = descricaoItem;
            Status = "Pendente";
            DataDeCriacao = DateTime.Now.Date;
            DataConclusao = null;
        }
        public ListToDo()
        {

        }
    }
}
