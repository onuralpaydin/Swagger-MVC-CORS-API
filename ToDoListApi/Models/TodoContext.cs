using Microsoft.EntityFrameworkCore;

namespace ToDoListApi.Models
{
    public class TodoContext:DbContext
    {
        public TodoContext(DbContextOptions<TodoContext>options):base(options)
        {

        }
        public DbSet<ToDoList> tbl_TodoList { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoList>().HasData(
                new ToDoList() { Id = 1, Name = "Api Çalış", isDone = false },
                new ToDoList() { Id = 2, Name = "EF Çalış", isDone = true }, 
                new ToDoList() { Id = 3, Name = "MVC Çalış", isDone = false }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
