using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace ApiGroupProject.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [StringLength(30)]
       

        public string Description { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public decimal price { get; set; }






    }
}
