using System.ComponentModel.DataAnnotations.Schema;

namespace ApiGroupProject.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public decimal price { get; set; }






    }
}
