using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace ApiGroupProject.Models
{
    public class Order 
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
        
        [Column(TypeName = "DateTime")]
        public DateTime Date { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public decimal Total { get; set; }

        [StringLength(80)]
        public string Description { get; set; } = string.Empty;
        [StringLength(80)]
        public string Status { get; set; } = string.Empty;
        

        





    }
    }


