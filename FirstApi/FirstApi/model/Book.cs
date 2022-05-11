using System.ComponentModel.DataAnnotations;

namespace FirstApi.model
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
    }
}
