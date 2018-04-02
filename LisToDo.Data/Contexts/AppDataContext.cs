using System.Data.Entity;
using ToDoList.Domain;

namespace LisToDo.Data.Contexts
{
    public class AppDataContext : DbContext
    {
        public AppDataContext()
            :base("LisToDoDb")
        { }

        public DbSet<ListToDo> ListToDos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ListToDo>().Property(x => x.DataConclusao).IsOptional();
            base.OnModelCreating(modelBuilder);
        }
    }
}
