using System.ComponentModel.DataAnnotations;

namespace ToDoListApi.Models
{
    public class ToDoList
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool isDone { get; set; }
    }
}
